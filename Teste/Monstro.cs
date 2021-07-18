using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4
{
    public class Monstro
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Experiencia { get; set; }
        public int Ataque { get; set; }

        public Monstro(string nome, int vida, int ataque)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Experiencia =  vida + ataque;
            this.Ataque = ataque;
        }

        public void MostrarMonstro()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("INFOS DO MONSTRO");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Nome: [ {this.Nome} ]");
            Console.WriteLine($"Vida: [ {this.Vida} ]");
            Console.WriteLine($"Experiência: [ {this.Experiencia} ]");
            Console.WriteLine($"Ataque: [ {this.Ataque} ]");
        }
    }
}
