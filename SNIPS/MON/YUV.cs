using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ARGOTH.SNIPS.MON
{
    public unsafe class YUV:Filter
    {
        public static Bitmap Execute(Bitmap img)
        {
            if (img == null)
                return img;


            Init(img);

            for (i = 0; i < length; i++)
            {
                dataR =(byte)( (.299 * pixel->R) + (.587 * pixel->G) + (.114 * pixel->B)); 
               
                pixel->R = (byte)dataR;
                pixel->G = (byte)dataR;
                pixel->B = (byte)dataR;

                pixel++;
            }
            img.UnlockBits(bmData);

            return img;
        }

    
    }
}
