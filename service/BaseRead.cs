using CsvHelper;
using CsvHelper.Configuration;
using prj_db_csv.mapper;
using prj_db_csv.model;
using prj_db_csv.service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace prj_db_csv.controller
{
    public class BaseRead : IBaseRead
    {
        private string path;

        public BaseRead(string path)
        {
            this.path = path;
        }

        public List<PropertyInfo> GetPropertiesPatient() => typeof(PatientModel).GetProperties().ToList();

        public List<PatientModel> ReadCsvPatientModel()
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ",",
                    MissingFieldFound = null
                };
                using (var reader = new StreamReader(this.path, Encoding.Default))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<PatientMap>();
                    var records = csv.GetRecords<PatientModel>().ToList();
                    return records;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new Exception(e.Message);
            }
            catch (FieldValidationException e)
            {
                throw new Exception(e.Message);
            }
            catch (CsvHelperException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}