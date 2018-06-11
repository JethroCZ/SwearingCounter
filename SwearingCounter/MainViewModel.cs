using System;
using System.ServiceModel;
using SwearingCounter.Shared;

namespace SwearingCounter
{
    public class MainViewModel
    {
        ServiceHost m_host = new ServiceHost(typeof(ISwearingCounterService));

        public void StartHost()
        {
            m_host.Open();
        }

        public void StopHost()
        {
            m_host.Close();
        }
    }
}