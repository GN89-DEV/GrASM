using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GN89.GrASM.Base
{
    public class Imm8
    {
        public static bool StringIsIt (string src)
        {
            return SByte.TryParse(src, out _);
        }
    }
}
