using Microsoft.Practices.Unity;

namespace JsonParser
{
    class Program
    {
        static void Main(string[] args)
        {

            if (!Validation.ValidateArgs(args))
            {
                return;
            }
            var container = InitializeContainer();
            var displayer = container.Resolve<IDisplayer>();
            displayer.Display(args[0]);
        }

        private static UnityContainer InitializeContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IDisplayer, JsonMenuSumDisplayer>();
            return container;
        }
    }
}
