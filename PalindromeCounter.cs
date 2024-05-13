using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RppoonRefactoring
{
    class PalindromeCounter
    {
        public List<string> CountPalindromes(List<string> strings)
        {
            List<string> palindromes = new List<string>();

            if (strings == null) return palindromes;

            foreach (string str in strings)
            {
                if (IsPalindrome(str)) 
                {
                    palindromes.Add(str);
                }
            }
            return palindromes;
        }
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            string shorterWord = word.Replace(" ", "").ToLower();
            string reversedWord= new string(word.Reverse().ToArray());

            return shorterWord.Equals(reversedWord);
        }
    }
}
