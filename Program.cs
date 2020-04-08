using System;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing ArrayHelper Class (using string type)...");
            string[] arrStr = {"Faridun", "Firuz", "Jamshed", "Kamila", "Nisso", "Khasan", "Mijgona"};
            string deletedElement = ArrayHelper.Pop(ref arrStr);
            Console.WriteLine("Deleted: " + deletedElement);
            ArrayHelper.Output(arrStr);
        }
    }
}
