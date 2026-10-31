using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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


    //    /* QUESTÃO 002 - IF, ELSE && SWITCH */
    //     Console.Write("Type a number 1: ");
    //     int number1 = Convert.ToInt32(Console.ReadLine());
    //     Console.Write("Type a number 2: "); 
    //     int number2 = Convert.ToInt32(Console.ReadLine());

    //     if (number1 == number2) {
    //         Console.WriteLine("Numbers are equal");
    //         }

    //     else if (number1 > number2)
    //         {
    //             Console.WriteLine("The number 1 is highest than 2 ");
    //         }

    //     else {
    //         Console.WriteLine("The number 2 is highest than number 1 ");
    //     }

    /* QUESTAO 003 - IF, ELSE, IF ELSE*/

    // Console.Write("Type a number 1: "); 
    // int number1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Type a number 2: "); 
    // int number2 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Type a number 3: "); 
    // int number3 = Convert.ToInt32(Console.ReadLine());

    // if (number1 > number2 && number1 > number3) {Console.WriteLine("The number one is highest than other numbers")
    // ;}

    // else if (number2 > number1 && number2 > number3)
    //         {
    //             Console.WriteLine("The number two is highest than others numbers");
    //         }

    // else
    //         {
    //             Console.WriteLine("The third number is highest than others");
    //         }

     /* QUESTAO 004 */
 
    // Console.Write("Number: ");
    // int number = Convert.ToInt32(Console.ReadLine());
    // if (number > 0) {Console.WriteLine($"{number} is bigger than 0");}
    // else  if (number <0) {Console.WriteLine($"{number} é menor que 0");}
    // else if (number == 0) {Console.WriteLine($"The number is 0");}

    // // // QUESTAO 005 */

    // Console.Write("Age: ");
    // int age = Convert.ToInt32(Console.ReadLine());
    // if (age <18) {Console.WriteLine("Minor");}
    // else
    // {
    //     Console.WriteLine("A idade é maior que 18");
    // }

    // if (age >=18) {Console.WriteLine("É de maior");}
    // else {Console.WriteLine("É de menor");}
    
    // /* QUESTAO 006 */

    //  Console.Write("Number: ");    
    //  int number = Convert.ToInt32(Console.ReadLine());

    //  if (number % 2 == 0) {Console.WriteLine("O numero é par");}
    //  else {Console.WriteLine("O numero eh impar");}   

    // /* QUESTAO 007 */

    // Console.Write("Number 1: "); 
    // int number1 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Number 2: "); 
    // int number2 = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Operation: ");
    // string operation = Console.ReadLine();

    // double result = 0;

    // if (operation == "+") {result = number1 + number2;}
    // else if (operation == "-") {result = number1 - number2;}
    // else if (operation == "*") {result = number1 * number2;}
    // else if (operation == "/") {result = number1 / (double) number2;} 
    // // POSSIVEIS OPERACOES INVALIDAS + DIVISAO POR ZERO
    
    // Console.WriteLine($"{number1} {operation} {number2} = {result}");

    /* QUESTAO 008 */

    // Console.Write("Hour: ");
    // int hour = Convert.ToInt32(Console.ReadLine());
    // if (hour <0 || hour >23)
    //         {
    //             Console.WriteLine("Invalid Hour");
    //         }
    //         else {
    //         string salutation;
    // if (hour <12)
    //         {
    //             salutation = "Morning";
    //         }
    //         else if (hour <16)
    //         {
    //             salutation = "Afternoon";
    //         }
    //         else if (hour <18)
    //         {
    //             salutation = "Evening";
    //         }
    //         else
    //         {
    //             salutation = "Night";
    //         } 
    //         Console.WriteLine($"Good {salutation}");
    // }

    /* QUESTAO 009 */

    // Console.Write("Letter: "); 
    // string letter = Console.ReadLine();

    // string letterLower = letter.ToLower();
    // if (letterLower == "a" || letterLower == "e" || letterLower == "i" || letterLower == "o" || letterLower == "u")
    //         {
    //             Console.WriteLine($"The vowel is {letter}");
    //         }
    //         else
    //         {
    //             Console.WriteLine($"Consonant: {letter}");
    //         }
     
    //  /* QUESTAO 010 */
    // Console.Write("Age: "); 
    // double age = Convert.ToDouble(Console.ReadLine());

    // if (age == 0)
    //         {
    //             Console.WriteLine("Unborn");
    //         }
    //             else if (age <=1)
    //         {
    //             Console.WriteLine("Infant");
    //         }
    //                 else if (age <=12)
    //         {
    //             Console.WriteLine("Child");
    //         }
    //                     else if ( age <=17)
    //         {
    //             Console.WriteLine("Adolescent");
    //         }
    //                         else if (age <=55)
    //         {
    //             Console.WriteLine("Adult"); 
    //         }
    //                             else if (age <=75)
    //         {
    //             Console.WriteLine("Senior"); 
    //         }
    //                                 else
    //         {
    //             Console.WriteLine("Elderly");
    //         }
            


// /* QUESTAO 011 */ 
// Divisão por numeros de anos e anos bissextos, achei não tão util pois tem um comando no c# para isso

// Console.Write("Name: ");
// string name = Console.ReadLine(); 
// Console.Write("Height: " );
// double height = Convert.ToDouble(Console.ReadLine());
// Console.Write("Gender: ");
// string gender = Console.ReadLine();

// gender = gender.ToUpper();

// double pesoideal = 0;
// if (gender != "Male" && gender != "Female") {Console.WriteLine("I dont have a formula for this gender");}
//     else
//             {
//                 if (gender == "Male") 
//                 {pesoideal = (72.7 * height) - 58;}
//             }
//                 if (gender == "Female") 
//             {
//                 pesoideal = (62.1 * height) - 44.7;
//             }
//             Console.WriteLine($"The height is {pesoideal} in kilograms");




// //   QUESTAO 012 
// Console.Write("Size A: "); 
// double a = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Size B: ");
// double b = Convert.ToDouble(Console.ReadLine());
// Console.Write("Size C: ");
// double c = Convert.ToDouble(Console.ReadLine());

// if (a == b && a == c && b == c)
//             {
//                 Console.WriteLine("Equilateral");
//             }
//             else if (
//                 a != b && a != c && b != c
//             )
//             {
//                 Console.WriteLine("Scalene");
//             }
//             else
//             {
//                 Console.WriteLine("Isosceles"); 
//             }

// //   QUESTAO 013
// Console.Write("Name: "); 
// string name = Console.ReadLine();
// Console.Write("Salary: "); 
// double salary = Convert.ToDouble(Console.ReadLine());

// double percentual = 0;
// if (salary <=50000)
//             {
//                 percentual = 20;
//             }
//             else if (salary <=100000)
//             {
//                 percentual = 15;
//             }
//             else if (salary <150000)
//             {
//                 percentual = 10; 
//             }
//             else
//             {
//                 percentual = 5;
//             }

// double newSalary = salary + salary * ( percentual / 100.00);

// Console.WriteLine($"Name: {name}; Salary: {newSalary}; Increase: {percentual}");

// FOR && WHILE - SINTAXES BÁSICAS E INDO AO EXERCICIOS: 
// int number = -1; 
// while (number != 0)
//             {
//                 Console.Write("Number: "); 
//                 number = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine($"Number {number}");
//             }

// // Break and continue 

//     for (int v = 0; v <= 9; v++)
//     {
//         if (v == 5)
//         {
//             break;
//         } Console.Write($"{v}, ");
//     }

// QUESTAO 001 - LOOPS DE REPETIÇÃO // Contando os números de 1 a 1000 (Podendo fazer outras modificações nesse mesmo código.)

// const int MIN = 1; // Aqui define o inicio de toda a repetição, começando em 1; 
// const int MAX = 1000; // Aqui define uma quantidade certa de numeros que serão mostrados nos dois exemplos de for e while

// for (int i = MIN; i <=MAX; i++)
//             {
//                 Console.Write($"{i}, ");
//             }

// int v = MIN; 
// while (v <=MAX)
//             {
//                 Console.Write($"{v}, ");
//                 v++;
//             }

// OBSERVAÇÃO: Constantes são variáveis que não mudam, mas podem ser alteradas, alterando todo o codigo, ela vem antes da predefinição (Int, double, string)

// // QUESTAO 002 - LOOPS DE REPETIÇÃO 
// Console.Write("Minimum: "); 
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Maximum: "); 
// int max = Convert.ToInt32(Console.ReadLine()); 

// if (min > max)
//             {
//                 int aux = min;
//                 min = max; 
//                 max = aux; 
//             }
//             for (int i = min; i <=max; i++)
//             {
//                 Console.WriteLine($"{i}, ");
//             }

// Como sempre tive dificuldades em exercicios de loops, por isso tenho que estudar mais sem parar sobre esse assunto.

// // QUESTAO 003 - LOOPS DE REPETIÇÃO 
// Console.Write("Minimum: "); 
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Maximum: "); 
// int max = Convert.ToInt32(Console.ReadLine()); 

// for (int i = min; i <= max; i++)
//             {
//                 if (i % 2 == 0)
//                 {
//                     Console.Write($"{i}, ");
//                 }
//             }

// QUESTAO 004 - LOOPS DE REPETIÇÃO (Novamente tive dificuldade nesse assunto, tanto que nem consegui resolver a questão, preciso praticar mais.)

// string numberAsString; 
// int number; 
// int highest = int.MinValue;
// bool numberEntered = false;

// do
//             { Console.Write("Number: ");
//                 numberAsString = Console.ReadLine(); 
//                 if (numberAsString != string.Empty ) // String.Empty = "" ou valor Nulo.
//                 { numberEntered = true;
//                     number = Convert.ToInt32(numberAsString);
//                     if (number > highest)
//                     {
//                         highest = number; 
//                     }
//                 }
//             } while (numberAsString != string.Empty);
//             if (!numberEntered)
//             {
//                 Console.WriteLine("No numbers entered");
//             }
//             else
//             {
//                 Console.WriteLine($"The highest number is {highest}");
//             }

// QUESTAO 005 - LOOPS DE REPETIÇÃO
// string numberString;
// int number = 0;
// int? highest1 = null;
// int? highest2 = null;

// do
//             {
//                 Console.Write("Number: ");
//                 numberString = Console.ReadLine();
//                 if (numberString != string.Empty)
//                 {
//                     number = Convert.ToInt32(numberString);
//                 } if (highest1.HasValue == false)
//                 { highest1 = number;} 
//                 else if (number > highest1) 
//                 {
//                     highest2 = highest1; 
//                     highest1 = number;
//                 } else if ((highest2.HasValue == false) || (number > highest2)) { 
//                     highest2 = number;
//                 }
//                 {
//                     highest2 = number;
//                 }
//                 }

//             while (numberString !="");

//             if (highest1.HasValue)
//             {
//                 Console.WriteLine($"The number of highest 1 is {highest1}");
//             }
//                 if (highest2.HasValue)
//             {
//                 Console.WriteLine($"The number of highest 2 is {highest2}");
//             }

// QUESTAO 006

// string numberString;
// int number;
// int? lowest = null;
// int lowestFrequency = 0;

// do
//             { 
//                 Console.Write("Number: ");
//                 numberString = Console.ReadLine();
//                 if (numberString != string.Empty) 
//                 number = Convert.ToInt32(numberString);
//                 if (!lowest.HasValue || number < lowest)
//                 {
//                     lowest = number;
//                     lowestFrequency = 1;
                    
//                 } else if (number == lowest)
//                 {
//                     lowestFrequency++;
// //                 }
// //             } while (
// //                     numberString != string.Empty
// //             );
// // if (lowest.HasValue) {
//  Console.WriteLine($"Lowest: {lowest}, Lowest Frequency: {lowestFrequency}");}

// // // QUESTAO 007

// // int term1 = 0; 
// // int term2 = 1; 
// // Console.Write($"{term1}");

// // int newTerm = term1 + term2; 
// // while (newTerm <5000)
// //             {
// //                 Console.Write($"{newTerm}, ");
// //                 newTerm = term1 + term2;
// //                 term1 = term2; 
// //                 term2 = newTerm;
//             }

// QUESTAO 008 

// for (int i = 0; i <9; i++)
//             {
//                 for (int j = 0; j <9; j++) {
//                 Console.WriteLine($"{i} x {j} = {i * j}");
//                 }
//                 }

// QUESTAO 009 - LOOPS DE REPETIÇÃO E NUMEROS RANDOMICOS: 

// Random rnd = new Random();
// int number1 = 0; 
// int number2 = 0; 
// int corrects = 0; 
// int incorrects = 0;
// int result = 0; 
// string guessString; 
// int guess = 0;

// while (true)
//             {
//                 number1 = rnd.Next(10); 
//                 number2 = rnd.Next(10); 
//                 result = number1 * number2; 

//                 Console.WriteLine($"{number1} x {number2} = ");
//                 guessString = Console.ReadLine();
//                 if (guessString == string.Empty)
//                 {
//                     break;
//                 }
//                 guess = Convert.ToInt32(guessString);
//                 if (guess == result)
//                 {
//                     corrects++;
//                 } else
//                 {
//                     incorrects++;
//                 }
//                 if (incorrects == 5)
//                 {
//                     break;
//                 }
//                 Console.WriteLine($"Corrects answers: {corrects} ");
//                 Console.WriteLine($"Incorrect answers: {incorrects} ");
            // }

// QUESTAO 010

// Console.Write("Number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int fatorial = 1; 

// for (int i = number; i >=1; i--)
//             {
//                 fatorial *= i;
//             } Console.WriteLine($"The number is {number} and fatorial is {fatorial}");

// QUESTAO 011

// Random rnd = new Random();
// int left = 1; 
// int right = 100; 
// int number = rnd.Next(1, right +1);
// int attempts = 0;
// int guess = 0;

// while (true)
//             {
//                 Console.Write($"{left} to {right} => " );
//                 guess = Convert.ToInt32(Console.ReadLine());
//                 attempts++;
//                 if (guess == number)
//                 {
//                     Console.WriteLine($"Congratulations you gessed the right number with {attempts} attempts");
//                     break; 
//                 } else if (guess < number)
//                 { 
//                     left = guess +1;
//                 } else
//                 {
//                     right = guess -1; 
//                 } if (left == right)
//                 {
//                     Console.WriteLine($"You lost!!! With {attempts} attempts");
//                     break;
//                 }
//             }


// QUESTAO 012

// Console.Write("Number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int numberAuxiliador = number; 
// int numberInverted = 0;

// while (numberAuxiliador != 0)
//             {
//                 int lastDigit = numberAuxiliador % 10; // Aqui ele pega os numeros no resto da divisão 
//                 numberInverted = numberInverted * 10 + lastDigit; // Aqui ele multiplica / ex: 5 - 50 e o numero auxiliador divide por 10
//                 numberAuxiliador /= 10; // Aqui ele divide por 10
//             } 
//             Console.WriteLine($"The number is {number} and the inverted is {numberInverted}");

























// ARRAYS

    // int[] numbers = new int[3];

    // Console.Write("Number 1: "); 
    // numbers[0] = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Number 2: "); 
    // numbers[1] = Convert.ToInt32(Console.ReadLine());
    // Console.Write("Number 3: "); 
    // numbers[2] = Convert.ToInt32(Console.ReadLine());

    // Array.Sort(numbers);

    // Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");


        }
             }
    }

 
