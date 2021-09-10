using System.Collections.Generic;
using System.Reflection;
using prj_db_csv.model;

namespace prj_db_csv.service
{
    public interface IBaseRead
    {
        List<PatientModel> ReadCsvPatientModel();
        List<PropertyInfo> GetPropertiesPatient();
    }
}