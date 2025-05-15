
namespace HL7Creator
{
	class DefaultObservationType
	{
		public DeviceType deviceType;
		public int objectNumber;
		public ObservationType observationType;
		public ObservationUnit observationUnit;
		public int nobs;

		public DefaultObservationType(DeviceType deviceType, int objectNumber, ObservationType observationType, ObservationUnit observationUnit, int nobs)
		{
			this.deviceType = deviceType;
			this.objectNumber = objectNumber;
			this.observationType = observationType;
			this.observationUnit = observationUnit;
			this.nobs = nobs;
		}
	}
}
