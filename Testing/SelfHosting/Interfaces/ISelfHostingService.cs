using System.ServiceModel;

namespace SelfHosting.Interfaces
{
    [ServiceContract]
    public interface ISelfHostingService
    {
        [OperationContract]
        string SayHello(string name);
    }
}