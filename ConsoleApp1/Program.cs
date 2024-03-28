using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                        inputSalaryCalculatorPropertyValue(salaryCalculator,
                                "Entre hora de inicio del trabajo (notación 24h): ", "StartTime");
                        inputSalaryCalculatorPropertyValue(salaryCalculator,
                                "Entre hora de salida del trabajo (notación 24h): ", "EndTime");
                        inputSalaryCalculatorPropertyValue(salaryCalculator,
                                "Entre tasa horaria del trabajo ($/h): ", "HourRate");
                        inputSalaryCalculatorPropertyValue(salaryCalculator,
                                "Entre factor para horas extras del trabajo (n): ", "ExtraHourFactor");
                        Console.Write("El salario total del día es: ");
                        Console.Write("$" + salaryCalculator.calculateSalary() + "\n");
                        Console.Write("Horas normales trabajadas: ");
                        Console.Write(salaryCalculator.worked + "\n");
                        Console.Write("Horas extras trabajadas: ");
                        Console.Write(salaryCalculator.extra);
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


        static void inputSalaryCalculatorPropertyValue(SalaryCalculator calculator, string message, string propertyName)
        {
            bool pass;
            do
            {
                try
                {
                    pass = true;
                    Console.Write(message);
                    var value = Console.ReadLine();
                    var type = calculator.GetType();
                    var propInfo = type.GetProperty(propertyName);
                    if (propInfo != null)
                    {
                        propInfo.SetValue(calculator, value);
                    }
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
