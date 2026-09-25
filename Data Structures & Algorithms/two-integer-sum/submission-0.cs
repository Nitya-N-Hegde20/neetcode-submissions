public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int another;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for (int i=0; i<nums.Length; i++){
            another = target - nums[i];
            if(dict.ContainsKey(another))
             return new int[]{dict[another],i};
            dict[nums[i]] = i;
        }
        return new int[2];
    }
}
