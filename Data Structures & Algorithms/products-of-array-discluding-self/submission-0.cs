public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] product = new int[nums.Length];
        for(int i =0; i<nums.Length; i++)
        {
            int mult = 1;
            for (int j =0; j< nums.Length; j++){
            
            if ( j != i )
                mult = mult * nums[j];

            }

            product[i] = mult;
        }

        return product;
    }
}
