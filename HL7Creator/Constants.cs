
namespace HL7Creator
{
	class Constants
	{
		// general constants
		public static string lineDelim = "\r";

		public static string headerHeader = "MSH";
		public static string requestHeader = "OBR";
		public static string obsHeader = "OBX";

		public static string numericType = "NM";
		public static string dtmType = "DTM";
		//public static string codedType = "CWE";
		//public static string stringType = "ST";
		public static string productionId = "P";
		//public static string debuggingId = "D";
		//public static string trainingId = "T";
		public static string statusResult = "R";
		public static string statusFixed = "X";

		// specific constants
		public static string serviceIdentifier = "182777000^^SNOMED-CT";
		public static string serviceIdentifierFull = "182777000^monitoring of patient^SNOMED-CT";

		public static string arbOrderString = "AB12345";
		public static string versionId = "2.6";
		public static string encodingChars = "^~\\&";
		public static string msgType = "ORU^R01^ORU_R01";
		public static string msgIdPrefix = "MSGID";
		public static string processingId = productionId;
		public static string alwaysString = "AL";
		public static string neverString = "NE";
		public static string msgProfile = "IHE PCD ORU-R012006^HL7^2.16.840.1.113883.9.n.m^HL7";
	}
}
