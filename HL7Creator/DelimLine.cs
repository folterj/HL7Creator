using System;

namespace HL7Creator
{
	class DelimLine
	{
		string[] items;

		public DelimLine()
		{
			items = new string[0];
		}

		public string toString()
		{
			string s = "";

			for (int i=0;i<items.Length;i++) {
				if (i > 0) {
					s += "|";
				}
				s += items[i];
			}

			return s;
		}

		public string this[int index]
		{
			get
			{
				return items[index];
			}
			set
			{
				if (index >= items.Length) {
					Array.Resize<string>(ref items, index + 1);
				}
				items[index] = value;
			}
		}
	}
}
