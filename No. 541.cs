public class Solution {
    public string ReverseStr(string s, int k) {
        char[] result = s.ToCharArray();
        for(int i=0; i<s.Length; i+=2*k){
            if((i+k)>s.Length){
                helper(result, i, s.Length-1);
                break;
            }else{
                helper(result, i, i+k-1);
            }
        }
        return new string(result);
    }
    public void helper(char[] result, int i, int j){
        while(i<j){
            char temp = result[i];
            result[i] = result[j];
            result[j] = temp;
            i++;
            j--;
        }
    }
}
