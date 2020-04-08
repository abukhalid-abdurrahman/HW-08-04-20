using System;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing ArrayHelper Class (using string type)...");
            string[] arrStr = {"Faridun", "Firuz", "Jamshed", "Kamila", "Nisso", "Khasan", "Mijgona"};
            ArrayHelper.Output(arrStr);
            string deletedElement = ArrayHelper.Pop(ref arrStr);
            Console.WriteLine("Deleted (pop method): " + deletedElement);
            ArrayHelper.Output(arrStr);
            int arrSize = ArrayHelper.Push(ref arrStr, "Saodat");
            Console.WriteLine("New Size (after Push method): " + arrSize);
            ArrayHelper.Output(arrStr);
            string shiftStr = ArrayHelper.Shift(ref arrStr);
            Console.WriteLine("Deleted (shift method): " + shiftStr);
            ArrayHelper.Output(arrStr);
            int unShiftSize = ArrayHelper.UnShift(ref arrStr, "Avaz");
            Console.WriteLine("New Size (after UnShift method): " + unShiftSize);
            ArrayHelper.Output(arrStr);
        }
    }
}
