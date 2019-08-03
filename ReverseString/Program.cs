using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string:");
            var input = Console.ReadLine();
            string reverse = string.Empty;

            if (input != null)
            {
                var str = input.ToCharArray();

                foreach (char ch in str)
                {
                    reverse = ch + reverse;
                }
                Console.WriteLine("1st Reverse string is- " + reverse);

                reverse = string.Empty;
                for (int i = str.Length - 1; i >= 0; i--)
                    reverse += str[i];
                Console.WriteLine("2nd Reverse string is- {0}", reverse);

                reverse = string.Empty;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reverse += str[i];
                }
                Console.WriteLine($"3rd Reverse string is- {reverse}");

                int inc = str.Length - 1;
                reverse = string.Empty;
                while (inc >= 0)
                {
                    reverse += str[inc];
                    inc--;
                }
                Console.WriteLine($"4th Reverse string is- {reverse}");

                reverse = string.Empty;
                int d = str.Length - 1;
                do
                {
                    reverse += str[d];
                    d--;
                } while (d >= 0);
                Console.WriteLine($"5th Reverse string is- {reverse}");
            }

            Console.ReadLine();
        }
    }
}
