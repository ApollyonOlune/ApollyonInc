using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApollyonInc.Models.Pessoas_e_Empresas;

namespace ApollyonInc.Data
{
    public class ApollyonIncContext : DbContext
    {
        public ApollyonIncContext (DbContextOptions<ApollyonIncContext> options)
            : base(options)
        {
        }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.Banco> Banco { get; set; }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.Contato> Contato { get; set; }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.DadoBancario> DadoBancario { get; set; }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.Documento> Documento { get; set; }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.Endereco> Endereco { get; set; }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.Historico> Historico { get; set; }

        public DbSet<ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas> Pessoas_e_Empresas { get; set; }
    }
}
