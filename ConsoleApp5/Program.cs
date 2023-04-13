using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    // 5..Append one array to another array.
   // If array1 is { 5,6,7,8}
//and array 2 is { 9 ,10, 11, 12} resultant array will be { 5,6,7,8,9,10,11,12}


    internal class Program
    {
        private static object index2;

        static void Main(string[] args)
        {
            int[] arr1 = { 5, 6, 7, 8 };
            int[] arr2 = { 9,10,11,12};
            int[] result;

            int index=Array.IndexOf(arr1,5);
            if [index] = (0 , index + arr2.Length <= arr1.Length)
            {
                result = new int[arr1.Length + arr2.Length - 4];
                Array.Copy(arr1, result, index + 1);
                Array.Copy(arr2, 0, result, index + 1, arr2.Length);
                Array.Copy(arr1, index + 5, result, index2.Length + 1, arr1.Length - index - 5);
                Console.WriteLine("result:{0}", string.Join("", result));
            }
            else
            {
                Console.WriteLine("array one does not contain the sequence 5678");
            }

            }
        }
    }

