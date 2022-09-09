using System;

namespace Uppgift_2._10
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Vilken är din favorit bok");
            string bok = Console.ReadLine();
            Console.WriteLine("Den heter Programmering 1");
            string favvo = Console.ReadLine();

            Console.WriteLine("Jag hoppas jag komer få läsa den boken någon gång och lära mig lite programmering som dig" + bok + favvo + ".");
        }
    }
}