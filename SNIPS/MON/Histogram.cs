using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ARGOTH.SNIPS.MON
{
    public unsafe sealed class Histogram : Filter
    {
        private static byte[] r, g, b;

        public static Bitmap Execute(Bitmap img)
        {
            if (img == null)
                return img;
            
            r = new byte[256];
            g = new byte[256];
            b = new byte[256];

            byte R, G, B;
            Init(img);

            for (i = 0; i < length; i++)
            {
                R = pixel->R;
                G = pixel->G;
                B = pixel->B;

                r[R]++;
                g[G]++;
                b[B]++;

                pixel++;
            }

            img.UnlockBits(bmData);
            return img;
        }
    }
}
