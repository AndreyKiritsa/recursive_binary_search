using System;
namespace ConsoleApp1
{
    public class Example
    {
        public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
        {
            if (left == right - 1) return left;
            var m = (left + right) / 2;
            if (array[m] < value)
                return BinSearchLeftBorder(array, value, m, right);
            return BinSearchLeftBorder(array, value, left, m);
        }

        public static void Main()
        {
            var array = new long[] {2,4,4,6};
            var result = BinSearchLeftBorder(array, 2, 0, array.Length);
            Console.WriteLine(result);
        }
    }
}
