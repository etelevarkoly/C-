using System;

namespace hazi4 
{
    class Program
    {

        public static int demeritPts;

        static void Main(string[] args)
        {
            
            System.Console.WriteLine("enter speed limit, then enter car speed:");
            try
            {
                int speedLimit = Convert.ToInt32(Console.ReadLine());
                int carSpeed = Convert.ToInt32(Console.ReadLine());    
                speedCamera(speedLimit, carSpeed);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("EXCEPTION; THROWING CODE 1");
                throw;
            }
        }

        public static void speedCamera(int limit, int speed)
        {
            if (limit >= speed)
            {
                System.Console.WriteLine("OK");
            }
            else if (limit < speed)
            {
                if (limit + 1 <= speed && limit + 4 > speed)
                {
                    demeritPts++;
                    System.Console.WriteLine("DEMERIT_POINTS: {0}", demeritPts);
                }
                else if (limit + 5 <= speed && limit + 10 > speed)
                {
                    demeritPts += 2;
                    System.Console.WriteLine("DEMERIT_POINTS: {0}", demeritPts);
                }
                else if (limit + 10 <= speed && limit + 15 > speed)
                {
                    demeritPts += 3;
                    System.Console.WriteLine("DEMERIT_POINTS: {0}", demeritPts);
                }
                else if (limit + 15 <= speed && limit + 20 > speed)
                {
                    demeritPts += 4;
                    System.Console.WriteLine("DEMERIT_POINTS: {0}", demeritPts);
                }
                else if (limit + 100 <= speed)
                {
                    System.Console.WriteLine("License Suspended.");
                }
            }
        }
    }
}