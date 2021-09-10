using CsvHelper.Configuration.Attributes;

namespace prj_db_csv.model
{
    public static class PatientConstants
    {
        public const string Name = "Nome";
        public const string LastName = "Sobrenome";
        public const string Quantity = "Quantidade";
    }

    public class PatientModel
    {
        [Name(PatientConstants.Name)]
        public string Name { get; set; }
        [Name(PatientConstants.LastName)]
        public string LastName { get; set; }
        [Name(PatientConstants.Quantity)]
        public int Quantity { get; set; }

    }
}