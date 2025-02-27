using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class Array
    {
        public int FindSecondLargestNumber(int[] inputs)
        {
            if (inputs == null || inputs.Length < 2)
            {
                throw new ArgumentException("Array must be contained at leat two numbers");
            }

            var distinctSortedNumber = inputs.Distinct().OrderByDescending(x => x).ToList();

            if (distinctSortedNumber == null || distinctSortedNumber.Count < 2)
            {
                throw new InvalidOperationException("No second distinct largest element found");
            }

            return distinctSortedNumber[1];
        }
        public int FindSecondLargestNumber2(int[] inputs)
        {
            if (inputs == null || inputs.Length < 2)
            {
                throw new ArgumentException("Arrays must be contained at least two numbers");
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (var num in inputs)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }

                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                throw new InvalidOperationException("No second distinct largest element found");
            }

            return secondLargest;
        }
        public int[] RemoveDuplicates(int[] inputs)
        {
            if (inputs == null)
            {
                throw new ArgumentNullException(nameof(inputs), "Array is empty");
            }

            return inputs.Distinct().ToArray();

        }
        public int[] ReverseArray(int[] input)
        {
            List<int> reverse = new List<int>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse.Add(input[i]);
            }

            //var reverse = input.Reverse();

            return reverse.ToArray();
        }
    }
}