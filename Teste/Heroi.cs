using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4
{
    public class Heroi
    {
        Random rand = new Random();
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Experiencia { get; set; }
        public int Nivel { get; set; }
        public int AtaqueBase { get; set; }
        public int Ataque { get; set; }

        public Heroi(string name)
        {
            this.Nome = name;
            this.Vida = 10;
            this.Experiencia = 0;
            this.Nivel = 1;
            this.AtaqueBase = rand.Next(1, 11);
            this.Ataque = AtaqueBase + Nivel;
        }

        public void MostrarHeroi()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("INFOS DO HERÓI");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Nome: [ {this.Nome} ]");
            Console.WriteLine($"Vida: [ {this.Vida} ]");
            Console.WriteLine($"Experiência: [ {this.Experiencia} ]");
            Console.WriteLine($"Nível: [ {this.Nivel} ]");
            Console.WriteLine($"Ataque: [ {this.AtaqueBase} ]");
        }
    }
}
