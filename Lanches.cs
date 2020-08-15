using System;
using System.Globalization;

namespace Desktop
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double valor, valorFinal;

            System.Console.WriteLine("Digite o código do item: ");
            codigo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a quantidade desejada: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1){
                System.Console.WriteLine("Você escolheu " + quantidade + " Cahorro(s) Quente(s)");
                valor = 4;
            }
            else if (codigo == 2){
                System.Console.WriteLine("Você escolheu " + quantidade + " X-Salada(s)");
                valor = 4.5;
            }
            else if (codigo == 3){
                System.Console.WriteLine("Você escolheu " + quantidade + " X-Bacon(s)");
                valor = 5;
            }
            else if (codigo == 4){
                System.Console.WriteLine("Você escolheu " + quantidade + " Torrada(s) Simple(s)");
                valor = 2; 
            }
            else if (codigo == 5){
                System.Console.WriteLine("Você escolheu " + quantidade + " Refrigerante(s)");
                valor = 1.5;
            }
            else{
                System.Console.WriteLine("Opção não encontrada!");
                return;
            }
            valorFinal = valor * quantidade;

            System.Console.WriteLine("O total a ser pago é de R$" + valorFinal);
        }
    }
}
