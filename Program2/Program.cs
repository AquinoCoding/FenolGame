using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game2
{

    class VilleProblem
    {
        static void Main(string[] args){
            
            problemVille();
        }

        static void problemVille()
        {

            Console.WriteLine($"PERSON em sua pequena vila a água não está chegando, gostaria de ajudar ? [SIM 1 / NÃO 2]");

            if( "1" == "1"){
                Console.WriteLine("Ajudou");
            }
            else{
                Console.WriteLine("Não ajudou");
            }
            

        }
    }

}