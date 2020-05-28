using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyVector

{
   public class Vector<T> where T : struct
    {
        private T x;
        private T y;
        private T z;

        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        public T Z
        {
            get { return z; }
            set { z = value; }
        }


        private void validateParameters(T x, T y, T z)
        {
            if (x is bool || x is char)
            {
                throw new Exception("Incorrect input type for x");
            }

            if (y is bool || y is char)
            {
                throw new Exception("Incorrect input type for y");
            }

            if (z is bool || z is char)
            {
                throw new Exception("Incorrect input type for z");
            }
        }


        public Vector(T x, T y, T z)
        {
            validateParameters(x, y, z);

            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static T operator *(Vector<T> v1, Vector<T> v2)
        {
            dynamic x1 = v1.X;
            dynamic x2 = v2.X;
            dynamic y1 = v1.Y;
            dynamic y2 = v2.Y;
            dynamic z1 = v1.Z;
            dynamic z2 = v2.Z;
            return x1 * x2 + y1 * y2 + z1 * z2;
        }
       
        public static double findCorner(Vector<T> v1, Vector<T> v2)
        {
            dynamic x1 = v1.X;
            dynamic x2 = v2.X;
            dynamic y1 = v1.Y;
            dynamic y2 = v2.Y;
            dynamic z1 = v1.Z;
            dynamic z2 = v2.Z;
            return (v1 * v2) / (Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2) + Math.Pow(z1, 2))  * Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2) + Math.Pow(z2, 2)));
        }


    }
}
