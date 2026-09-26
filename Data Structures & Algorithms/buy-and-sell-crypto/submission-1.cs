public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int min=0;
        for (int i=0; i<prices.Length; i++)
        {
            for(int j=i; j<prices.Length-1; j++)
            {
                min = prices[j] - prices[i];
                if(maxProfit < min)
                maxProfit = min ;
            }
        }
        return maxProfit;
    }
}
