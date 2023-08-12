// https://leetcode.cn/problems/intersection-of-two-arrays/
// No.349
public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set = new HashSet<int>();
        foreach(var i in nums1){
            set.Add(i);
        }
        HashSet<int> result = new HashSet<int>();
        foreach(var i in nums2){
            if(set.Contains(i)){
                result.Add(i);
            }
        }
        int[] numbersArray = result.ToArray();
        return numbersArray;
    }
}
-------------------------------------------------------
  

  
