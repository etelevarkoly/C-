using System;

namespace hazi3 
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("first enter WIDTH, then HEIGHT:");
            try
            {
                int widthInputInt = Convert.ToInt32(Console.ReadLine());
                int heightInputInt = Convert.ToInt32(Console.ReadLine());
                imageOrientCheck(widthInputInt, heightInputInt);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("INCORRECT_INPUT; THROWING CODE 1");
                throw;
            }
        }

        public static void imageOrientCheck(int width, int height)
        {
            if (width > height)
            {
                System.Console.WriteLine("LANDSCAPE");
            }
            else if (width < height)
            {
                System.Console.WriteLine("PORTRAIT");
            }
            else 
            {
                System.Console.WriteLine("WIDTH & HEIGHT EQUAL");
            }
        }
    }
}