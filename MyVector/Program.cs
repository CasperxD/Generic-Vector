using System;

namespace MyVector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector<int> v1 = new Vector<int>(1, 2, 3);
            //Vector<int> v2 = new Vector<int>(4, 5, 6);
            Vector<int> v1;
            try
            {
               v1 = new Vector<int>(1, 2, 3);
            } catch (Exception e)
            {
                Console.WriteLine("Error during vector creation. Cause:" + e.Message);
                return;
            }

            Vector<int> v2;
            try
            {
                v2 = new Vector<int>(4, 5, 6);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during vector creation. Cause:" + e.Message);
                return;
            }

           
            var result = v1 * v2;
            var corner = Vector<int>.findCorner(v1, v2);
            Console.WriteLine(result);
            Console.WriteLine(corner);
            Console.ReadLine();
        }
    }
}
