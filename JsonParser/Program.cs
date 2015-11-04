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
            InitializeContainer();
            var displayer = StaticContainer.Container.Resolve<IDisplayer>();
            displayer.Display(args[0]);
        }

        private static void InitializeContainer()
        {
            StaticContainer.Container.RegisterType<IDisplayer, JsonMenuSumDisplayer>();
        }
    }
}
