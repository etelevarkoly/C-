using System;
using System.Collections.Generic;

namespace arrayListHW
{
    class arrayListHomework1
    {
        		
		static void Main(string[] args)
        {
			List<string> names = new List<string>();
			string userInput;
            System.Console.WriteLine("enter names who liked your post:");
            while (true)
            {
                userInput = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userInput))
                {
                    break;
                }
                               
				names.Add(userInput);
                
            }

            likeMethod(names);

        }

        public static void likeMethod(List<string> names)
        {
            if (names.Count == 0)
            {
                System.Console.WriteLine("PLACEHOLDER; YOU ARE NOT BEING LIKED :(");
            }
            else if (names.Count == 1)
            {
                System.Console.WriteLine("{0} likes your post.", names[0]);
            }
            else if (names.Count == 2)
            {
                System.Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else 
            {
                System.Console.WriteLine("{0}, {1} and {2} others like your post.", names[0], names[1], names.Count - 2);
            }
        }
    }
}