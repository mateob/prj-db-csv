using CsvHelper;
using CsvHelper.Configuration;
using prj_db_csv.mapper;
using prj_db_csv.model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace prj_db_csv.service
{
    public class BaseRead : IBaseRead
    {
        private string path;
        private string delimiter;

        public BaseRead(string path, string delimiter = ";")
        {
            this.path = path;
            this.delimiter = delimiter;
        }

        public List<PatientModel> ReadCsvPatientModel()
        {
            try
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = this.delimiter,
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
                Console.WriteLine($"\r\nErro: Acesso não autorizado ao arquivo!\r\n");
                return new List<PatientModel>();
            }
            catch (FieldValidationException e)
            {
                Console.WriteLine($"\r\nErro: Ocorreu um erro durante o mapeamento dos Fields do arquivo informa!\r\n");
                return new List<PatientModel>();
            }
            catch (CsvHelperException e)
            {
                Console.WriteLine($"\r\nErro: Arquivo CSV mal formatado!\r\nPorfavor revise o arquivo de origem e tente novamente.\r\n");
                return new List<PatientModel>();
            }
            catch (Exception e)
            {
                Console.WriteLine($"\r\nErro: {e.Message}");
                return new List<PatientModel>();
            }
        }
    }
}