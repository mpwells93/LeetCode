class Solution {
    public boolean isNumber(String s) {
        boolean result = true;
        char[] charArray = s.trim().toCharArray();   
        boolean decimalFound = false;
        int ePosition = -1;
        int numPosition = -1;
        int eNumPosition = -1;
        
        for(int i=0; i < charArray.length && result; i++){
            if (charArray[i] >= '0' && charArray[i] <= '9') {
                // If there is an e then there needs to be a
                // number after the e
                if (ePosition > -1) {
                    if (i > ePosition) {
                        eNumPosition = i;
                    }
                }
                else {
                    numPosition = i;
                }
            }
            else if (charArray[i] == '+' || charArray[i] == '-') {
                // Sign needs to be first character or first
                // character after e
                if (i > 0 && i != (ePosition + 1)) {
                    result = false;
                }
            }
            else if (charArray[i] == '.') {
                if (decimalFound == false) {
                    // decimal not allowed after e
                    if (ePosition != -1) {
                        result = false;
                    }
                    else {
                        decimalFound = true;
                    }
                }
                else {
                    result = false;
                }
           }
           else if (charArray[i] == 'e') {
               // e cannot be in first position, and only one e allowed
               if (i > 0 && ePosition == -1) {
                   ePosition = i;
               }
               else {
                   result = false;
               }
           }
            else {
                // Getting here means an invalid character is in the string
                result = false;
            }
        }
        
        // Must have at least a number. Also, if there is an e then there
        // must be a number after it in a valid position
        if (numPosition == -1 || 
            (ePosition != -1 && eNumPosition == -1)) {
            result = false;
        }
        
        return result;
    }
}
