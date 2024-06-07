using System;

// 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
// Display the reversed name on the console.

namespace HWprojectsxd
{
    class arrayListHomework2
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter your name bro:");
            
            var nameInput = Console.ReadLine();
            var charArray = new char[nameInput.Length];
            
            for (var i = nameInput.Length; i > 0; i--)
            {
                charArray[i-1] = nameInput[i-1];
            }
            
            Array.Reverse(charArray);

            // use the constructor of string
            string reversedName = new string(charArray);

            // or use the string.Join(); static method
            // string reversedName = string.Join("", charArray);

            // or use the string.Concat(); static method
            // string reversedName = string.Concat(charArray);

            System.Console.WriteLine(reversedName);
            
        }
    }
}