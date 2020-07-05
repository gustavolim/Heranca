using ConsoleHeranca.Entidades;
using System;

namespace ConsoleHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaX contaX = new ContaX(222, "Ronaldo", 500, 900);

            Console.WriteLine(contaX.SaldoConta);
        }
    }
}
