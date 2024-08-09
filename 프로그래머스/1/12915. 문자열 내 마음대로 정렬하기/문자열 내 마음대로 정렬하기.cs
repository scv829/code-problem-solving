using System;
using System.Linq;

public class Solution {
    public string[] solution(string[] strings, int n) {
        
Array.Sort(strings);
return strings.OrderBy(s => s[n]).ToArray();
    }
}