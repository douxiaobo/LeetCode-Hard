using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> numslist = new List<int> { };
            for (int i = 0; i < nums1.Length; i++)
            {
                numslist.Add(nums1[i]);
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                numslist.Add(nums2[i]);
            }
            numslist.Sort();
            int[] numsarray = numslist.ToArray();
            int mid = numsarray.Length / 2;
            if (numsarray.Length % 2 == 1)
            {
                return (double)numsarray[mid];
            }
            else
            {
                return (((double)numsarray[mid] + (double)numsarray[mid - 1]) / (double)2);
            }
        }//Runtime: 108 ms, Beats 72.89%; Memory: 51 MB, Beats 44.31%
        static void Main(string[] args)
        {
            Console.WriteLine(FindMedianSortedArrays(new int[]{ 1,3 },new int[]{ 2}));
            Console.WriteLine(FindMedianSortedArrays(new int[]{ 1,2 },new int[]{ 3,4}));
            Console.ReadKey();
        }
    }
}
