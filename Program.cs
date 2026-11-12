using AppBanco.Entities;

namespace AppBanco.Models
{
    public class Program

    {
       static void Main(string[] args)
        {
           Movimento Mov = new Movimento();
           Mov.Data = DateTime.Now;
           Mov.Tipo = Enumerados.TipoMovimento.Credito;
           Mov.Descricao = "Depósito em dinheiro";
           Mov.Valor = 1000.00;

           Console.WriteLine(Mov.ToString());
           Console.ReadKey();


           //Correntista Corr = new Correntista();
           //Corr.Nome = "Hercules";
           //Corr.CPF = "123.456.789-00";
           //Corr.Endereco = "Rua A";
           //Corr.Numero = 123;
           //Corr.Estado = "SP";
           //Corr.Cidade = "São Paulo";
           //Corr.Telefone = "(11) 98765-4321";

           //Console.WriteLine(Corr.ToString());
           //Console.ReadKey();
        }
    }
}
