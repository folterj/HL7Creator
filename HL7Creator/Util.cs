using System;
using System.Windows.Forms;

namespace HL7Creator
{
	class Util
	{
		public static bool isValidDateTime(DateTimeOffset dateTime)
		{
			return (dateTime.Year > 1);
		}

		public static string toString(DateTimeOffset dt)
		{
			return string.Format("{0:yyyy/MM/dd HH:mm:ss zzz}", dt);
		}

		public static string toHL7String(DateTimeOffset dt, bool showOffset)
		{
			string offset;
			offset = dt.ToString("zzz").Replace(":", "");
			if (showOffset)
			{
				return string.Format("{0:yyyyMMddHHmmss}{1}", dt, offset);
			}
			return string.Format("{0:yyyyMMddHHmmss}", dt);
		}

		public static string getCodeText(int code)
		{
			int scode = code & 0xFFFF;

			string codetext = ((Nomenclature)scode).ToString();
			if (codetext != scode.ToString())
			{
				return codetext;
			}
			return "";
		}

		public static string getFlagText(int code, int type)
		{
			string codetext;

			switch ((Nomenclature)(type & 0xFFFF))
			{
				case Nomenclature.MDC_AI_TYPE_SENSOR_FALL:
					codetext = ((MDC_AI_TYPE_SENSOR_FALL_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_PERS:
					codetext = ((MDC_AI_TYPE_SENSOR_PERS_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_SMOKE:
				case Nomenclature.MDC_AI_TYPE_SENSOR_CO:
				case Nomenclature.MDC_AI_TYPE_SENSOR_WATER:
				case Nomenclature.MDC_AI_TYPE_SENSOR_GAS:
					codetext = ((MDC_AI_TYPE_SENSOR_substance_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_MOTION:
					codetext = ((MDC_AI_TYPE_SENSOR_MOTION_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_PROPEXIT:
					codetext = ((MDC_AI_TYPE_SENSOR_PROPEXIT_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_ENURESIS:
					codetext = ((MDC_AI_TYPE_SENSOR_ENURESIS_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_CONTACTCLOSURE:
					codetext = ((MDC_AI_TYPE_SENSOR_CONTACTCLOSURE_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_USAGE:
					codetext = ((MDC_AI_TYPE_SENSOR_USAGE_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_SWITCH:
					codetext = ((MDC_AI_TYPE_SENSOR_SWITCH_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_DOSAGE:
					codetext = ((MDC_AI_TYPE_SENSOR_DOSAGE_flags)code).ToString();
					break;

				case Nomenclature.MDC_AI_TYPE_SENSOR_TEMP:
					codetext = ((MDC_AI_TYPE_SENSOR_TEMP_flags)code).ToString();
					break;

				default:
					codetext = "";
					break;
			}
			return codetext;
		}

		public static UInt64 getRandomEui()
		{
			Random rnd = new Random();
			byte[] eui = new byte[8];
			rnd.NextBytes(eui);
			return BitConverter.ToUInt64(eui, 0);
		}

		public static string listViewToString(ListView listview)
		{
			string s = "";

			foreach (ColumnHeader column in listview.Columns)
			{
				s += column.Text + "\t";
			}
			foreach (ListViewItem item in listview.SelectedItems)
			{
				s += "\r\n";
				for (int i = 0; i < listview.Columns.Count; i++)
				{
					s += item.SubItems[i].Text + "\t";
				}
			}
			return s;
		}

	}
}
