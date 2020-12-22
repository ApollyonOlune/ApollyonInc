using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class DadoBancario
    {
        public int Id { get; set; }
        public DadoBancario DadosBancarios { get; set; }
        public ICollection<Banco> Bancos { get; set; }
        [Display(Name = "Agência")]
        public string Agencia { get; set; }
        [Display(Name = "Dígito da Agência")]
        public string DigitoAgencia { get; set; }
        public string Conta { get; set; }
        [Display(Name = "Dígito da Conta")]
        public string DigitoConta { get; set; }
        [Display(Name = "Observações")]
        public string Observacoes { get; set; }
        public bool Ativo { get; set; }
        public bool Padrao { get; set; }

        public DadoBancario()
        {
        }

        public DadoBancario(int id, DadoBancario dadosBancarios, string agencia, string digitoAgencia, string conta, string digitoConta, string observacoes, bool ativo, bool padrao)
        {
            Id = id;
            DadosBancarios = dadosBancarios;
            Agencia = agencia;
            DigitoAgencia = digitoAgencia;
            Conta = conta;
            DigitoConta = digitoConta;
            Observacoes = observacoes;
            Ativo = ativo;
            Padrao = padrao;
        }
    }
}
