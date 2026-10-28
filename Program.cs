using System;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Jogador desafiante: ");
        // Console.WriteLine("Number: (1-9) ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine("Jogador desafiado ");
        // Console.WriteLine("Number: (1-9): ");
        // int valor = Convert.ToInt32(Console.ReadLine());

        // while (valor != number) 
        // {
        //     Console.WriteLine("Você errou o número certo");
        //     Console.WriteLine("Number: (1-9): ");
        //     valor = Convert.ToInt32(Console.ReadLine());

        // }
        // Console.WriteLine("Parabéns, você acertou o número certo!");


        Console.Write("Informe um número: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <11; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }




    }
}
