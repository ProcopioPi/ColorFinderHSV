using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ARGOTH.SNIPS.MON
{
    /// <p>
    /// Structure used in the HSV converter method
    /// <p>
    public struct myHSV
    {
        public double hue;
        public double value;
        public double saturation;

        public myHSV(double hue, double value, double luma)
        {
            this.hue = hue;
            this.value = value;
            this.saturation = luma;
        }
    }
    /// <p>
    /// Class with static methods that inherits from Filter class the main methods to
    /// convert an image into a byte array.
    /// <p>
    public unsafe sealed class ColorFinder : Filter
    {
        private static double cMax, cMin, gradient;
        private static myHSV hsv;

        const float Pr = 0.2125f;
        const float Pg = 0.7154f;
        const float Pb = 0.0721f;

        /// <p>
        /// Static method to compare each pixel of an image to find
        /// the desired color value in HSV color representation.
        /// <p>
        ///  @param img is the bitmap object with image information with a resolution of 320x240
        ///  @param MIN is the integer number with the minimum value to find in the color disk between 0-360
        ///  @param MAX is the integer number with the maximum value to find in the color disk between 0-360
        public static Bitmap Execute(Bitmap img,int MIN, int MAX)
        {
            if (img == null)
                return img;

            Init(img);

            if (MAX < MIN)
            {
                int min = MIN;
                int max = MAX;

                MIN = max;
                MAX = min;
            }

            float R, G, B;
            double value;

            for (i = 0; i < length; i++)
            {
                R = ((float)pixel->R / byte.MaxValue);
                G = ((float)pixel->G / byte.MaxValue);
                B = ((float)pixel->B / byte.MaxValue);

                value =  RGB_TO_HSV(R, G, B).hue;

                if (value > MIN && value < MAX)
                {
                    pixel->R = 255;
                    pixel->G = 255;
                    pixel->B = 255;
                }

                pixel++;
            }

            img.UnlockBits(bmData);
            return img;
        }

        /// <p>
        /// Static method to convert r,g,b normalized values (0-1),
        /// into Hue, Saturation, Value color space
        /// <p>
        ///  @param r is a float normalized red value of the pixel 0-1
        ///  @param g is a float normalized green value of the pixel 0-1
        ///  @param b is a float normalized blue value of the pixel 0-1
        public static myHSV RGB_TO_HSV(float r, float g, float b)
        {
            hsv = new myHSV();
            hsv.saturation = (r * Pr + g * Pg + b * Pb);

            cMax = Math.Max(r, Math.Max(g, b));
            cMin = Math.Min(r, Math.Min(g, b));

            gradient = Math.Abs(cMax - cMin);

            if (gradient > 0)
            {
                if (cMax == r)
                    hsv.hue = (int)(60 * (((g - b) / gradient) % 6));
                if (cMax == g)
                    hsv.hue = (int)(60 * (((b - r) / gradient) + 2));
                if (cMax == b)
                    hsv.hue = (int)(60 * (((r - g) / gradient) + 4));
            }

            hsv.value = (cMax);

            if (hsv.hue < 0)
                hsv.hue += 360;
                     
            return hsv;
        }        
    }
}
