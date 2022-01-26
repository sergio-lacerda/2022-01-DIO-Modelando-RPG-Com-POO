using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Exemplo_RPG_POO.Entities
{
    class Knight : Categoria
    {
        public Knight(string nome, int level, int hp, int poder)
        {
            this.Nome = nome;
            this.Level = level;
            this.Hp = hp;
            this.Poder = poder;
        }

        public override void atacar()
        {
            Console.WriteLine(this.Nome + " atacou com sua espada!");
        }

        public override string info()
        {
            return "Knight: " + this.Nome + $" - Level {this.Level}";
        }
    }
}
