using System;

namespace Decorator
{
    public class PhoneNumberValidator : Decorator
    {
        private readonly int _numOfDigit;

        public PhoneNumberValidator(int numOfDigit, Validator component) : base(component)
        {
            _numOfDigit = numOfDigit;
        }

        public override bool Validate(string value)
        {
            if (!base.Validate(value))
            {
                return false;
            }

            var valid = _numOfDigit == value.Length;
            Console.WriteLine(!valid ? "Invalid number of digit" : "Valid number of digit");
            return valid;
        }
    }
}