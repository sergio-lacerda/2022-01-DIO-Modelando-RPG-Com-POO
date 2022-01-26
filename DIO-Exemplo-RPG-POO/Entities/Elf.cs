using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Exemplo_RPG_POO.Entities
{
    class Elf : Categoria
    {
        public Elf(string nome, int level, int hp, int poder)
        {            
            this.Nome = nome;
            this.Level = level;
            this.Hp = hp;
            this.Poder = poder;            
        }

        public override void atacar()
        {
            Console.WriteLine(this.Nome + " atacou com seu arco!");
        }

        public override string info()
        {
            return "Elf: " + this.Nome + $" - Level {this.Level}";
        }
    }
}
