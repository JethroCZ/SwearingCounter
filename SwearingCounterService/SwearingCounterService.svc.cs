using System;
using SwearingCounter.Shared;

namespace SwearingCounterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SwearingCounterService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SwearingCounterService.svc or SwearingCounterService.svc.cs at the Solution Explorer and start debugging.
    public class SwearingCounterService : ISwearingCounterService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
