public class Solution {
    public int LengthOfLongestSubstring(string s) {
    HashSet<char> set = new HashSet<char>();

        int left = 0;
        int maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);

            int currentLength = right - left + 1;

            maxLength = Math.Max(maxLength, currentLength);
        }

        return maxLength;
    }
}
