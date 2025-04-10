namespace LeetCodeTopInterviw
{
    public class BestTimeToBuyAndSellStock2
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            int min = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                }
                else if (prices[i] - min >= max)
                {
                    max = prices[i] - min;
                    if (i >= prices.Length - 1)
                    {
                        profit += max;
                    }
                    else if (prices[i + 1] < prices[i])
                    {
                        profit += max;
                        max = 0;
                        min = prices[i + 1];
                        i++;
                    }
                }
            }

            return profit;
        }

        public static int MaxProfit1(int[] prices)
        {
            int max = 0;
            int start = prices[0];
            int len = prices.Length;
            for (int i = 1; i < len; i++)
            {
                if (start < prices[i])
                {
                    max += prices[i] - start;
                }
                start = prices[i];
            }
            return max;
        }
    }
}
