using System;
using CsvHelper.Configuration.Attributes;

namespace prj_db_csv.model
{
    public static class PatientConstants
    {
        public const string DataExtracao = "data_extracao";
        public const string IdUsuario = "id_usuario";
        public const string Situacao = "situacao";
        public const string CentralRegulacaoOrigem = "central_regulacao_origem";
        public const string DataSolicitacao = "data_solicitacao";
        public const string Sexo = "sexo";
        public const string Idade = "idade";
        public const string MunicipioResidencia = "municipio_residencia";
        public const string Solicitante = "solicitante";
        public const string MunicipioSolicitante = "municipio_solicitante";
        public const string CodigoCID = "codigo_cid";
        public const string Carater = "carater";
        public const string TipoInternacao = "tipo_internacao";
        public const string TipoLeito = "tipo_leito";
        public const string DataAutorizacao = "data_autorizacao";
        public const string DataInternacao = "data_internacao";
        public const string DataAlta = "data_alta";
        public const string Executante = "executante";
        public const string HorasNaFila = "horas_na_fila";
    }

    public class PatientModel
    {
        [Name(PatientConstants.DataExtracao)]
        public Nullable<DateTime> DataExtracao { get; set; }
        [Name(PatientConstants.IdUsuario)]
        public string IdUsuario { get; set; }
        [Name(PatientConstants.Situacao)]
        public string Situacao { get; set; }
        [Name(PatientConstants.CentralRegulacaoOrigem)]
        public string CentralRegulacaoOrigem { get; set; }
        [Name(PatientConstants.DataSolicitacao)]
        public Nullable<DateTime> DataSolicitacao { get; set; }
        [Name(PatientConstants.Sexo)]
        public string Sexo { get; set; }
        [Name(PatientConstants.Idade)]
        public string Idade { get; set; }
        [Name(PatientConstants.MunicipioResidencia)]
        public string MunicipioResidencia { get; set; }
        [Name(PatientConstants.Solicitante)]
        public string Solicitante { get; set; }
        [Name(PatientConstants.MunicipioSolicitante)]
        public string MunicipioSolicitante { get; set; }
        [Name(PatientConstants.CodigoCID)]
        public string CodigoCID { get; set; }
        [Name(PatientConstants.Carater)]
        public string Carater { get; set; }
        [Name(PatientConstants.TipoInternacao)]
        public string TipoInternacao { get; set; }
        [Name(PatientConstants.TipoLeito)]
        public string TipoLeito { get; set; }
        [Name(PatientConstants.DataAutorizacao)]
        public Nullable<DateTime> DataAutorizacao { get; set; }
        [Name(PatientConstants.DataInternacao)]
        public Nullable<DateTime> DataInternacao { get; set; }
        [Name(PatientConstants.DataAlta)]
        public Nullable<DateTime> DataAlta { get; set; }
        [Name(PatientConstants.Executante)]
        public string Executante { get; set; }
        [Name(PatientConstants.HorasNaFila)]
        public string HorasNaFila { get; set; }
    }
}