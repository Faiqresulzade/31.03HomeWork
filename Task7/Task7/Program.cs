using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            bool result = int.TryParse(Console.ReadLine(), out int num);
            bool isEven;
            if (!result)
            {
                Console.WriteLine("ededi duzgun daxil edin!!");
                return;
            }
            isEven = (num % 2 == 0) ? true : false;
            Console.WriteLine(isEven);
        }
    }
}
