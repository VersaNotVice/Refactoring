using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RppoonRefactoring
{
    class UniqueCounter
    {
        public static List<char> CountUniqe(string text)
        {
            List<char> characters = new List<char>();
            for (int i = 0; i < text.Length; i++)
            {
                if (CountOccurrence(text, text[i]) == 1)
                {
                    characters.Add(text[i]);
                }
            }
            return characters;
        }
        public static int CountOccurrence(string text, char character)
        {
            int count = 0;
            for (int j = 0; j < text.Length; j++)
            {
                if (character == text[j])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
