using System;
using System.Collections.Generic;

/*
1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

-If no one likes your post, it doesn't display anything.
-If only one person likes your post, it displays: [Friend's Name] likes your post.
-If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
-If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
Depending on the number of names provided, display a message based on the above pattern.
*/

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