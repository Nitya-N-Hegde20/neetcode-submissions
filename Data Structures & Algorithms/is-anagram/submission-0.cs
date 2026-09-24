public class Solution {
    public bool IsAnagram(string s, string t) {
      string s1 = string.Concat(s.ToLower().OrderBy(x => x));
      string s2 = string.Concat(t.ToLower().OrderBy(s => s));
      if(s1!=s2)
      return false;
      else
      return true;
    }
}
