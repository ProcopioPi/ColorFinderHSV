using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARGOTH.SNIPS.CNV
{
    public class SobelGx : Matrix
    {
        public SobelGx(int size)
            : base(size)
        {
            values = new float[,] {     { -1,0,1},
                                        { -2,0,2}, 
                                        { -1,0,1 } };
        }
    }
}
