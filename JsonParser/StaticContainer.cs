using Microsoft.Practices.Unity;

namespace JsonParser
{
    public class StaticContainer
    {
        private static UnityContainer _container;

        public static UnityContainer Container
        {
            get
            {
                if (_container != null)
                {
                    return _container;
                }
                _container = new UnityContainer();
                return _container;
            }
        }
    }
}