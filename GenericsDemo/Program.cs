using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArr = { 7, 8, 9, 10, 11, 12 };
            char[] charArr = { 'a', 'b', 'c' };
            Demo demo = new Demo();
            demo.Print(intArr);
            demo.Print(doubleArr);
            demo.Print(charArr);

            GenericsDemo generics = new GenericsDemo();
            generics.Print<int>(intArr);
            generics.Print<double>(doubleArr);
            generics.Print<char>(charArr);
        }
    }
}
