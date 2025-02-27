using System;

namespace DataStructures

{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!!");

            //int[] inputs = new int[] { 10, 10, 10, 10, 10, 20 };

            //Pratice1 p1 = new Pratice1();

            //Console.WriteLine(p1.FindSecondLargestNumber(inputs).ToString());

            //int[] inputs2 = new int[] { 10, 10, 10, 10, 10, 20 };

            //Console.WriteLine(p1.FindSecondLargestNumber2(inputs2));

            //int[] inputs3 = new int[] { 10, 10, 10, 10, 10, 20 };

            //var resultArray = p1.RemoveDuplicates(inputs3);

            //Console.WriteLine(string.Join(",", p1.RemoveDuplicates(inputs3)));

            //int[] input4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine(string.Join(",", p1.ReverseArray(input4)));

            // Usage:
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);

            list.Remove(30);
            list.Print(); // Output: 10 -> 20 -> 30 -> null

            Node node = list.Find(30);

            Console.WriteLine(node == null ? "Not Found" : "Found");
        }
    }
}
