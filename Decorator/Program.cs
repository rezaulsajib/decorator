using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a bangladeshi mobile number with prefix: ");
            var value=Console.ReadLine();
            var validator=new BDPhoneNumberValidator( new PhoneNumberValidator(13,new NumberValidator()));
            validator.Validate(value);
        }
    }
}
