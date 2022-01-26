using DIO_Exemplo_RPG_POO.Entities;
using System;

namespace DIO_Exemplo_RPG_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Elf orelhudo = new Elf("Orelhudo", 1, 50, 50);
            Knight semCavalo = new Knight("Sem cavalo", 1, 50, 50);
            Wizard varinhaQuebrada = new Wizard("Varinha quebrada", 1, 50, 50);

            Console.WriteLine("====== Personagens no jogo ======");
            Console.WriteLine(orelhudo.info());
            Console.WriteLine(semCavalo.info());
            Console.WriteLine(varinhaQuebrada.info());
            Console.WriteLine("=================================");
            Console.WriteLine("");
            orelhudo.atacar();
            semCavalo.atacar();
            varinhaQuebrada.atacar();

            Console.ReadKey();
        }
    }
}
