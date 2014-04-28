using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace validation.luhn10
{
    public interface IValidationAlgorithm
    {
        bool Validate(string number);
        int CalculateCheckDigit(string number);
    }
}
