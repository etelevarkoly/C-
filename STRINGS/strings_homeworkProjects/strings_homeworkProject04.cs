using System;
using System.Collections.Generic;

/*
4- Write a program and ask the user to enter a few words separated by a space. 
Use the words to create a variable name with PascalCase. For example, if the user types: 
"number of students", display "NumberOfStudents". Make sure that the program is not dependent on the input. 
So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
*/


/// EZ MÉG NEM JÓ FASZOMAT

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter a few words separated by whitespace");
            string userInputStr = Console.ReadLine();
			userInputStr = userInputStr.ToLower();
            System.Console.WriteLine("user input string: " + userInputStr);
            var userInputArray = userInputStr.Split(' ');
            var userInputList = new List<string>();

            for (var i = 0; i < userInputArray.Length; i++)
            {
                var originalWord = userInputArray[i].ToCharArray();
                var upperCaseChar = char.ToUpper(originalWord[0]);
				var newWord = originalWord.ToString();
				newWord.Replace(newWord[0], upperCaseChar);
				userInputList.Add(newWord);
				Console.WriteLine(newWord);
			}
        }
    }
}