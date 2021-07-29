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
        }

        static List<Personagem> personagens = new List<Personagem>();
        static Random lucky = new Random();
        static bool conditionInitial = true;
        static int NumFase = 0;

        static void Main(string[] args){

            Console.WriteLine("Play to Game\n");
            Console.WriteLine("Bem Vindo a Silicon Valley\n");

            AuthenticLevelUp();
            MenuPrincipal();
            AuthenticLevelUp();
        }

        static bool AuthenticLevelUp(){
            

            if (conditionInitial){

                conditionInitial = false;
                
                LevelUp();
            }
            else{

                LevelUp();
            }
            
            return conditionInitial; 
        }

        static int LevelUp(){

            NumFase = NumFase + 1;
            Console.WriteLine($"Seu nivel: {NumFase}");
            
            return NumFase;

        }

        static void MenuPrincipal(){

            Console.WriteLine("--------Menu Principal--------\n");

            Console.WriteLine("---> New Game [1]\n---> Load Game[2]\n");

            if (Option() == "1"){
                MenuPersonagem();
            }else{
                Console.WriteLine("Loandig...");
            }

        }

        static void MenuPersonagem(){

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

            Console.WriteLine($"\n{personagem.nome} {personagem.sexo} {personagem.tipo} {Lucky()}");
        }

        static string Option(){
            string option = Console.ReadLine();
            return option;
        }
        
        // Teste de Bonus, Só receberá a oportunidade de Bonus em fases de numero PAR
        static string Lucky(){

            // Condição para saber se a fase é PAR
            int Fase = 1;
            if (Fase % 2 == 0 || Fase == 1){

                // Teste de Sorte

                int dadosLucky = lucky.Next(10, 20);

                //Console.WriteLine(dadosLucky);

                if (dadosLucky > 10 || Fase == 1){

                    Console.WriteLine("-----------BÔNUS----------\n");

                    int dadosLuckyPremio = lucky.Next(1, 3);
                    //Console.WriteLine(dadosLuckyPremio);

                    if (dadosLuckyPremio == 1){
                        string itemBonus = "Espada";
                        Console.WriteLine($"A Coruja trouxe uma {itemBonus}");
                        return "Espada";
                    }
                    else if (dadosLuckyPremio == 2){
                        string itemBonus = "Escudo";
                        Console.WriteLine($"A Coruja trouxe um {itemBonus}");
                        return "Escudo";
                    }
                    else if (dadosLuckyPremio == 3){
                        string itemBonus = "Moedas de ouro";
                        int dadosLuckyMoedas = lucky.Next(1, 200);

                        Console.WriteLine($"A Coruja trouxe $${dadosLuckyMoedas} {itemBonus}");
                        return "Moedas de ouro";
                    }

                }else{
                    
                    return "A coruja extraviou sua entrega";

                }
                
            }

            return "";
        }

    }
}
