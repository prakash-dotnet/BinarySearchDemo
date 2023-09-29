using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchDemo
{
    internal class Program
    {
        //Binary Search Demo
        // It follow Divide and Conquer algorithm
        // All the elements of array should be sorted in ascending order before we do Binary search
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Return -1 if the target is not found
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 19, 1, 14, 5, 3, 12, 2, 13, 7, 4 };
            Array.Sort(arr); //sorting the array
            Console.WriteLine("enter an element to search:");
            int n=Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch(arr,n);
            if(result == -1) {
                Console.WriteLine(n+ "is not found..!");
            }
            else
            {
                Console.WriteLine(n+" is found.");
            }


            Console.ReadKey();
        }
    }
}
