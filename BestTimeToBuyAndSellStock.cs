namespace LeetCodeTopInterviw
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 1)
            {
                return 0;
            }

            int min = prices[0];
            int max = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (min > prices[i])
                {
                    min = prices[i];
                    max = prices[i];
                }
                else if (max < prices[i])
                {
                    max = prices[i];
                    if (profit < max - min)
                    {
                        profit = max - min;
                    }
                }
            }

            return profit;
        }

        public static int MaxProfit1(int[] prices)
        {
            int max = 0;
            int min = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }

                else if ((prices[i] - min) > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
        }
    }
}
