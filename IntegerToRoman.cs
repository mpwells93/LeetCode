public class Solution {
    public string IntToRoman(int numValue) {
        string romanNumber = "";
        int thousands = 0;
        int fiveHundreds = 0;
        int hundreds = 0;
        int fifties = 0;
        int tens = 0;
        int fives = 0;
        int ones = 0;
        int loop;
    
        thousands = numValue / 1000;
        numValue %= 1000;
        fiveHundreds = numValue / 500;
        numValue %= 500;
        hundreds = numValue / 100;
        numValue %= 100;
        fifties = numValue / 50;
        numValue %= 50;
        tens = numValue / 10;
        numValue %= 10;
        fives = numValue / 5;
        numValue %= 5;
        ones = numValue;
    
        for (loop = 0; loop < thousands; loop++) {
          romanNumber += "M";
        }

        if (hundreds == 4) {
          if (fiveHundreds == 1) {
            romanNumber +=  "CM";
          }
          else {
            romanNumber +=  "CD";
          }
        }
        else {
          if (fiveHundreds == 1) {
            romanNumber +=  "D";
          }
      
          for (loop = 0; loop < hundreds; loop++) {
            romanNumber +=  "C";
          }
        }
      
        if (tens == 4) {
          if (fifties == 1) {
            romanNumber +=  "XC";
          }
          else {
            romanNumber +=  "XL";
          }
        }
        else {
          if (fifties == 1) {
            romanNumber +=  "L";
          }
      
          for (loop = 0; loop < tens; loop++) {
            romanNumber +=  "X";
          }
        }
      
        if (ones == 4) {
          if (fives == 1) {
            romanNumber +=  "IX";
          }
          else {
            romanNumber +=  "IV";
          }
        }
        else {
          if (fives == 1) {
            romanNumber +=  "V";
          }
      
          for (loop = 0; loop < ones; loop++) {
            romanNumber +=  "I";
          }
        }
        
        return romanNumber;
    }
}
