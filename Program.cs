using System; 

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
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



            //  EXERCICIO 001     
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

            // EXERCICIO 005
            Console.Write("Buying Price: "); // Pede ao usuario um valor de compra de um produto
            double buyingPrice = Convert.ToDouble(Console.ReadLine()); // Converte o valor de uma string do valor do produto para um double (um valor inteiro com casas decimais)
            Console.Write("Profit Percentage: "); // Pede ao usuario um valor de porcentagem de lucro que ele deseja ter sobre o produto
            double profitPercentage = Convert.ToDouble(Console.ReadLine()); // Converte o valor de uma string de porcentagem para um double (um valor inteiro com casas decimais)
            double profit = buyingPrice * (profitPercentage / 100); // Calcula o lucro do produto multiplicando o valor de compra do produto pela porcentagem de lucro dividida por 100 (para transformar a porcentagem em decimal)
            double sellingPrice = buyingPrice + profit; // Calcula o valor de venda do produto somando o valor de compra do produto com o lucro calculado anteriormente
            Console.WriteLine($"Selling Price {sellingPrice}"); // Mostra o valor de venda do produto apos a soma do valor de compra com o lucro calculado anteriormente
            Console.WriteLine($"Profit {profit}"); // Mostra o valor de porcentagem calculado anteriormente

            










































        }
             }
    }

 
