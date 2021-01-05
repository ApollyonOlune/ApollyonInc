using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApollyonInc.Models.Pessoas_e_Empresas.Enums
{
    public enum Estado : int
    {
        [Display(Name = "Acre")]
        AC =0,
        [Display(Name = "Alagoas")]
        AL =1,
        [Display(Name = "Amapá")]
        AP=2,
        [Display(Name = "Amazonas")]
        AM =3,
        [Display(Name = "Bahia")]
        BA =4,
        [Display(Name = "Ceará")]
        CE=5,
        [Display(Name = "Espírito Santo")]
        ES=6,
        [Display(Name = "Goiás")]
        GO=7,
        [Display(Name = "Maranhão")]
        MA=8,
        [Display(Name = "Mato Grosso")]
        MT=9,
        [Display(Name = "Mato Grosso do Sul")]
        MS=10,
        [Display(Name = "Minas Gerais")]
        MG=11,
        [Display(Name = "Pará")]
        PA=12,
        [Display(Name = "Paraíba")]
        PB=13,
        [Display(Name = "Paraná")]
        PR=14,
        [Display(Name = "Pernambuco")]
        PE=15,
        [Display(Name = "Piauí")]
        PI=16,
        [Display(Name = "Rio de Janeiro")]
        RJ=17,
        [Display(Name = "Rio Grande do Norte")]
        RN=18,
        [Display(Name = "Rio Grande do Sul")]
        RS=19,
        [Display(Name = "Rondônia")]
        RO=20,
        [Display(Name = "Roraima")]
        RR=21,
        [Display(Name = "Santa Catarina")]
        SC=22,
        [Display(Name = "São Paulo")]
        SP=23,
        [Display(Name = "Sergipe")]
        SE=24,
        [Display(Name = "Tocantins")]
        TO=25
    }
}
