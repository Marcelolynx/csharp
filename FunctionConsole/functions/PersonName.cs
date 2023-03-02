namespace FunctionConsole.functions;

public class PersonName
{
   
   public string PrimeiroNome { get; private set; }
   public string SegundoNome { get; private set; }

   public string NomeCompleto(string PrimeiroNome, string SegundoNome)
   {
      var nomeCompleto = PrimeiroNome + SegundoNome;

      return nomeCompleto;
   }
}

