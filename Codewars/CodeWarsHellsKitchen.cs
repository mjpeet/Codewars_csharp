using System;
using System.Collections.Generic;
using System.Linq;

/*
 * https://www.codewars.com/kata/57d1f36705c186d018000813/train/csharp 
 * 
 * Gordon Ramsay shouts. He shouts and swears. There may be something wrong with him.
 *
 * Anyway, you will be given a string of four words. Your job is to turn them in to Gordon language.
 *
 * Rules:
 *
 * Obviously the words should be Caps, Every word should end with '!!!!', Any letter 'a' or 'A' should become '@', Any other vowel should become '*'.
 */

namespace Codewars
{
    public class Kata
    {
        public static string Gordon(string a)
        {
            a = a.ToUpper();
            a = a.Replace('A', '@');
            a = a.Replace(" ", "!!!! ");
            a = a + "!!!!";
            var vowels = new List<char> { 'E', 'I', 'O', 'U' };
            a = new string(a.Select(c => vowels.Contains(c) ? '*' : c).ToArray());
            return a;
        }
    }
}
