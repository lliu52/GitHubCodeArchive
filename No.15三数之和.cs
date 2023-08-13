public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        if(nums.Length < 3){
            return null;
        }
        Array.Sort(nums);
        for(int i=0; i<nums.Length-2; i++){
            if (i > 0 && nums[i] == nums[i - 1]) {
                    continue;
            } // 去重i
            int left = i+1;
            int right = nums.Length-1;
            while(left<right){
                if((nums[left]+nums[right]>(0-nums[i]))){
                    right--;
                    while(nums[right]==nums[right+1] && right>left){
                        right--;
                    }
                }else if((nums[left]+nums[right]<(0-nums[i]))){
                    left++;
                    while(nums[left]==nums[left-1] && left<right){
                        left++;
                    }
                }else{
                    result.Add(new int[]{nums[i], nums[left], nums[right]});
                    left++;
                    right--;
                    while(nums[right]==nums[right+1] && right>left){
                        right--;
                    }
                    while(nums[left]==nums[left-1] && left<right){
                        left++;
                    }
                }
            }
        }
        return result;
    }
}
