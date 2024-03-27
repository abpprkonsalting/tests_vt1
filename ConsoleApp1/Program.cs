using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsVT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args.Length > 1)
            {
                Console.Write("Uso del programa: test_vt <# del test>\n");
                Console.Write("Donde # del test puede ser:\n");
                Console.Write("\t1- Ordenación alfabética de frase \n");
                Console.Write("\t2- Cálculo de salario \n");
                return;
            }
            try
            {
                switch(args[0])
                {
                    case "1":
                        Console.Write("Entre la frase a ordenar alfabeticamente:");
                        var phrase = Console.ReadLine();
                        var orderer = new OrderAlphabetically(phrase);
                        break;
                    case "2":
                        break;
                    default:
                        throw new Exception("Valor de entrada incorrecto");
                }

            }
            catch (Exception e)
            {
                Console.Write("Exception: ");
                Console.Write(e.Message + "\n");
                
            }
            finally{
                Console.Write("Oprima enter para terminar.\n");
                Console.ReadLine();
            }

        }
    }
}
