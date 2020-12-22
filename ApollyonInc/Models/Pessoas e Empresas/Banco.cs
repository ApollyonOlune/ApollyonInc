using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class Banco
    {
        public int IdBancos { get; set; }
        public Banco Bancos { get; set; }
        [Display(Name = "Código do Banco")]
        public int CodigoBanco { get; set; }
        [Display(Name = "Nome do Banco")]
        public string NomeDoBanco { get; set; }

        public Banco()
        {
        }

        public Banco(int idBancos, Banco bancos, int codigoBanco, string nomeDoBanco)
        {
            IdBancos = idBancos;
            Bancos = bancos;
            CodigoBanco = codigoBanco;
            NomeDoBanco = nomeDoBanco;
        }
    }
}
