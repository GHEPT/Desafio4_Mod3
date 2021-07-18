using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula4
{
    public class Jogo
    {
        Heroi heroi;
        public void Iniciar()
        {
            Console.WriteLine();
            Console.Write("Digite o nome do Herói: ");
            heroi = new(Console.ReadLine().ToUpper());
            heroi.MostrarHeroi();
            Menu();

        }

        public void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("ESCOLHA CONTRA QUEM BATALHAR");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("[ 1 ] ORC");
            Console.WriteLine("[ 2 ] TROLL");
            Console.WriteLine("[ 3 ] GOBLIN");
            Console.WriteLine();
            switch(Console.ReadLine().ToLower())
            {
                case "1":
                case "orc":
                    heroi.MostrarHeroi();
                    Batalhar(new Monstro("ORC", heroi.Nivel * 2, heroi.Nivel));
                    break;
                case "2":
                case "troll":
                    heroi.MostrarHeroi();
                    Batalhar(new Monstro("TROLL", heroi.Nivel * 5, heroi.Nivel * 2));
                    break;
                case "3":
                case "goblin":
                    heroi.MostrarHeroi();
                    Batalhar(new Monstro("GOBLIN", heroi.Nivel * 10, heroi.Nivel * 4));
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Menu();
                    break;
            }

        }

        public void Batalhar(Monstro monstro)
        {
            monstro.MostrarMonstro();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("BATALHAR OU FUGIR?");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("[ 1 ] BATALHAR");
            Console.WriteLine("[ 2 ] FUGIR");
            Console.WriteLine();
            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "batalhar":
                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("RESULTADO DO CONFRONTO");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"O Herói causou um dano de [ {heroi.AtaqueBase} ] e sofreu dano de [ {monstro.Ataque} ].");
                    heroi.Vida -= monstro.Ataque;
                    monstro.Vida -= heroi.AtaqueBase;
                    if (heroi.Vida > 0)
                    {
                        if (monstro.Vida < 1)
                        {
                            Console.WriteLine($"O Herói derrotou o monstro {monstro.Nome} e ganhou [ {monstro.Experiencia} ] de experiência.");
                            //heroi.Experiencia += monstro.Experiencia;
                            heroi.Nivel = (heroi.Experiencia + monstro.Experiencia) / 10;
                            if ((heroi.Experiencia + monstro.Experiencia) / 10 > heroi.Experiencia / 10)
                            {
                                heroi.Vida = heroi.Nivel * 10;
                                heroi.AtaqueBase = heroi.Ataque;
                                Console.WriteLine($"O heroi avançou para o nível {heroi.Nivel}.");
                                heroi.MostrarHeroi();
                                Menu();
                            }
                            Menu();
                            
                        }
                        if (monstro.Vida > 0)
                        {
                            heroi.MostrarHeroi();
                            Batalhar(monstro);

                        }
                    }
                    else
                    {
                        Console.WriteLine($"O Herói foi derrotado pelo monstro {monstro.Nome}.");
                        Console.WriteLine("--- FIM DE JOGO ---");
                        return;
                    }
                    break;

                case "2":
                case "fugir":
                    Console.WriteLine("O Herói fugiu???... que covarde!");
                    Menu();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("Aperte qualquer tecla para escolher novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    return;

            }                        
        }     
    }    
}
