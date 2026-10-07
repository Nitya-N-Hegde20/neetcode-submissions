public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int exp = ((n)*(n+1))/2;
        int act = 0 ;
        foreach(int i in nums)
        {
            act += i;
        }
        return exp-act;
    }
}
