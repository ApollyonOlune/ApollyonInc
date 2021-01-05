using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas.Enums
{
    public enum Indicador_da_IE_do_Destinatário: int
    {
        [Display(Name = "Não Contrinbuinte")]
        NC = 0,
        [Display(Name = "Contrinbuinte do ICMS")]
        CI = 1,
        [Display(Name = "Contrinbuinte Insento de Inscrição")]
        CII = 2
    }
}
