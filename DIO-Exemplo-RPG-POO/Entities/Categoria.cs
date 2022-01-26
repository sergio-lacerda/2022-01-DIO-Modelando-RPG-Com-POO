using System;
using System.Collections.Generic;
using System.Text;

namespace DIO_Exemplo_RPG_POO.Entities
{
    class Categoria : ICategoria
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public int Hp { get; set; }
        public int Poder { get; set; }

        

        public virtual void atacar()
        {
            Console.WriteLine(this.Nome + " atacou!");
        }

        public virtual string info()
        {
            return this.Nome + $" - Level {this.Level}";
        }
    }
}
