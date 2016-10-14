using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARGOTH.SNIPS
{
    public class Matrix
    {
        int size;

        public int Size
        {
            get { return size; }
        }

        protected float[,] values;

        public float this[int key1, int key2]
        {
            get { return values[key1, key2]; }
        }

        public Matrix(int size)
        {
            this.size = size;
            values = new float[size, size];
        }


    }
}
