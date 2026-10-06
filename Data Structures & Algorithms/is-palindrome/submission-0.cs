public class Solution {
    public bool IsPalindrome(string s) {
        s.ToCharArray();
        StringBuilder str = new StringBuilder();
        foreach(var i in s)
        {
            if(char.IsLetterOrDigit(i))
                str.Append(char.ToLower(i));
        }

        int n = str.Length;
        int k = n-1;
        for (int j =0; j<n/2; j++)
        {
            if (str[j] != str[k--])
            return false;
        }
        return true;
    }
}
