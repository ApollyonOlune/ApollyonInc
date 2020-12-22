using ApollyonInc.Models.Pessoas_e_Empresas.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class Endereco
    {
        public int ID { get; set; }
        public Endereco Enderecos { get; set; }
        [Required(ErrorMessage ="É nescessário que {0} esteja preenchido.")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        [Display(Name = "Número")]
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public bool Ativo { get; set; }
        public bool Padrao { get; set; }

        public Endereco()
        {
        }

        public Endereco(int iD, Endereco enderecos, string cEP, string logradouro, string numero, string complemento, string bairro, string cidade, Estado estado, bool ativo, bool padrao)
        {
            ID = iD;
            Enderecos = enderecos;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Ativo = ativo;
            Padrao = padrao;
        }
    }
}
