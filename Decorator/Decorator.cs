namespace Decorator
{
    public abstract class Decorator : Validator
    {
        protected Validator Component;

        protected Decorator(Validator component)
        {
            Component = component;
        }


        public override bool Validate(string value)
        {
            return Component.Validate(value);
        }
    }
}