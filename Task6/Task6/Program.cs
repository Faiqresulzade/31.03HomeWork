using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "faig", "emil" };
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name[i].Length; j++)
                {
                    if ((name[i])[j] == 'e'|| (name[i])[j] == 'E')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
