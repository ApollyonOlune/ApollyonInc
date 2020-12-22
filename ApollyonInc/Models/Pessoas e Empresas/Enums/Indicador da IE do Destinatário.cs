using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas.Enums
{
    public enum Indicador_da_IE_do_Destinatário
    {
        [Display(Name = "Não Contrinbuinte")]
        NC,
        [Display(Name = "Contrinbuinte do ICMS")]
        CI,
        [Display(Name = "Contrinbuinte Insento de Inscrição")]
        CII,
    }
}
