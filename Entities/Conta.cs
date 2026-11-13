using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBanco.Models;

namespace AppBanco.Entities
{
    public class Conta
    {
        public Enumerados.TipoConta Tipo {get; set;}
        public Correntista Correntista {get; set;}
        public string Numero {get; set;}
        public double Saldo {get; set;}

    }
}