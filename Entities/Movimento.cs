namespace AppBanco.Entities

{
    public class Movimento
    {
       public DateTime Data {get; set;}
       public string Descricao {get; set;}

       public double Valor {get; set;}
      

     public Movimento()
        {
            Data = DateTime.Now;
            Descricao = "";
            Valor = 0; 

        }
    }


}