using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin: ");
            string numstr = Console.ReadLine();
            bool result = int.TryParse(numstr, out int num);
            bool resultDouble = double.TryParse(numstr, out double numdouble);
            if (result)
            {
                Console.WriteLine(num);
            }else if (resultDouble)
            {
                Console.WriteLine(numdouble);
            }
            else
            {
                Console.WriteLine("Duzgun daxil edin! ");
            }
            
        }
    }
}
