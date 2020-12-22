using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class Contato
    {
        public int IdContato { get; set; }
        public Contato Contatos { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        public bool Ativo { get; set; }

        public Contato()
        {
        }

        public Contato(int idContato, Contato contatos, string nome, string cargo, string telefone, string email, bool ativo)
        {
            IdContato = idContato;
            Contatos = contatos;
            Nome = nome;
            Cargo = cargo;
            Telefone = telefone;
            Email = email;
            Ativo = ativo;
        }
    }
}
