using System;

namespace Decorator
{
    class BDPhoneNumberValidator:Decorator
    {
        private const string Prefix = "88";
        public BDPhoneNumberValidator(Validator component) : base(component)
        {
            
        }
        public override bool Validate(string value)
        {
            if (!base.Validate(value))
            {
                return false;
            }

            var valid = value.StartsWith(Prefix);
            Console.WriteLine(!valid ? "Invalid Prefix" : "Valid Mobile Number");
            return valid;
        }
    }
}
