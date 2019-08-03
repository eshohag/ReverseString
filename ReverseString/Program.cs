using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string str = Console.ReadLine();
            string reverse = string.Empty;

            if (str != null)
                foreach (char ch in str)
                {
                    reverse = ch + reverse;
                }
            Console.WriteLine("1st Reverse string is- " + reverse);

            reverse = string.Empty;
            if (str != null)
                for (int i = str.Length - 1; i >= 0; i--)
                    reverse += str[i];

            Console.WriteLine("2nd Reverse string is- {0}", reverse);

            if (str != null)
            {
                char[] cArray = str.ToCharArray();
                reverse = string.Empty;
                for (int i = cArray.Length - 1; i >= 0; i--)
                {
                    reverse += cArray[i];
                }
                Console.WriteLine($"3rd Reverse string is- {reverse}");
            }

            if (str != null)
            {
                int inc = str.Length - 1;
                reverse = string.Empty;
                while (inc >= 0)
                {
                    reverse += str.ToCharArray()[inc];
                    inc--;
                }
                Console.WriteLine($"4th Reverse string is- {reverse}");
            }

            reverse = string.Empty;
            if (str != null)
            {
                int d = str.Length - 1;
                do
                {
                    reverse += str.ToCharArray()[d];
                    d--;
                } while (d >= 0);
                Console.WriteLine($"5th Reverse string is- {reverse}");
            }

            Console.ReadLine();
        }
    }
}
