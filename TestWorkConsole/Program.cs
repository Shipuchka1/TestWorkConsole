using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWorkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(rnd.Next(0, 1000));
            }
            Console.WriteLine("Первоначальный список:");
            ShowList(numbers);
            Console.WriteLine();
            Console.WriteLine("Без чисел, кратных трем:");
            Task2(numbers);
            ShowList(numbers);
            Console.WriteLine();
            Console.WriteLine("Их сумма - "+Task3(numbers));
            Console.WriteLine();
            List<Num> nums = Task4(numbers);
            Task5(nums);
            Console.WriteLine();
        }

        public static void ShowList(List<int> numbers)
        {
            foreach (int item in numbers)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }

        public static void Task2(List<int> numbers)
        {
            numbers.RemoveAll(r => r % 3 == 0);
        }

        public static int Task3(List<int> numbers)
        {
            return numbers.Sum();
        }

        public static List<Num> Task4(List<int> numbers)
        {
            List<Num> nums = new List<Num>();
            for (int i = 0; i < numbers.Count; i++)
                nums.Add(new Num() { Index = i, Value = numbers[i] });

            return nums;
       
        }

        public static void Task5(List<Num> nums)
        {
            Console.WriteLine("Список объектов:");
            foreach (Num item in nums)
            {
                Console.Write(String.Format("{0}-{1};",item.Index,item.Value));
            }
        }

        public class Num
        {
            public int Index { get; set; }
            public int Value { get; set; }
        }
    }
}
