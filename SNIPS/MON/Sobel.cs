using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace ARGOTH.SNIPS.MON
{
    public unsafe class Sobel:Filter
    {
        static int x11, x12, x13;
        const int pixelSize = 4; 

        static byte y11, y12, y13, y14, y15, y16, y17;
        static byte y21, y22, y23, y24, y25, y26, y27;
        static byte y31, y32, y33, y34, y35, y36, y37;

        static int U, V, W, Z;

        public static Bitmap Execute(Bitmap img)
        {
            if (img == null)
                return img;

            Init(img);
            InitTemp();

            x11 = (img.Width * pixelSize) - pixelSize;
            x12 = (img.Width * pixelSize);
            x13 = (img.Width * pixelSize) + pixelSize;

            for (int i = img.Width; i < length - img.Width; i++)
            {
                /*
                y11 = PixelAt((i % img.Width) - 1, (i / img.Width) - 1, pBase, img.Width)->R;
                y12 = PixelAt((i % img.Width) , (i / img.Width) - 1, pBase, img.Width)->R;
                y13 = PixelAt((i % img.Width) + 1, (i / img.Width) - 1, pBase, img.Width)->R;

                y21 = PixelAt((i % img.Width) - 1, (i / img.Width) , pBase, img.Width)->R;
                y23 = PixelAt((i % img.Width) + 1, (i / img.Width) , pBase, img.Width)->R;

                y31 = PixelAt((i % img.Width) - 1, (i / img.Width) + 1, pBase, img.Width)->R;
                y32 = PixelAt((i % img.Width) , (i / img.Width) + 1, pBase, img.Width)->R;
                y33 = PixelAt((i % img.Width) + 1, (i / img.Width) + 1, pBase, img.Width)->R;

                U = Math.Abs((y11 - y13) + (2 * y21 - (2 * y23)) + (y31 - y33));
                V = Math.Abs((y11 - y31) + (2 * y12 - (2 * y32)) + (y13 - y33));
                W = Math.Abs((y12 - y21) + (2 * y31 - (2 * y13)) + (y23 - y32));
                Z = Math.Abs((y21 - y32) + (2 * y11 - (2 * y33)) + (y12 - y23));//*/

                pixT->R = pixel->R;
                pixT->G = pixel->G;
                pixT->B = pixel->B;
                pixT->A = 255;
                
                pixel++;
                pixT++;
            }
           
            bmp.UnlockBits(bmTemp);
            img.UnlockBits(bmData);

            return bmp;
        }
    }
}
