﻿// <auto-generated />
using System;
using ApollyonInc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApollyonInc.Migrations
{
    [DbContext(typeof(ApollyonIncContext))]
    partial class ApollyonIncContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Banco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("BancosId")
                        .HasColumnType("int");

                    b.Property<int>("CodigoBanco")
                        .HasColumnType("int");

                    b.Property<int?>("DadoBancarioId")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BancosId");

                    b.HasIndex("DadoBancarioId");

                    b.ToTable("Banco");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContatosId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Pessoas_e_EmpresasId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ContatosId");

                    b.HasIndex("Pessoas_e_EmpresasId");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.DadoBancario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Agencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Conta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DadosBancariosId")
                        .HasColumnType("int");

                    b.Property<string>("DigitoAgencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DigitoConta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Padrao")
                        .HasColumnType("bit");

                    b.Property<int?>("Pessoas_e_EmpresasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DadosBancariosId");

                    b.HasIndex("Pessoas_e_EmpresasId");

                    b.ToTable("DadoBancario");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descrição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DocumentosId")
                        .HasColumnType("int");

                    b.Property<int?>("Pessoas_e_EmpresasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocumentosId");

                    b.HasIndex("Pessoas_e_EmpresasId");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Endereco", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnderecosID")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Padrao")
                        .HasColumnType("bit");

                    b.Property<int?>("Pessoas_e_EmpresasId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EnderecosID");

                    b.HasIndex("Pessoas_e_EmpresasId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Historico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("HistoricoTEXTO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HistoricosId")
                        .HasColumnType("int");

                    b.Property<int?>("Pessoas_e_EmpresasId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_De_Historico")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoricosId");

                    b.HasIndex("Pessoas_e_EmpresasId");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Aniversario")
                        .HasColumnType("datetime2");

                    b.Property<string>("ApelidoNomeFantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPFCNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cliente")
                        .HasColumnType("bit");

                    b.Property<bool>("ClienteBloqueado")
                        .HasColumnType("bit");

                    b.Property<bool>("ConsumidorFinal")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataDeCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailParaNFE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmissorDoRG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fornecedor")
                        .HasColumnType("bit");

                    b.Property<bool>("Funcionario")
                        .HasColumnType("bit");

                    b.Property<int>("IndicadorDaIEDoDestinatario")
                        .HasColumnType("int");

                    b.Property<string>("InscricaoMunicipal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IssRetidoNaFonte")
                        .HasColumnType("bit");

                    b.Property<decimal>("LimiteDeCredito")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("NomeRazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NomeSocial")
                        .HasColumnType("bit");

                    b.Property<string>("NomeSocialTXT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PessoaFisica")
                        .HasColumnType("bit");

                    b.Property<bool>("PessoaJuridica")
                        .HasColumnType("bit");

                    b.Property<bool>("ProdutorRural")
                        .HasColumnType("bit");

                    b.Property<string>("RGInscricaoEstadual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Serasa")
                        .HasColumnType("bit");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UFDoEmissor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas_e_Empresas");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Banco", b =>
                {
                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Banco", "Bancos")
                        .WithMany()
                        .HasForeignKey("BancosId");

                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.DadoBancario", null)
                        .WithMany("Bancos")
                        .HasForeignKey("DadoBancarioId");

                    b.Navigation("Bancos");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Contato", b =>
                {
                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Contato", "Contatos")
                        .WithMany()
                        .HasForeignKey("ContatosId");

                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", null)
                        .WithMany("Contatos")
                        .HasForeignKey("Pessoas_e_EmpresasId");

                    b.Navigation("Contatos");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.DadoBancario", b =>
                {
                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.DadoBancario", "DadosBancarios")
                        .WithMany()
                        .HasForeignKey("DadosBancariosId");

                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", null)
                        .WithMany("DadosBancarios")
                        .HasForeignKey("Pessoas_e_EmpresasId");

                    b.Navigation("DadosBancarios");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Documento", b =>
                {
                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Documento", "Documentos")
                        .WithMany()
                        .HasForeignKey("DocumentosId");

                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", null)
                        .WithMany("Documentos")
                        .HasForeignKey("Pessoas_e_EmpresasId");

                    b.Navigation("Documentos");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Endereco", b =>
                {
                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Endereco", "Enderecos")
                        .WithMany()
                        .HasForeignKey("EnderecosID");

                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", null)
                        .WithMany("Enderecos")
                        .HasForeignKey("Pessoas_e_EmpresasId");

                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Historico", b =>
                {
                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Historico", "Historicos")
                        .WithMany()
                        .HasForeignKey("HistoricosId");

                    b.HasOne("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", null)
                        .WithMany("Historicos")
                        .HasForeignKey("Pessoas_e_EmpresasId");

                    b.Navigation("Historicos");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.DadoBancario", b =>
                {
                    b.Navigation("Bancos");
                });

            modelBuilder.Entity("ApollyonInc.Models.Pessoas_e_Empresas.Pessoas_e_Empresas", b =>
                {
                    b.Navigation("Contatos");

                    b.Navigation("DadosBancarios");

                    b.Navigation("Documentos");

                    b.Navigation("Enderecos");

                    b.Navigation("Historicos");
                });
#pragma warning restore 612, 618
        }
    }
}
