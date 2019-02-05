public class Solution {
    public int FindCircleNum(int[,] M) {
        int groupCount = 0;
        
        for (int i = 0; i < M.GetLength(0); i++ ) {
            if (M[i,i] == 1) {
                groupCount++;
                MarkFriends(ref M, i);
            }
        }
        
        return groupCount;
    }  // FindCircleNum
    
    // Go through the loop removing references to freinds already counted.
    // This logic will make sure that the check in the FindCircleNum will
    // only find friend groups that do not share friends.
    private void MarkFriends(ref int[,] M, int index) {
        for (int i = 0; i < M.GetLength(1); i++) {
            if (i != index && M[index,i] == 1 && M[i, index] == 1) {
                M[index, i] = 0;
                M[i, index] = 0;
                
                // Recursively call method to check for friend chaining
                // and mark them as already counted in a group
                MarkFriends(ref M, i);
            }
        }
        
        M[index, index] = 0;
    }  // MarkFriends
}
