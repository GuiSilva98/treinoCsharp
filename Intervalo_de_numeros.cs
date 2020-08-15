using System;
using System.Globalization;

namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            System.Console.WriteLine("Insira um número: ");
            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero >= 0.0 && numero <= 25.0){
                System.Console.WriteLine("O número "+ numero +" fica no intervalo entre 0 e 25");
            }
            else if (numero > 25.0 && numero <= 50.0){
                System.Console.WriteLine("O número "+ numero +" fica no intervalo entre 25 e 50");
            }
            else if (numero > 50.0 && numero <= 75.0){
                System.Console.WriteLine("O número "+ numero +" fica no intervalo entre 50 e 75");
            }
            else if (numero > 75.0 && numero <= 100.0){
                System.Console.WriteLine("O número "+ numero +" fica no intervalo entre 75 e 100");
            }
            else {
                System.Console.WriteLine("Fora do Intervalo!");
            }
        }
    }
}
