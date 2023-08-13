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
//////////////////////////////////////////////////////////
// https://leetcode.cn/problems/intersection-of-two-arrays-ii/
// No.350
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        if(nums1.Length > nums2.Length){
            return Intersect(nums2, nums1);
        }
        Dictionary<int, int> dit = new Dictionary<int, int>();
        List<int> result = new List<int>();
        
            foreach(var i in nums1){
                dit.TryAdd(i, 0);
                dit[i]++;
            }
            foreach(var i in nums2){
                if(dit.ContainsKey(i) && dit[i] > 0){
                    result.Add(i);
                    dit[i]--;
                }
            }
        return result.ToArray();
    }
}
// use sorted array
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        Array.Sort(nums2);
        int i=0;
        int j=0;
        List<int> result = new List<int>();
        while(i<nums1.Length && j<nums2.Length){
            if(nums1[i] == nums2[j]){
                result.Add(nums2[j]);
                i++;
                j++;
            }else if(nums1[i] > nums2[j]){
                j++;
            }else{
                i++;
            }
        }
        return result.ToArray();
    }
}
////////////////////////////////////////////////////
// https://leetcode.cn/problems/happy-number/
// No.202
public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> set = new HashSet<int>();
        while(n != 1 ){
            int temp = 0;
            while(n != 0){
                temp += (n%10)*(n%10);
                n = n/10;
            }
            if(temp == 1){
                return true;
            }
            if(!set.Add(temp)){
                return false;
            }
            n = temp;        
        }
        return true;
    }
}
///////////////////////////////////////////////
// https://leetcode.cn/problems/4sum-ii/
// No.454
// 第二个双重循环里就可以判断是否又满足条件的目标了，不需要两个Dictionary和第三遍循环
public class Solution {
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
        Dictionary<int, int> dit1 = new Dictionary<int, int>();
        // Dictionary<int, int> dit2 = new Dictionary<int, int>();
        for(int i=0; i<nums1.Length; i++){
            for(int j=0; j<nums2.Length; j++){
                dit1.TryAdd((nums1[i]+nums2[j]), 0);
                dit1[(nums1[i]+nums2[j])]++;
            }
        }
        int n = 0;
        for(int i=0; i<nums3.Length; i++){
            for(int j=0; j<nums4.Length; j++){
                if(dit1.ContainsKey(0-(nums3[i]+nums4[j]))){
                    n += dit1[0-(nums3[i]+nums4[j])];
                }
            }
        }
        return n;
    }
}
// 旧代码
// public class Solution {
//     public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4) {
//         Dictionary<int, int> dit1 = new Dictionary<int, int>();
//         Dictionary<int, int> dit2 = new Dictionary<int, int>();
//         for(int i=0; i<nums1.Length; i++){
//             for(int j=0; j<nums2.Length; j++){
//                 dit1.TryAdd((nums1[i]+nums2[j]), 0);
//                 dit1[(nums1[i]+nums2[j])]++;
//             }
//         }
//         for(int i=0; i<nums3.Length; i++){
//             for(int j=0; j<nums4.Length; j++){
//                 dit2.TryAdd((nums3[i]+nums4[j]), 0);
//                 dit2[(nums3[i]+nums4[j])]++;
//             }
//         }
//         int n = 0;
//         foreach(var obj in dit1){
//             if(dit2.ContainsKey(0-obj.Key)){
//                 n += obj.Value * dit2[0-obj.Key];
//             }
//         }
//         return n;
//     }
// }
  
