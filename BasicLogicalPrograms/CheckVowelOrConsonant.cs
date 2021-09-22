using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class CheckVowelOrConsonant
    {
        public void IsVowelOrConsonant()
        {
            Console.WriteLine("Enter a Alphabet (A-Z or a-z) to check whether it is Vowel or Consonant");
            try
            {
                char ch = Convert.ToChar(Console.ReadLine().ToLower());
                if ((ch == 'a') || (ch == 'e') || (ch == 'i') || (ch == 'o') || (ch == 'u'))
                {
                    Console.WriteLine("Alphabet is vowel");
                }
                else
                {
                    Console.WriteLine("Alphabet is consonant");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Enter only Alphabets");
                IsVowelOrConsonant();
            }
            
        }
    }
}
