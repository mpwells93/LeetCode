public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        
        for (int index = 0; index < nums.Length; index++) {
            for (int index2 = (nums.Length - 1); index2 > index; index2--) {
                if ((index != index2) &&
                    (nums[index] + nums[index2]) == target) {
                    answer[0] = index;
                    answer[1] = index2;
                    
                    // Only acceptable goto is breaking out of a loop and cleaning up resources as needed
                    goto cleanup;  
                }
            }
        }
                
        cleanup:
        
        return answer;
    }  // TwoSum
}  // end class Solution
