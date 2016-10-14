using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using ASSISTME.SNIPS;

namespace ARGOTH.SNIPS.MON
{
    public unsafe sealed class Otsu: Filter
    {   
        public static Bitmap Execute(Bitmap img)
        {
            if (img == null)
                return img;

            Init(img);

            for (i = 0; i < length; i++)
            {
                dataR = pixel->R;
               
                if (dataR < 127)
                    dataR = 0;
                else
                    dataR = byte.MaxValue;

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
