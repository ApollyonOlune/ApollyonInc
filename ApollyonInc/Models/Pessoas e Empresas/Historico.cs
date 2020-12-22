using ApollyonInc.Models.Pessoas_e_Empresas.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class Historico
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "ID Ext")]
        public Historico Historicos { get; set; }
        public Tipo_De_Historico Tipo_De_Historico { get; set; }
        public DateTime Data { get; set; }
        [Display(Name = "Histórico")]
        [DataType(DataType.MultilineText)]
        public string HistoricoTEXTO { get; set; }

        public Historico()
        {
        }

        public Historico(int id, Historico historicos, Tipo_De_Historico tipo_De_Historico, DateTime data, string historicoTEXTO)
        {
            Id = id;
            Historicos = historicos;
            Tipo_De_Historico = tipo_De_Historico;
            Data = data;
            HistoricoTEXTO = historicoTEXTO;
        }
    }
}
