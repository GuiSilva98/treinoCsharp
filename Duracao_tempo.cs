using System;
using System.Globalization;

namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicio, horaFim, duracao;

            System.Console.WriteLine("Digite a Hora de início (0h até 23h): ");
            horaInicio = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Hora final (0h até 23h): ");
            horaFim = int.Parse(Console.ReadLine());

            if (horaInicio > horaFim){
                int resultado =  24 - horaInicio;
                duracao = resultado + horaFim;

                System.Console.WriteLine("Teve a duração de " + duracao + " horas");
            }
            else if(horaInicio == horaFim){
                System.Console.WriteLine("Teve a duração de 24 horas");
            }
            else{
                duracao = horaFim - horaInicio;
                System.Console.WriteLine("Teve a duração de " + duracao + " horas");
            }
        }
    }
}
