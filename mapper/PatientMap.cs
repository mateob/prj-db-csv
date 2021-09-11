using CsvHelper.Configuration;
using prj_db_csv.model;

namespace prj_db_csv.mapper
{
    public sealed class PatientMap : ClassMap<PatientModel>
    {
        public PatientMap()
        {
            Map(m => m.data_extracao).Name(PatientConstants.data_extracao);
            Map(m => m.LastName).Name(PatientConstants.LastName);
            Map(m => m.Quantity).Name(PatientConstants.Quantity);
            Map(m => m.Email).Name(PatientConstants.Email);
        }
    }
}