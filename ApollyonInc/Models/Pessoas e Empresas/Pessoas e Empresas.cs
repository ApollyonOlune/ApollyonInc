using ApollyonInc.Models.Pessoas_e_Empresas.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas
{
    public class Pessoas_e_Empresas
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Cliente Bloqueado")]
        public bool ClienteBloqueado { get; set; }
        public bool Cliente { get; set; }
        [Display(Name = "Pessoa Física")]
        public bool PessoaFisica { get; set; }
        [Display(Name = "Pessoa Jurídica")]
        public bool PessoaJuridica { get; set; }
        public bool Fornecedor { get; set; }
        [Display(Name = "Funcionário")]
        public bool Funcionario { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataDeCadastro { get; set; }
        public Status Status { get; set; }
        [Display(Name = "Nome Social")]
        public bool NomeSocial { get; set; }
        [Display(Name = "Nome Social")]
        public string NomeSocialTXT { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Nome/Razão Social")]
        public string NomeRazaoSocial { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Apelido/Nome Fantasia")]
        public string ApelidoNomeFantasia { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "CPF/CNPJ")]
        public string CPFCNPJ { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [Display(Name = "Indicador Da IE Do Destinatario")]
        public Indicador_da_IE_do_Destinatário IndicadorDaIEDoDestinatario { get; set; }
        [Display(Name = "RG/Inscrição Estadual")]
        public string RGInscricaoEstadual { get; set; }
        [Display(Name = "Inscrição Municipal")]
        public string InscricaoMunicipal { get; set; }
        [Display(Name = "Emissor do RG")]
        public string EmissorDoRG { get; set; }
        [Display(Name = "UF Do Emissor")]
        public string UFDoEmissor { get; set; }
        public Sexo Sexo { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Aniversario { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "É nescessário que {0} esteja preenchido.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail para NFE")]
        public string EmailParaNFE { get; set; }
        public string Site { get; set; }
        [Display(Name = "Observação")]
        [DataType(DataType.MultilineText)]
        public string Observacao { get; set; }
        [Display(Name = "Limite De Crédito ")]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        public decimal LimiteDeCredito { get; set; }
        [Display(Name = "ISS Retido na Fonte")]
        public bool IssRetidoNaFonte { get; set; }
        [Display(Name = "Consumidor Final")]
        public bool ConsumidorFinal { get; set; }
        [Display(Name = "Produtor Rural")]
        public bool ProdutorRural { get; set; }
        public bool Serasa { get; set; }

        // Referências A Outras Tabelas
        [Display(Name = "Endereços")]
        public ICollection<Endereco> Enderecos { get; set; }
        public ICollection<Documento> Documentos { get; set; }
        [Display(Name = "Dados Bancários")]
        public ICollection<DadoBancario> DadosBancarios { get; set; }
        [Display(Name = "Histórico")]
        public ICollection<Historico> Historicos { get; set; }
        public ICollection<Contato> Contatos { get; set; }

        //Construtores
        public Pessoas_e_Empresas(int id, bool clienteBloqueado, bool cliente, bool pessoaFisica, bool pessoaJuridica, bool fornecedor, bool funcionario, DateTime dataDeCadastro, Status status, bool nomeSocial, string nomeSocialTXT, string nomeRazaoSocial, string apelidoNomeFantasia, string cPFCNPJ, Indicador_da_IE_do_Destinatário indicadorDaIEDoDestinatario, string rGInscricaoEstadual, string inscricaoMunicipal, string emissorDoRG, string uFDoEmissor, Sexo sexo, DateTime aniversario, string telefone, string celular, string email, string emailParaNFE, string site, string observacao, decimal limiteDeCredito, bool issRetidoNaFonte, bool consumidorFinal, bool produtorRural, bool serasa)
        {
            Id = id;
            ClienteBloqueado = clienteBloqueado;
            Cliente = cliente;
            PessoaFisica = pessoaFisica;
            PessoaJuridica = pessoaJuridica;
            Fornecedor = fornecedor;
            Funcionario = funcionario;
            DataDeCadastro = dataDeCadastro;
            Status = status;
            NomeSocial = nomeSocial;
            NomeSocialTXT = nomeSocialTXT;
            NomeRazaoSocial = nomeRazaoSocial;
            ApelidoNomeFantasia = apelidoNomeFantasia;
            CPFCNPJ = cPFCNPJ;
            IndicadorDaIEDoDestinatario = indicadorDaIEDoDestinatario;
            RGInscricaoEstadual = rGInscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            EmissorDoRG = emissorDoRG;
            UFDoEmissor = uFDoEmissor;
            Sexo = sexo;
            Aniversario = aniversario;
            Telefone = telefone;
            Celular = celular;
            Email = email;
            EmailParaNFE = emailParaNFE;
            Site = site;
            Observacao = observacao;
            LimiteDeCredito = limiteDeCredito;
            IssRetidoNaFonte = issRetidoNaFonte;
            ConsumidorFinal = consumidorFinal;
            ProdutorRural = produtorRural;
            Serasa = serasa;
        }
        public Pessoas_e_Empresas()
        {
        }
    }
}
