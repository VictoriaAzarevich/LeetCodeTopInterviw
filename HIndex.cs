using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTopInterviw
{
    public class HIndex
    {
        public static int HIndexSolution(int[] citations)
        {
            int hIndex = 0;
            for (int i = 1; i <= citations.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < citations.Length; j++)
                {
                    if (citations[j] >= i)
                    {
                        count++;
                    }

                    if (count == i)
                    {
                        hIndex = i;
                        break;
                    }
                }

                if (count == 0)
                {
                    return hIndex;
                }
            }

            return hIndex;
        }
    }
}
