namespace AppBanco.Entities

{
    public class Correntista
    {
        public string Nome {get; set;}

        public string CPF {get; set;}
        public string Endereco {get; set;}
        public int Numero {get; set;}
        public string Estado {get;set;}
        public string Cidade {get; set;}
        public string Telefone {get; set;}
        
        public Correntista()
        {
            CPF = "";
            Nome = "";
            Endereco = "";
            Numero = 0;
            Estado = "";
            Cidade = "";
            Telefone = "";
        }

    }
}

