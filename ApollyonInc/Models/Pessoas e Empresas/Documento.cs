using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class Documento
    {
        public int Id { get; set; }
        public Documento Documentos { get; set; }
        public string Descrição { get; set; }
        //public string Arquivo { get; set; }
        public Documento()
        {
        }
        public Documento(int id, Documento documentos, string descrição)
        {
            Id = id;
            Documentos = documentos;
            Descrição = descrição;
        }
    }
}
