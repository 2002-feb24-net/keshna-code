using System;

namespace Palindrome.Library
{
    public class PalStratergy 
    {
      
        public bool IsPalindrome(string checkString)
        {
            string string1 = checkString;
            char[] ch = string1.ToCharArray();
            Array.Reverse(ch);
            string rev = new string(ch);
            bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
	}
}
