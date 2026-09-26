public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if (map.ContainsKey(i))
            map[i]++;
            else
            map[i]=1;
        }
        var sorted = map.OrderByDescending(x => x.Value).ToList();

        int[] res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = sorted[i].Key;
        }
        return res;

    }
}
