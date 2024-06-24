using System;
using System.Collections.Generic;

namespace stringz
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            else 
            {
                // ez nem lesz jó, mert ugye levághat random szavakat/szótöredékeket
                // text.Substring(0, maxLength);

                var words = text.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                return string.Join(" ", summaryWords) + " ...";
            } 
        }
    }
}