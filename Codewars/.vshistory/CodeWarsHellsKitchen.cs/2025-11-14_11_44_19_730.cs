using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public class Kata
    {
        public static string Gordon(string a)
        {
            a = a.ToUpper();
            a = a.Replace('A', '@');
            a = a.Replace(" ", "!!!! ");
            a = a.Trim();
            return a;
        }
    }
}
