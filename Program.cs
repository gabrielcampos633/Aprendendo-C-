using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            /* EXERCICIO 001 */
            // Console.Write("Type your name: ");
            // string name = Console.ReadLine();
            // Console.Write("Type your age: ");
            // string ageasString = Console.ReadLine();
            // int age = Convert.ToInt16(ageasString);
            // string message = "You age is: " + age + " and your name is: " + name;
            // Console.WriteLine(message);

            //  TODO: LOOPS EM C#: 
            // int counter = 0; 
            // counter -= 2;
            // Console.WriteLine(counter);



            //  EXERCICIO 002     
            // Console.WriteLine("Type a number: ");
            // int a = 3;
            // int b = 5;
            // int c = 10;

            // int average = (a + b + c) / 3;
            // Console.WriteLine("The average is: " + average);

            // // EXERCICIO 003
            // Console.WriteLine("Type a number: ");
            // int number = int.Parse(Console.ReadLine());

            // if (number % 2 == 0)
            // {
            //     Console.WriteLine("The number is even.");
            // }
            // else
            // {
            //     Console.WriteLine("The number is odd.");

            // EXERCICIO 004
            // Console.Write("Type a value of product in my store: "); # Pede ao usuario um valor de um produto 
            // double productValue = Convert.ToDouble(Console.ReadLine()); # Converte o valor de string para double (que seria um inteiro com casas decimais
            // double markup = 0.15; # Define a porcentagem do valor que será multiplicado (15% a mais do valor do produto)
            //     double afterValue =  productValue + (productValue * markup); # Calcula o valor do produto apos a multiplicação com a porcentagem de 15%
            //  Console.WriteLine("The value of product after the markup is: {0} ", afterValue); # Mostra o valor do produto apos a multiplicação com a porcentagem de 15%

            // // EXERCICIO 005
            // Console.Write("Buying Price: "); // Pede ao usuario um valor de compra de um produto
            // double buyingPrice = Convert.ToDouble(Console.ReadLine()); // Converte o valor de uma string do valor do produto para um double (um valor inteiro com casas decimais)
            // Console.Write("Profit Percentage: "); // Pede ao usuario um valor de porcentagem de lucro que ele deseja ter sobre o produto
            // double profitPercentage = Convert.ToDouble(Console.ReadLine()); // Converte o valor de uma string de porcentagem para um double (um valor inteiro com casas decimais)
            // double profit = buyingPrice * (profitPercentage / 100); // Calcula o lucro do produto multiplicando o valor de compra do produto pela porcentagem de lucro dividida por 100 (para transformar a porcentagem em decimal)
            // double sellingPrice = buyingPrice + profit; // Calcula o valor de venda do produto somando o valor de compra do produto com o lucro calculado anteriormente
            // Console.WriteLine($"Selling Price {sellingPrice}"); // Mostra o valor de venda do produto apos a soma do valor de compra com o lucro calculado anteriormente
            // Console.WriteLine($"Profit {profit}"); // Mostra o valor de porcentagem calculado anteriormente


            // /* EXERCICIO 006 */
            // Console.Write ("Name: ");
            // string name = Console.ReadLine();
            // Console.Write ("Salary: ");
            // double salary = Convert.ToDouble(Console.ReadLine());
            // Console.Write ("Years of experience: ");
            // int yearsOfExperience = Convert.ToInt32(Console.ReadLine());
            // Console.Write ("Kids: ");
            // int kids = Convert.ToInt32(Console.ReadLine());

            // double yearsIncrease = yearsOfExperience * 0.5;
            // double kidsIncrease = kids * 2;
            // double salaryIncreasePercentage = yearsIncrease + kidsIncrease;
            // double salaryIncrease = salary* (salaryIncreasePercentage / 100);
            // double newSalary = salary + salaryIncrease;     

            // Console.WriteLine($"New Salary: {newSalary}");
 
        // /* Exercício 007 */
        // Console.Write("Type a number 1: ");
        // int number1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Type a number 2: ");
        // int number2 = Convert.ToInt32(Console.ReadLine());

        // Console.WriteLine($"Number 1: {number1} Number 2: {number2}");
        // int auxiliary = number1;
        // number1 = number2;
        // number2 = auxiliary;
        // Console.WriteLine($"Number 1: {number1} Number 2: {number2}");

        /* Exercicio 008 */
        // Console.Write("Type a seconds: ");
        // int secondsInTime = Convert.ToInt32(Console.ReadLine()); 
        // int hours = secondsInTime / 3600; /* Divide o valor de segundos por 3600 para obter o valor em horas */
        // int secondsTime = secondsInTime % 3600; /* Calcula a divisão do valor de segundos por 3600 para obter o valor em segundos restantes após a divisão por 3600 */
        // int minutes = secondsTime / 60; /* Divide o valor de segundos restantes por 60 para obter o valor em minutos */
        // int seconds = secondsTime % 60; /* Calcula a divisão do valor de segundos restantes por 60 para obter o valor em segundos restantes após a divisão por 60 */
        // Console.WriteLine($"Hours: {hours} Minutes: {minutes} Seconds: {seconds}");

        // /*Exercicio 009 */
        // Console.Write("Number with 6 digits: ");
        // int fullNumber = Convert.ToInt32(Console.ReadLine());
        // int leftNumber = fullNumber / 1000; /* Divide o valor do número completo por 1000 para obter os 3 primeiros dígitos do número */
        // int rightNumber = fullNumber % 1000; /* Calcula a divisão do valor do número completo por 1000 para obter os 3 últimos dígitos do número */
        // Console.WriteLine($"Left Number: {leftNumber}, Right Number: {rightNumber}");

        // /* EXERCICIO 010 */
        // Console.Write("Number: ");
        // int number = Convert.ToInt32(Console.ReadLine());
        // int lastDigit = number % 10; /* Calcula a divisão do valor do número completo por 10 para obter o último dígito do número */
        // int lastDigit1 = (number % 100) / 10; /* Calcula a divisão do valor do número completo por 100 para obter o penúltimo dígito do número */
        // int lastDigit2 = (number % 1000) / 100; /* Calcula a divisão do valor do número completo por 100 para obter o penúltimo dígito do número */
        // int lastDigit3 = (number % 10000) / 1000; /* Calcula a divisão do valor do número completo por 1000 para obter o antepenúltimo dígito do número */
        // Console.WriteLine($"{lastDigit}, {lastDigit1}, {lastDigit2}, {lastDigit3}"); /* Mostra o último dígito do número, o penúltimo dígito do número, o antepenúltimo dígito do número e o quarto dígito do número */

        // /* LOGICAL EXPRESSIONS 001 */
        // bool isMarried = true;
        // int salary = 12000;
        // bool hasJob = true;
        // bool isManager = false;

        // Console.WriteLine($"Is married and is manager: {isMarried && isManager}"); /* Mostra se a pessoa é casada e é gerente (Mostra que é falso pq o and lógico só é verdadeiro se as duas condições forem verdadeiras) */
        // Console.WriteLine($"Salary is above 12000 and is manager: {salary >= 12000 && isMarried}");

        // //  LOGICAL EXPRESSIONS 002
        // int number1 = 3;
        // int number2 = 4;
        // int number3 = 5;
        // Console.WriteLine($"Math.Max({number1}, {number2}): {Math.Max(number1, number2)}"); /* O comando Math.Max retorna o maior valor entre dois 
        // Console.WriteLine($"Math.Min({number1}, {number2}): {Math.Min(number1, number2)}");  O comando Math.Min retorna o menor valor entre dois  (tambem pode usar valores inteiros, sem strings) 

        // Console.WriteLine($"Math.Max(): {Math.Max(Math.Max(number1, number2), number3)}"); /* O comando Math.Max retorna o maior valor entre tres */
        // Console.WriteLine($"Math.Min(): {Math.Min(Math.Min(number1, number2), number3)}"); /* O comando Math.Min retorna o menor valor entre tres */

        // Console.WriteLine($"2^4 = {Math.Pow(2, 4)}");
        // Console.WriteLine($"{number1} ^ {number2} = {Math.Pow(number1, number2)}"); 

// /* RAIZES QUADRADAS*/
//         Console.WriteLine($"Square Root from 81: {Math.Sqrt(81)}");
//         Console.WriteLine($"Square Root from 121: {Math.Sqrt(121)}");
//         Console.WriteLine($"Square Root from 541: {Math.Sqrt(541)}");

// /* MENOS USADOS (VER DOCUMENTAÇÃO QUANDO NECESSARIO) */
//         double value = 3.4745646;
//         Console.WriteLine($"Celling: {Math.Ceiling(value)}"); /* Pega o numero apos o ponto */
//         Console.WriteLine($"Floor: {Math.Floor(value)}"); /* Volta e pega o numero anterior */ 
//         Console.WriteLine($"Round: {Math.Round(value, 2)}"); /* Arredonda os numeros */
//         Console.WriteLine($"Truncate: {Math.Truncate(value)}"); /* Pega apenas os numeros da esquerda */
            
// /* IF, ELSE E SWITCH*/
//         Console.Write("Type a number 1: ");
//         int number1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Type a number 2: "); 
//         int number2 = Convert.ToInt32(Console.ReadLine());

//        if (number1 > number2) {Console.WriteLine("O numero 1 é maior que o numero 2");}
//        else if (number2 > number1) {Console.WriteLine("O numero 2 é maior que o numero 1");}


       /* QUESTÃO 002 - IF, ELSE && SWITCH */
        Console.Write("Type a number 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Type a number 2: "); 
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 == number2) {
            Console.WriteLine("Numbers are equal");
            }

        else if (number1 > number2)
            {
                Console.WriteLine("The number 1 is highest than 2 ");
            }

        else {
            Console.WriteLine("The number 2 is highest than number 1 ");
        }












































        }
             }
    }

 
