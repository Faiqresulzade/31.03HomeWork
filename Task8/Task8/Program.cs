using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            char[] letter = { 'a', 'ı', 'o', 'u', 'e', 'ə', 'i', 'ö', 'ü' };
            Console.Write("Cumleni daxil edin:");
            string sentence = Console.ReadLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < letter.Length; j++)
                {
                    if (sentence[i] == letter[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
