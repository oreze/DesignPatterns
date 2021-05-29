namespace ConsoleApp1.Mediator
{
    public class Component
    {
        protected readonly Mediator _mediator;

        public Component(Mediator mediator)
        {
            _mediator = mediator;
        }
    }
}