using System;
namespace ABSA
{
    public class UserValidationViewModel
    {
        string number;
 
        public UserValidationViewModel(string number)
        {
            this.number = number;
        }

        public bool isNumberEmpty()
        {
            bool isEmptyString = this.number.Length == 0 ? true : false;
            return isEmptyString;
        }

        public bool isValidNumber()
        {
            string SA_Number = this.number.Trim(new Char[] { '.' });
            bool isValid = true;

            if (SA_Number.Length != 13 || this.number == "0000000000000") {
                isValid = false;
            }
            return isValid;
        }

    }
}
/*
1.) Add all the digits of the ID number in the odd positions(except for the last number, which is the control digit) :
2.) Take all the even digits as one number and multiply that by 2:
3.) Add the digits of this number together (in b)
4.) Add the answer of C to the answer of A
5.) Subtract the second character from D from 10, this number should now equal the control character
*/