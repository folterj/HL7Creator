using System;

namespace HL7Creator
{
	class Observation
	{
		public DateTimeOffset timestamp;
		public int objectNumber;
		public UInt32 type;
		public string value;
		public UInt32 units;

		public Observation()
		{
			timestamp = DateTimeOffset.Now;
			objectNumber = 0;
			type = 0;
			value = "";
			units = 0;
		}

		public Observation(DateTimeOffset timestamp, int objectNumber, UInt32 type, string value, UInt32 units)
		{
			this.timestamp = timestamp;
			this.objectNumber = objectNumber;
			this.type = type;
			this.value = value;
			this.units = units;
		}

		public string[] toStrings()
		{
			return new string[] {
				Util.toString(timestamp),
				((ObservationType)type).ToString(),
				value,
				((ObservationUnit)units).ToString()
			};
		}

		public bool isCompound()
		{
			return (getNObservations() > 1);
		}

		public int getNObservations()
		{
			int nobs = 1;

			if ((ObservationType)type == ObservationType.PRESS_BLD_NONINV)
			{
				nobs = 3;
			}
			return nobs;
		}

		public UInt32 getCompoundType(int i)
		{
			UInt32 compType = type;

			if ((ObservationType)type == ObservationType.PRESS_BLD_NONINV)
			{
				switch (i)
				{
					case 0: compType = (UInt32)ObservationType.PRESS_BLD_NONINV_SYS; break;
					case 1: compType = (UInt32)ObservationType.PRESS_BLD_NONINV_DIA; break;
					case 2: compType = (UInt32)ObservationType.PRESS_BLD_NONINV_MEAN; break;
				}
			}
			return compType;
		}

	}
}
