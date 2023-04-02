using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Sentence!");
            string sentence = Console.ReadLine();
            ToUpper(sentence);
        }
        public static void ToUpper(string sentence)
        {
            char[] element = sentence.ToCharArray();
            for (int i = 0; i < sentence.Length; i++)
            {
                if(i==0&&element[i]!=' '|| element[i]!=' ' &&element[i-1]==' ')
                {
                    if (element[i] >= 'a' && element[i] <= 'z')
                    {
                        element[i] = (char)(element[i] - 'a' + 'A');
                    }
                }
                else if (element[i] >= 'A' && element[i] <= 'Z')
                {
                    element[i] = (char)(element[i] + 'a' - 'A');
                }
            }
            Console.WriteLine(element);
        }
    }
}
