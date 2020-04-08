using System;
using System.Linq;

namespace Day_9
{
    public class ArrayHelper
    {
        public static string Pop(ref string[] array)
        {
            int endIndex = array.Length - 1;
            string results = string.Empty;
            if(array != null)
            {
                results = array[endIndex].ToString();
                Array.Resize(ref array, array.Length - 1);
            }
            return results;
        }

        public static int Push(ref string[] array, string element)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = element;
            return array.Length;
        }

        public static void Output(object[] array)
        {
            Console.WriteLine($"Elements of Array (Length: {array.Length}): " + String.Join(",", array));
        }
    }
}