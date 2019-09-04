using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GN89.GrASM.Base
{
    public static class Numbers
    {
        /// <summary>
        /// Проверяет, является ли строка десятичным представлением числа.
        /// </summary>
        /// <param name="src"></param>
        /// <returns></returns>
        public static bool IsDec(string src)
        {
            var reg = new Regex(@"\d");
            // return reg.IsMatch(src);
            bool result = true;
            foreach(char ch in src)
            {
                if (!reg.IsMatch(ch.ToString())) {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}
