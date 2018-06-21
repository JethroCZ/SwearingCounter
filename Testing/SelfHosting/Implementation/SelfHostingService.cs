using SelfHosting.Interfaces;

namespace SelfHosting.Implementation
{
    public class SelfHostingService : ISelfHostingService
    {
        public string SayHello(string name)
        {
            return $"Hello, {name}";
        }
    }
}