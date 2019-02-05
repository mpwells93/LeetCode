    public class Solution
    {
        string[] digitArray = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };  // Empty string because of zero based array
        string[] tensAmoutArray = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };  // Empty string because of zero based array and ten amount is a special case
        string[] tensArray = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

        static int Thousand = 1000;
        static int Million = 1000000;
        static int Billion = 1000000000;

        public string NumberToWords(int num)
        {
            string numberString = "";

            if ((num / Billion) > 0)
            {
                numberString = CreateHundredsStr(num / Billion);
                numberString += " Billion";
            }

            num %= Billion;

            if ((num / Million) > 0)
            {
                if (numberString != "")
                {
                    numberString += " ";
                }

                numberString += CreateHundredsStr(num / Million);
                numberString += " Million";
            }

            num %= Million;

            if ((num / Thousand) > 0)
            {
                if (numberString != "")
                {
                    numberString += " ";
                }

                numberString += CreateHundredsStr(num / Thousand);
                numberString += " Thousand";
            }

            num %= Thousand;

            if (num > 0)
            {
                if (numberString != "")
                {
                    numberString += " ";
                }

                numberString += CreateHundredsStr(num);
            }
            else
            {
                if (numberString == "")
                {
                    numberString = "Zero";
                }
            }

            return numberString;
        }  // NumberToWords

        private string CreateHundredsStr(int number)
        {
            string result = "";
            int digit = number / 100;

            if (digit > 0)
            {
                result = digitArray[digit] + " Hundred";

                digit = (number % 100);
            }

            digit = number % 100;

            if (digit > 9)
            {
                if (result != "")
                {
                    result += " ";
                }

                result += NumberToStr(digit);
            }
            else if (digit > 0 || (digit == 0 && result == ""))
            {
                if (result != "")
                {
                    result += " ";
                }

                result += digitArray[digit];
            }

            return result;
        }  // CreateHundredsStr

        private string NumberToStr(int digit)
        {
            string result = "";

            if (digit > 19)
            {
                result = tensAmoutArray[(digit / 10)];

                if ((digit % 10) > 0)
                {
                    result = result + " " + digitArray[(digit % 10)];
                }
            }
            else
            {  // Ten's digit is special case between 10 and 19
                if (result != "")
                {
                    result += " ";
                }

                result += tensArray[(digit % 10)];
            }

            return result;
        }  //  NumberToStr

    }  // end class Solution
