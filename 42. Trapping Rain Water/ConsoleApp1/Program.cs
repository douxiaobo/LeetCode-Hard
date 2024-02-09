using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Trap1(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
            Console.ReadKey();
        }
        public int Trap(int[] height)
        {
            int sum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (i == 0 && i == height.Length - 1)
                {
                    continue;
                }
                int rHeight = height[i];
                int lHeight = height[i];
                for (int r = i + 1; r < height.Length; r++)
                {
                    if (height[r] > rHeight)
                    {
                        rHeight = height[r];
                    }
                }
                for (int l = i - 1; l >= 0; l--)
                {
                    if (height[l] > lHeight)
                    {
                        lHeight = height[l];
                    }
                }
                int h = Math.Min(lHeight, rHeight) - height[i];
                if (h > 0)
                {
                    sum += h;
                }
            }
            return sum;
        }//Time Limit Exceeded
        public static int Trap1(int[] height)       //Two Points
        {
            if (height.Length <= 2)
            {
                return 0;
            }
            int[] maxLeft = new int[height.Length];
            int[] maxRight = new int[height.Length];
            for (int i = 0; i < height.Length; i++)
            {
                maxLeft[i] = 0;
                maxRight[i] = 0;
            }
            maxLeft[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                maxLeft[i] = Math.Max(height[i], maxLeft[i - 1]);
            }
            maxRight[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                maxRight[i] = Math.Max(height[i], maxRight[i + 1]);
            }
            int sum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                int count = Math.Min(maxLeft[i], maxRight[i]) - height[i];
                if (count > 0)
                {
                    sum += count;
                }
            }
            return sum;
        }//Runtime:101 ms Beats:58.79% Memory:42.8 MB Beats:28.98%
    }
}
