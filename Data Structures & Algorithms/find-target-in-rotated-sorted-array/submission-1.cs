public class Solution {
    public int Search(int[] nums, int target) {
      int right = nums.Length - 1;
      int left = 0;
      int mid ;
      while (left < right)
      {
        mid = left + ( right - left ) / 2;
        if (target == nums[mid] )
         return mid;
        else if (nums[mid] > target)
         left = mid ;
        else
         right = mid ;    
      }

      return -1;
    }
}
