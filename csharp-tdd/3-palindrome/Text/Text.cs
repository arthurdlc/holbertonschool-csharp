﻿using System;
using System.Linq;

namespace Text
{
    ///<summary>Provides text-related utility methods.</summary>
    public class Str
    {
        ///<summary>
        /// Checks if a given string is a palindrome, ignoring case, spaces, and punctuation.
        ///</summary>
        ///<param name="s">The input string to check.</param>
        ///<returns>True if the string is a palindrome, otherwise False.</returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null) // Handle null input
                return false;

            // Remove spaces, punctuation, and convert to lowercase
            string cleaned = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Compare the cleaned string with its reverse
            return cleaned.SequenceEqual(cleaned.Reverse());
        }
    }
}
