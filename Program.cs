using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua idade em meses: ");
            int meses= int.Parse(Console.ReadLine());

            Console.WriteLine("Qual suas idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int resultado = (anos*365)+(meses*30)+ dias;

            Console.WriteLine("A sua idade total em dias é: " + resultado);
            Console.ReadKey();
        }
    }
}
