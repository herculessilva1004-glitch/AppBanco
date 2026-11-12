using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AppBanco.Models;


namespace AppBanco.Entities

{
    public class Movimento
    {
       public DateTime Data {get; set;}
       public Enumerados.TipoMovimento Tipo {get; set;}
       public string Descricao {get; set;}

       public double Valor {get; set;}
      
    
     public Movimento()
        {
            Data = DateTime.Now;
            Tipo = Enumerados.TipoMovimento.Credito;
            Descricao = "";
            Valor = 0; 

        }
        public override string ToString()
        {
            string retorno = "Data   :" + Data.ToString("dd/MM/yyyy") + "\n" +
                             "Tipo   :" + Tipo + "\n" +
                             "Descricao :" + Descricao + "\n" +
                             "Valor  :" + Valor.ToString("C") + "\n";


            return retorno;
        }
    }


}