public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
         Dictionary<string, List<string>> groups = new();

    foreach (string str in strs)
    {
        

        string key = string.Concat(str.OrderBy(x=>x));

        if (!groups.ContainsKey(key))
        {
            groups[key] = new List<string>();
        }

        groups[key].Add(str);
    }

    return groups.Values
                 .Select(group => (List<string>)group)
                 .ToList();
    }
}
