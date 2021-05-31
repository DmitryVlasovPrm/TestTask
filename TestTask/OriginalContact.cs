using CsvAttrib = CsvHelper.Configuration.Attributes;

namespace TestTask
{
	public class OriginalContact
	{
		[CsvAttrib.Index(0)]
		public string PhoneNumber { get; set; }
		[CsvAttrib.Index(1)]
		public string LastName { get; set; }
		[CsvAttrib.Index(2)]
		public string FirstName { get; set; }
		[CsvAttrib.Index(3)]
		public string PatronymicName { get; set; }
		[CsvAttrib.Index(4)]
		public string CategoryName { get; set; }
		[CsvAttrib.Index(5)]
		public string Sex { get; set; }
		[CsvAttrib.Index(6)]
		public string CityName { get; set; }
		[CsvAttrib.Index(7)]
		public string BirthdayDate { get; set; }

		public OriginalContact FormatData()
		{
			// (Значений много) LINQ намного медленнее
			PhoneNumber = StringFunctions.GetOnlyNumbers(PhoneNumber);
			if (PhoneNumber.Length < 10)
				return null;

			// (Значений много) LINQ намного медленнее
			CityName = StringFunctions.TrimSpecificSymbols(CityName);
			if (CityName.Length < 1)
				CityName = "не определен";

			if (Sex != "ж" && Sex != "м")
				Sex = null;

			return this;
		}
	}
}
