using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HL7Creator
{
	public partial class MainForm : Form
	{
		Array deviceTypes;
		Array allObsTypes;
		Array obsTypes;
		Array obsUnits;

		List<DefaultObservationType> defaultObservationTypes = new List<DefaultObservationType>();
		List<DefaultObservationType> defaultObsDevTypes = new List<DefaultObservationType>();

		DeviceType findDevType;

		DeviceType selDevType;

		List<Observation> observations = new List<Observation>();
		string hl7;
		List<DelimLine> hl7lines = new List<DelimLine>();
		int hier1, hier2, hier3, hier4, hier5;
		int msgId = 0;

		bool fullTextConstants = true;


		public MainForm()
		{
			InitializeComponent();

			defineObsTypes();

			// Populate units
			obsUnits = Enum.GetValues(typeof(ObservationUnit));
			obsUnitsCombo.DataSource = obsUnits;

			// Populate observation types
			allObsTypes = Enum.GetValues(typeof(ObservationType));
			obsTypes = allObsTypes;
			obsTypeCombo.DataSource = obsTypes;

			// Populate device types
			deviceTypes = Enum.GetValues(typeof(DeviceType));
			List<string> deviceTypes0 = new List<string>();
			foreach (DeviceType defType in deviceTypes)
			{
				deviceTypes0.Add(string.Format("104{0:00} - {1}", (int)defType, defType));
			}
			deviceTypeCombo.DataSource = deviceTypes0.ToArray();

			hierInit();

			clearAll();
		}

		void selectDeviceType()
		{
			int i = 0;

			foreach (DeviceType defType in deviceTypes)
			{
				if (defType == selDevType)
				{
					if (i < deviceTypeCombo.Items.Count)
					{
						deviceTypeCombo.SelectedIndex = i;
					}
				}
				i++;
			}
		}

		void defineObsTypes()
		{
			addObsType(DeviceType.SCALE, 1, ObservationType.MASS_BODY_ACTUAL, ObservationUnit.KILO_G, 1);
			addObsType(DeviceType.SCALE, 2, ObservationType.LEN_BODY_ACTUAL, ObservationUnit.CENTI_M, 1);
			addObsType(DeviceType.SCALE, 3, ObservationType.RATIO_MASS_BODY_LEN_SQ, ObservationUnit.KG_PER_M_SQ, 1);

			addObsType(DeviceType.BP, 1, ObservationType.PRESS_BLD_NONINV, ObservationUnit.MMHG, 3);
			addObsType(DeviceType.BP, 2, ObservationType.PULS_RATE_NON_INV, ObservationUnit.BEAT_PER_MIN, 1);

			addObsType(DeviceType.GLUCOSE, 1, ObservationType.CONC_GLU_CAPILLARY_WHOLEBLOOD, ObservationUnit.MILLI_MOLE_PER_L, 1);
			addObsType(DeviceType.GLUCOSE, 2, ObservationType.CTXT_GLU_MEAL, ObservationUnit.NONE, 1);
			addObsType(DeviceType.GLUCOSE, 3, ObservationType.CTXT_GLU_EXERCISE, ObservationUnit.PERCENT, 1);

			addObsType(DeviceType.SPO2, 1, ObservationType.PULS_OXIM_SAT_O2, ObservationUnit.PERCENT, 1);
			addObsType(DeviceType.SPO2, 2, ObservationType.PULS_OXIM_PULS_RATE, ObservationUnit.BEAT_PER_MIN, 1);

			addObsType(DeviceType.ILAH, 1, ObservationType.AI_TYPE_SENSOR_MOTION, ObservationUnit.NONE, 1);

			addObsType(DeviceType.ILAH, 1, ObservationType.AI_TYPE_SENSOR_USAGE, ObservationUnit.NONE, 1);
		}

		void addObsType(DeviceType devType, int objectNumber, ObservationType obsType, ObservationUnit defUnit, int nobs)
		{
			defaultObservationTypes.Add(new DefaultObservationType(devType, objectNumber, obsType, defUnit, nobs));
		}

		void setFindDeviceType(DeviceType deviceType)
		{
			findDevType = deviceType;
		}

		bool findDeviceType(DefaultObservationType defObsType)
		{
			return (defObsType.deviceType == findDevType);
		}

		int findObjectNumber(DeviceType deviceType, ObservationType obsType)
		{
			int i = 0;

			foreach (DefaultObservationType type in defaultObservationTypes)
			{
				if (type.deviceType == deviceType && type.observationType == obsType)
				{
					i = type.objectNumber;
				}
			}
			return i;
		}

		void createHL7()
		{
			construct();
			hl7Text.Text = hl7;
			lengthText.Text = hl7.Length.ToString();
		}

		void construct()
		{
			// construct HL7 lines
			DateTimeOffset start = new DateTimeOffset();
			DateTimeOffset end = new DateTimeOffset();
			UInt32 type, unit;
			int obsi = 0;
			bool firstObservation = true;
			int devTypeIndex = deviceTypeCombo.SelectedIndex;
			UInt32 configId = 0;
			UInt32 devProfileId = 0;
			string[] values;
			string value;
			string gatewayName = gatewayNameText.Text;
			string gatewayEui = gatewayEuiText.Text;
			string eui = deviceEuiText.Text;
			bool timeSync = timeSyncCheck.Checked;

			fullTextConstants = textConstantsCheck.Checked;

			if (devTypeIndex >= 0)
			{
				DeviceType devType = (DeviceType)deviceTypes.GetValue(devTypeIndex);

				configId = (UInt32)devType * 100;
				devProfileId = 0x1000 + (UInt32)devType;
			}

			hl7lines.Clear();
			hierInit();

			hl7lines.Add(createDevObs(++obsi, devProfileId));

			foreach (Observation observation in observations)
			{
				type = observation.type;

				if (observation.isCompound())
				{
					// hide value and unit in compound observations header obs line
					value = "";
					unit = 0;
					hier3 = observation.objectNumber;
					hier4 = 0;
				}
				else
				{
					value = observation.value;
					unit = observation.units;
					hier3 = 0;
					hier4 = observation.objectNumber;
				}

				hl7lines.Add(createObs(++obsi, type, unit, value, observation.timestamp));

				if (observation.isCompound())
				{
					// compound observation
					value = observation.value;
					values = value.Split(',');
					unit = observation.units;
					for (int i = 0; i < observation.getNObservations(); i++)
					{
						if (i < values.Length)
						{
							value = values[i].Trim();
						}
						type = observation.getCompoundType(i);
						hier4 = i + 1;
						hl7lines.Add(createObs(++obsi, type, unit, value, new DateTimeOffset()));	// 'null' DataTime object (year=1)
					}
				}

				if (observation.timestamp.CompareTo(start) < 0 || firstObservation)
				{
					start = observation.timestamp;
				}
				if (observation.timestamp.CompareTo(end) > 0 || firstObservation)
				{
					end = observation.timestamp;
				}
				firstObservation = false;
			}

			hier3 = 0;
			hier4 = 0;
			if (timeSync)
			{
				type = (int)Nomenclature.MDC_ATTR_TIME_ABS;
				if (Util.isValidDateTime(end))
				{
					value = Util.toHL7String(end, false);
				}
				else
				{
					value = Util.toHL7String(DateTimeOffset.Now, false);
				}
				hl7lines.Add(createObs(++obsi, type, 0, value, DateTimeOffset.Now));
			}

			hl7lines.Insert(0, createRequest(gatewayName, 1, gatewayEui, start, end));
			hl7lines.Insert(0, createHeader(gatewayName, gatewayEui, ++msgId));

			buildHL7();
		}

		void buildHL7()
		{
			// build hl7 string
			hl7 = "";
			foreach (DelimLine line in hl7lines)
			{
				if (hl7 != "")
				{
					hl7 += Constants.lineDelim;
				}
				hl7 += line.toString();
			}
		}

		DelimLine createHeader(string gatewayName, string gatewayEui, int msgId)
		{
			DelimLine header = new DelimLine();

			header[0] = Constants.headerHeader;
			header[1] = Constants.encodingChars;
			header[2] = string.Format("{0}^{1}^EUI-64", gatewayName, gatewayEui);
			header[6] = Util.toHL7String(DateTimeOffset.Now, true);
			header[8] = Constants.msgType;
			header[9] = string.Format("{0}{1:00000}", Constants.msgIdPrefix, msgId);
			header[10] = Constants.processingId;
			header[11] = Constants.versionId;
			header[14] = Constants.neverString;
			header[15] = Constants.alwaysString;
			header[20] = Constants.msgProfile;

			return header;
		}

		DelimLine createRequest(string gatewayName, int i, string eui, DateTimeOffset start, DateTimeOffset end)
		{
			DelimLine request = new DelimLine();

			request[0] = Constants.requestHeader;
			request[1] = string.Format("{0}", i);
			request[2] = string.Format("{0}^{1}^{2}^EUI-64", Constants.arbOrderString, gatewayName, eui);
			request[3] = string.Format("{0}^{1}^{2}^EUI-64", Constants.arbOrderString, gatewayName, eui);
			if (fullTextConstants)
			{
				request[4] = Constants.serviceIdentifierFull;
			}
			else
			{
				request[4] = Constants.serviceIdentifier;
			}
			if (Util.isValidDateTime(start))
			{
				request[7] = Util.toHL7String(start, true);
			}
			if (Util.isValidDateTime(end))
			{
				request[8] = Util.toHL7String(end, true);
			}

			return request;
		}

		DelimLine createDevObs(int i, UInt32 sysType)
		{
			DelimLine obs = new DelimLine();
			string devEUI;
			string text;

			devEUI = deviceEuiText.Text;

			obs[0] = Constants.obsHeader;
			obs[1] = string.Format("{0}", i);

			sysType |= ((int)PrefixConstants.MDC_PART_INFRA * 0x10000);
			text = "";
			if (fullTextConstants)
			{
				text = Util.getCodeText((int)sysType);
			}
			obs[3] = string.Format("{0}^{1}^MDC", sysType, text);
			obs[4] = createHier();
			obs[11] = Constants.statusFixed;
			obs[18] = string.Format("{0}^EUI-64", devEUI);

			return obs;
		}

		DelimLine createObs(int i, UInt32 type, UInt32 unit, string value, DateTimeOffset dt)
		{
			DelimLine obs = new DelimLine();
			string text;
			bool timeSyncType = (type == (int)Nomenclature.MDC_ATTR_TIME_ABS);
			bool ilDeviceType = (type <= (int)ObservationType.AI_TYPE_SENSOR_HUMIDITY);

			obs[0] = Constants.obsHeader;
			obs[1] = string.Format("{0}", i);
			if (type != 0)
			{
				if (timeSyncType)
				{
					type |= ((int)PrefixConstants.MDC_PART_OBJ * 0x10000);
				}
				else if (ilDeviceType)
				{
					type |= ((int)PrefixConstants.MDC_PART_PHD_AI * 0x10000);
				}
				else
				{
					type |= ((int)PrefixConstants.MDC_PART_SCADA * 0x10000);
				}
				text = "";
				if (fullTextConstants)
				{
					text = Util.getCodeText((int)type);
				}
				obs[3] = string.Format("{0}^{1}^MDC", type, text);
			}
			obs[4] = createHier();
			if (value != "")
			{
				if (ilDeviceType && fullTextConstants)
				{
					string[] parts = value.Split("^()".ToCharArray());
					if (parts.Length >= 3)
					{
						int code = int.Parse(parts[2].Trim("()".ToCharArray()));
						string codetext = Util.getFlagText(code, (int)type);
						value = string.Format("{0}^{1}({2})", parts[0], codetext, parts[2]);
					}
				}
				if ((UInt16)type == (UInt16)Nomenclature.MDC_ATTR_TIME_ABS ||
					(UInt16)type == (UInt16)Nomenclature.MDC_ATTR_TIME_BO ||
					(UInt16)type == (UInt16)Nomenclature.MDC_ATTR_TIME_STAMP_BO)
				{
					obs[2] = Constants.dtmType;
				}
				else
				{
					obs[2] = Constants.numericType;
				}
				obs[5] = value;
			}
			if (unit != 0)
			{
				unit |= ((int)PrefixConstants.MDC_PART_DIM * 0x10000);
				text = "";
				if (fullTextConstants)
				{
					text = Util.getCodeText((int)unit);
				}
				obs[6] = string.Format("{0}^{1}^MDC", unit, text);
			}
			obs[11] = Constants.statusResult;
			if (Util.isValidDateTime(dt))
			{
				obs[14] = Util.toHL7String(dt, true);
			}

			return obs;
		}

		void clearAll()
		{
			// Select Device Type: Scale
			selDevType = DeviceType.SCALE;
			selectDeviceType();

			gatewayEuiText.Text = "0000000000000000";
			deviceEuiText.Text = "0000000000000000";
			gatewayNameText.Text = "HL7Creator";
			textConstantsCheck.Checked = true;
			timeSyncCheck.Checked = false;

			clearObs();

			clearHL7();
		}

		void clearHL7()
		{
			hl7lines.Clear();
			hl7 = "";
			hl7Text.Clear();
		}

		void clearObs()
		{
			obsDateTime.ResetText();
			obsOffsetSignCombo.SelectedIndex = 0;
			obsOffsetHoursText.Text = "00";
			obsOffsetMinsText.Text = "00";
			obsValueText.Text = "0";
			obsTypeCombo.SelectedIndex = 0;
			updateDefObsUnits();

			observations.Clear();
			obsListView.Items.Clear();
		}

		void hierInit()
		{
			hier1 = 1;
			hier2 = 0;
			hier3 = 0;
			hier4 = 0;
			hier5 = 0;
		}
		
		string createHier()
		{
			string format = "";

			if (hier5 != 0)
			{
				format = "{0}.{1}.{2}.{3}.{4}";
			}
			else if (hier4 != 0)
			{
				format = "{0}.{1}.{2}.{3}";
			}
			else if (hier3 != 0)
			{
				format = "{0}.{1}.{2}";
			}
			else if (hier2 != 0)
			{
				format = "{0}.{1}";
			}
			else if (hier1 != 0)
			{
				format = "{0}";
			}
			return string.Format(format, hier1, hier2, hier3, hier4, hier5);
		}

		void refreshObservations()
		{
			obsListView.Items.Clear();
			foreach (Observation observation in observations)
			{
				obsListView.Items.Add(new ListViewItem(observation.toStrings()));
			}
		}

		private void deviceTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = deviceTypeCombo.SelectedIndex;

			if (index >= 0)
			{
				selDevType = (DeviceType)deviceTypes.GetValue(index);

				setFindDeviceType(selDevType);
				defaultObsDevTypes = defaultObservationTypes.FindAll(findDeviceType);

				List<ObservationType> obsTypes0 = new List<ObservationType>();
				foreach (DefaultObservationType defObsType in defaultObsDevTypes)
				{
					obsTypes0.Add(defObsType.observationType);
				}
				if (obsTypes0.Count > 0)
				{
					setObsTypeComboSource(obsTypes0.ToArray());
				}
				else
				{
					setObsTypeComboSource(allObsTypes);
				}
				obsTypeCombo.DataSource = obsTypes;
				updateDefObsUnits();
			}
		}

		private void setObsTypeComboSource(Array data)
		{
			int maxwidth = 0;
			int width;

			obsTypes = data;

			foreach (object obj in data)
			{
				width = TextRenderer.MeasureText(obj.ToString(), obsTypeCombo.Font).Width;
				if (width > maxwidth)
				{
					maxwidth = width;
				}
			}
			if (obsTypeCombo.Width > maxwidth)
			{
				maxwidth = obsTypeCombo.Width;
			}
			obsTypeCombo.DropDownWidth = maxwidth;
		}

		private void obsTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateDefObsUnits();
		}

		void updateDefObsUnits()
		{
			int index = obsTypeCombo.SelectedIndex;
			ObservationUnit selObsUnit = ObservationUnit.NONE;
			int nobs = 1;
			string defValue = "";
			string defVal = "0";
			int i = 0;

			if (index >= 0)
			{
				ObservationType type = (ObservationType)obsTypes.GetValue(index);

				foreach (DefaultObservationType defObsType in defaultObsDevTypes)
				{
					if (defObsType.observationType == type)
					{
						selObsUnit = defObsType.observationUnit;
						nobs = defObsType.nobs;
					}
				}
				if (selDevType == DeviceType.ILAH)
				{
					defVal = "1^(0)";
				}
				foreach (ObservationUnit obsUnit in obsUnits)
				{
					if (obsUnit == selObsUnit)
					{
						if (i < obsUnitsCombo.Items.Count)
						{
							obsUnitsCombo.SelectedIndex = i;
						}
					}
					i++;
				}
				for (i = 0; i < nobs; i++)
				{
					if (i > 0)
					{
						defValue += ", ";
					}
					defValue += defVal;
				}
				obsValueText.Text = defValue;
			}
		}

		private void deviceEuiButton_Click(object sender, EventArgs e)
		{
			deviceEuiText.Text = string.Format("{0:X16}", Util.getRandomEui());
		}

		private void gatewayEuiButton_Click(object sender, EventArgs e)
		{
			gatewayEuiText.Text = string.Format("{0:X16}", Util.getRandomEui());
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			DateTimeOffset timeStamp0, timeStamp;
			TimeSpan timeOffset;
			int offsetHours, offsetMins;
			ObservationType obsType = 0;
			UInt32 type = 0;
			string value;
			ObservationUnit obsUnit = 0;
			UInt32 units = 0;
			int index;

			timeStamp0 = obsDateTime.Value;
			int.TryParse(obsOffsetHoursText.Text, out offsetHours);
			int.TryParse(obsOffsetMinsText.Text, out offsetMins);
			timeOffset = new TimeSpan(offsetHours, offsetMins, 0);
			if (obsOffsetSignCombo.SelectedIndex == 1)
			{
				timeOffset = -timeOffset;
			}
			timeStamp = new DateTimeOffset(timeStamp0.DateTime, timeOffset);	// DateTimeOffset.DateTime avoids offset error

			index = obsTypeCombo.SelectedIndex;
			if (index >= 0)
			{
				obsType = (ObservationType)obsTypes.GetValue(index);
				type = (UInt32)obsType;
			}

			index = obsUnitsCombo.SelectedIndex;
			if (index >= 0)
			{
				obsUnit = (ObservationUnit)obsUnits.GetValue(index);
				units = (UInt32)obsUnit;
			}

			value = obsValueText.Text;

			observations.Add(new Observation(timeStamp, findObjectNumber(selDevType, obsType), type, value, units));

			refreshObservations();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			ListView.SelectedIndexCollection i = obsListView.SelectedIndices;
			foreach (int index in i)
			{
				observations.RemoveAt(index);
			}

			refreshObservations();
		}

		private void clearObsButton_Click(object sender, EventArgs e)
		{
			clearObs();
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			if (observations.Count == 0)
			{
				if (MessageBox.Show("No observations added.\nContinue anyway?", "No observations", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return;
				}
			}
			createHL7();
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				TextWriter writer = new StreamWriter(saveFileDialog.FileName);
				writer.Write(hl7);
				writer.Close();
			}
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			clearAll();
		}

		private void wrapButton_Click(object sender, EventArgs e)
		{
			hl7Text.WordWrap = wrapButton.Checked;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutBox().ShowDialog();
		}

		private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control control = getControl(sender);
			if (control != null)
			{
				if (control == hl7Text)
				{
					hl7Text.Focus();
					hl7Text.SelectAll();
				}
				if (control == obsListView)
				{
					obsListView.Focus();
					foreach (ListViewItem item in obsListView.Items)
					{
						item.Selected = true;
					}
				}
			}
		}

		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control control = getControl(sender);
			if (control != null)
			{
				if (control == hl7Text)
				{
					hl7Text.Copy();
				}
				if (control == obsListView)
				{
					Clipboard.SetText(Util.listViewToString(obsListView));
				}
			}
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Control control = getControl(sender);
			if (control != null)
			{
				if (control == hl7Text)
				{
					clearHL7();
				}
				if (control == obsListView)
				{
					clearObs();
				}
			}
		}

		private Control getControl(object sender)
		{
			// get menu source control
			ToolStripDropDownItem item = (ToolStripDropDownItem)sender;
			ContextMenuStrip menu = (ContextMenuStrip)item.Owner;
			Control control = menu.SourceControl;
			if (control == null)
			{
				// if null; get currently active control
				control = ActiveControl;
			}
			return control;
		}

	}
}
