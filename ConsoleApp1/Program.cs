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
                        Console.Write("La frase original es: " + phrase + "\n");
                        Console.Write("La frase ordenada es: " + orderer.sortAlphabetically() + "\n");
                        break;
                    case "2":
                        var salaryCalculator = new SalaryCalculator();
                        inputSalaryCalculatorData(salaryCalculator);
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

        static void inputSalaryCalculatorData(SalaryCalculator calculator)
        {
            var pass = true;
            do
            {
                try
                {
                    Console.Write("Entre hora de inicio del trabajo (notación 24h): ");
                    calculator.StartTime = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Write("Exception: ");
                    Console.Write(ex.Message + "\n");
                    pass = false;
                }

            } while (!pass);
            do
            {
                pass = true;
                try
                {
                    Console.Write("Entre hora de salida del trabajo (notación 24h): ");
                    calculator.EndTime = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Write("Exception: ");
                    Console.Write(ex.Message + "\n");
                    pass = false;
                }

            } while (!pass);
            do
            {
                pass = true;
                try
                {
                    Console.Write("Entre tasa horaria del trabajo ($/h): ");
                    calculator.HourRate = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Write("Exception: ");
                    Console.Write(ex.Message + "\n");
                    pass = false;
                }

            } while (!pass);
            do
            {
                pass = true;
                try
                {
                    Console.Write("Entre factor para horas extras del trabajo (n): ");
                    calculator.ExtraHourFactor = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.Write("Exception: ");
                    Console.Write(ex.Message + "\n");
                    pass = false;
                }

            } while (!pass);
        }
    }
}
