using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        List<int> list = array.ToList();
        list.Sort();
        int answer = list[list.Count / 2];
        return answer;
    }
}