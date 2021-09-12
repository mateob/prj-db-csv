using CsvHelper.Configuration;
using prj_db_csv.model;

namespace prj_db_csv.mapper
{
    public sealed class PatientMap : ClassMap<PatientModel>
    {
        public PatientMap()
        {
            Map(m => m.DataExtracao).Name(PatientConstants.DataExtracao);
            Map(m => m.IdUsuario).Name(PatientConstants.IdUsuario);
            Map(m => m.Situacao).Name(PatientConstants.Situacao);
            Map(m => m.CentralRegulacaoOrigem).Name(PatientConstants.CentralRegulacaoOrigem);
            Map(m => m.DataSolicitacao).Name(PatientConstants.DataSolicitacao);
            Map(m => m.Sexo).Name(PatientConstants.Sexo);
            Map(m => m.Idade).Name(PatientConstants.Idade);
            Map(m => m.MunicipioResidencia).Name(PatientConstants.MunicipioResidencia);
            Map(m => m.Solicitante).Name(PatientConstants.Solicitante);
            Map(m => m.MunicipioSolicitante).Name(PatientConstants.MunicipioSolicitante);
            Map(m => m.CodigoCID).Name(PatientConstants.CodigoCID);
            Map(m => m.Carater).Name(PatientConstants.Carater);
            Map(m => m.TipoInternacao).Name(PatientConstants.TipoInternacao);
            Map(m => m.TipoLeito).Name(PatientConstants.TipoLeito);
            Map(m => m.DataAutorizacao).Name(PatientConstants.DataAutorizacao);
            Map(m => m.DataInternacao).Name(PatientConstants.DataInternacao);
            Map(m => m.DataAlta).Name(PatientConstants.DataAlta);
            Map(m => m.Executante).Name(PatientConstants.Executante);
            Map(m => m.HorasNaFila).Name(PatientConstants.HorasNaFila);
        }
    }
}