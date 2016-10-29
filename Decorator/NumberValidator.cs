using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Decorator
{
    public class NumberValidator : Validator
    {
        public override bool Validate(string value)
        {
            var regex = new Regex(@"^\d+$");
            var valid = regex.IsMatch(value);
            if (!valid)
                Console.WriteLine("Input string is not number");
            return valid;
        }
    }

}