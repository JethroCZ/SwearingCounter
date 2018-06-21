using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using SelfHosting.Implementation;
using SelfHosting.Interfaces;

namespace SelfHosting
{
    public class MyApp
    {
        private Uri m_baseAddress = new Uri("http://localhost:8080/hello");

        public void Run()
        {
            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(SelfHostingService), m_baseAddress))
            {
                // Enable metadata publishing.
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", m_baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}