class Solution {
    String digitWordArray[] = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
    String tensWordArray[] = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
    String tenSpecialArray[] = {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};

    // Class defined in the test to convert an integer number into the word equivalent.
    // parameter: num is the integer number to be converted.
    // return: a string representation of the number in words.
    public String numberToWords(int num) {
        String numberWord = "";
        int[] digitArray = new int[10]; 
        int dividen = 0;
        int remainder = 0;
        int power = 0;
        
        if (num > 0) {
            // The digits are parsed from left to right to simplify the calculation of the 
            // power variable.
            for (int exp = 9; exp > -1; exp--) {
                power = (int)Math.pow(10, exp);
                dividen = num / power;
                num = num % power;
                
                if (dividen > 0) {
                    digitArray[exp] = dividen;
                }
            }
            
            // Add Billions
            if (digitArray[9] != 0) {
                numberWord = digitWordArray[digitArray[9]] + " Billion ";
            }
            
            // Add Millions
            if (digitArray[8] != 0 || digitArray[7] != 0 || digitArray[6] != 0) {
                numberWord += hundredsWords(digitArray, 8) + " Million ";
            }
            
            // Add Thousands
            if (digitArray[5] != 0 || digitArray[4] != 0 || digitArray[3] != 0) {
                numberWord += hundredsWords(digitArray, 5) + " Thousand ";
            }
            
            // Add Hundreds
            if (digitArray[2] != 0 || digitArray[1] != 0 || digitArray[0] != 0) {
                numberWord += hundredsWords(digitArray, 2);
            }
        }
        else {
            numberWord = "Zero";
        }

        return numberWord.trim();
    }  // numberToWords
 
    // This method breaks down the three digits that make up a hundreds group.
    // It is used multiple time in the millions, thousands and hundreds area.
    // parameter: digitArray is the whole array of digits parsed by the 
    //            numberToWords method.
    // parameter: index is the starting index in the digitArray to parse for
    //            the hundreds words.
    // return: The string wording of the hundreds digits.
    String hundredsWords(int[] digitArray, int index) {
        String word = "";
        
        if (digitArray[index] > 0) {
            word = digitWordArray[digitArray[index]] + " Hundred ";
        }
        
        if (digitArray[index - 1] > 1) {
            word += tensWordArray[digitArray[index - 1]] + " ";
        }
        else {  // special case
            if (digitArray[index - 1] == 1) {
                
                word += tenSpecialArray[digitArray[index - 2]] + " ";
            }
        }  
                        
        if (digitArray[index - 1] != 1) {
            word += digitWordArray[digitArray[index - 2]];
        }
        
        return word.trim();
    }  // hundredsWords
}  // end class Solution
