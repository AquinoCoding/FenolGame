using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game
{
    class Program
    {
        struct Personagem
        {
            public string nome;
            public string sexo;
            public string tipo;
            public string cep;
            public string numCell;

        }
        static List<Personagem> personagens = new List<Personagem>();
        static void Main(string[] args)
        {
            Console.WriteLine("Play to Game\n");
            Console.WriteLine("Bem Vindo a Silion Valley\n");
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {

            Console.WriteLine("--------Menu Principal--------\n");

            Console.WriteLine("---> New Game [1]\n---> Load Game[2]\n");

            if (Option() == "1"){
                MenuPersonagem();
            }else
            {
                Console.WriteLine("Loandig...");
            }

        }
        static void MenuPersonagem()
        {

            Personagem personagem = new Personagem();

            Console.WriteLine("-----------Nome----------");
            personagem.nome = Console.ReadLine();

            // Escolha do Sexo do Personagem 
            Console.WriteLine("-----------Tipo----------\nMasculino[1]  Feminino[2]");

            if (Option() == "1"){
                personagem.sexo = "Masculino";
            }else {
                personagem.sexo = "Feminino";
            }

            Console.WriteLine("-----------Tipo----------\nGuerreiro[1]  Mago[2]");

            if (Option() == "1"){
                personagem.tipo = "Guerreiro";
            }else {
                personagem.tipo = "Mago";
            }

            personagens.Add(personagem);

            Console.WriteLine($"{personagem.nome} {personagem.sexo} {personagem.tipo}");
        }

        static string Option()
        {
            string option = Console.ReadLine();
            return option;
        }
    }
}
