using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Exemplo_RPG_POO.Entities
{
    class Wizard : Categoria
    {
        public Wizard(string nome, int level, int hp, int poder)
        {
            this.Nome = nome;
            this.Level = level;
            this.Hp = hp;
            this.Poder = poder;
        }

        public override void atacar()
        {
            Console.WriteLine(this.Nome + " atacou com sua magia!");
        }

        public override string info()
        {
            return "Wizard: " + this.Nome + $" - Level {this.Level}";
        }
    }
}
