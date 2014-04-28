using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace validation.luhn10
{
    public class Luhn10 : IValidationAlgorithm
    {
        #region API Methods

        public bool Validate(string number)
        {
            if (IsNumber(number) == false)
                return false;

            if (CalculateChecksum(number) % 10 == 0)
                return true;

            return false;
        }

        public int CalculateCheckDigit(string number)
        {
            if (IsNumber(number) == false)
                return -1; // need better fail condition

            return CalculatePartialChecksum(number) * 9 % 10;
        }

        #endregion

        #region Helper Methods

        private bool IsNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d+$", RegexOptions.Compiled);
        }

        private int CalculateChecksum(string number)
        {
            return CalculatePartialChecksum(number.Remove(number.Length - 1))
                + (int)Char.GetNumericValue(number[number.Length - 1]);
        }

        private int CalculatePartialChecksum(string number)
        {
            int checksum = 0;

            for (int index = number.Length - 1; index >= 0; index--)
            {
                int digit =
                    (int)Char.GetNumericValue(number[index])
                    * ((number.Length - index) % 2 + 1);

                if (digit > 9)
                    digit = digit / 10 + digit % 10;

                checksum += digit;
            }

            return checksum;
        }

        #endregion
    }
}
