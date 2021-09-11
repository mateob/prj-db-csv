using System;
using CsvHelper.Configuration.Attributes;

namespace prj_db_csv.model
{
    public static class PatientConstants
    {
        public const string data_extracao = "Data/Hora da Extração";
        public const string LastName = "LastName";
        public const string Quantity = "Quantity";
        public const string Email = "Email";
    }

    public class PatientModel
    {
        [Name(PatientConstants.data_extracao)]
        public DateTime data_extracao { get; set; }
        [Name(PatientConstants.LastName)]
        public string LastName { get; set; }
        [Name(PatientConstants.Quantity)]
        public int Quantity { get; set; }
        [Name(PatientConstants.Email)]
        public string Email { get; set; }
    }
}