using System;
using System.Linq;

namespace Day_9
{
    public class ArrayHelper
    {
        #region String[] Type
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
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        public static string Shift(ref string[] array)
        {
            string results = string.Empty;
            if(array != null)
            {
                results = array[0];
                array = array.Skip(1).ToArray();
            }
            return results;
        }

        public static int UnShift(ref string[] array, string element)
        {
            if(array != null)
            {
                string[] edited = array.Prepend(element).ToArray();
                array = edited;
            }
            return array.Length;
        }
        #endregion

        #region Int32[] Type
        public static int Pop(ref int[] array)
        {
            int endIndex = array.Length - 1;
            int results = 0;
            if(array != null)
            {
                results = array[endIndex];
                Array.Resize(ref array, array.Length - 1);
            }
            return results;
        }

        public static int Push(ref int[] array, int element)
        {
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        public static int Shift(ref int[] array)
        {
            int results = 0;
            if(array != null)
            {
                results = array[0];
                array = array.Skip(1).ToArray();
            }
            return results;
        }

        public static int UnShift(ref int[] array, int element)
        {
            if(array != null)
            {
                int[] edited = array.Prepend(element).ToArray();
                array = edited;
            }
            return array.Length;
        }
        #endregion
        
        #region Double[] Type
        public static double Pop(ref double[] array)
        {
            int endIndex = array.Length - 1;
            double results = 0.0;
            if(array != null)
            {
                results = array[endIndex];
                Array.Resize(ref array, array.Length - 1);
            }
            return results;
        }

        public static int Push(ref double[] array, double element)
        {
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        public static double Shift(ref double[] array)
        {
            double results = 0.0;
            if(array != null)
            {
                results = array[0];
                array = array.Skip(1).ToArray();
            }
            return results;
        }

        public static int UnShift(ref double[] array, double element)
        {
            if(array != null)
            {
                double[] edited = array.Prepend(element).ToArray();
                array = edited;
            }
            return array.Length;
        }
        #endregion

        #region Decimal[] Type
        public static decimal Pop(ref decimal[] array)
        {
            int endIndex = array.Length - 1;
            decimal results = 0;
            if(array != null)
            {
                results = array[endIndex];
                Array.Resize(ref array, array.Length - 1);
            }
            return results;
        }

        public static int Push(ref decimal[] array, decimal element)
        {
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        public static decimal Shift(ref decimal[] array)
        {
            decimal results = 0;
            if(array != null)
            {
                results = array[0];
                array = array.Skip(1).ToArray();
            }
            return results;
        }

        public static int UnShift(ref decimal[] array, decimal element)
        {
            if(array != null)
            {
                decimal[] edited = array.Prepend(element).ToArray();
                array = edited;
            }
            return array.Length;
        }
        #endregion

        #region Float[] Type
        public static float Pop(ref float[] array)
        {
            int endIndex = array.Length - 1;
            float results = 0;
            if(array != null)
            {
                results = array[endIndex];
                Array.Resize(ref array, array.Length - 1);
            }
            return results;
        }

        public static int Push(ref float[] array, float element)
        {
            if(array != null)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = element;
            }
            return array.Length;
        }

        public static float Shift(ref float[] array)
        {
            float results = 0;
            if(array != null)
            {
                results = array[0];
                array = array.Skip(1).ToArray();
            }
            return results;
        }

        public static float UnShift(ref float[] array, float element)
        {
            if(array != null)
            {
                float[] edited = array.Prepend(element).ToArray();
                array = edited;
            }
            return array.Length;
        }
        #endregion
        public static void Output(object[] array)
        {
            Console.WriteLine($"Elements of Array (Length: {array.Length}): " + String.Join(",", array));
        }
    }
}