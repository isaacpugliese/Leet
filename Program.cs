using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {                                                     
          string Frase;    
          Console.WriteLine("Qual a frase a ser traduzida?");
          Frase = Console.ReadLine()         
         .ToUpper()
         .Replace("A", "4")
         .Replace("T", "7")
         .Replace("O", "0")
         .Replace("S", "5")
         .Replace("I", "1")
         .Replace("L", "1");              
         Console.WriteLine("Sua frase em LEET fica:");
         Console.WriteLine(Frase);              
        }
    }
}
