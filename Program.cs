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

            // EXERCICIO 003
            Console.WriteLine("Type a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
             }
    }
}