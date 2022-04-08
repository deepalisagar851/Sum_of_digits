using System;

namespace Sum_of_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(x!=0)
            {
              
                sum = sum+x % 10;
                x = x / 10;
            }
            Console.WriteLine("The sum of digits is:"+sum);
        }
    }
}
