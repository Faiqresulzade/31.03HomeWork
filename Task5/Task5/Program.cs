using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededleri daxil edin: ");
            string numStr = Console.ReadLine();
            string[] nums = numStr.Split(',');
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += int.Parse(nums[i]);
            }
            Console.WriteLine(sum/nums.Length);
        }
    }
}
