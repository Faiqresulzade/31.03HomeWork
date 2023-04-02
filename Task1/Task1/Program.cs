using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sentence");
            string sentence = Console.ReadLine();
           string[] word=sentence.Split();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i].Length);
            }
        }
    }
}
