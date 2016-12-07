using NES.NEventStore;
using NEventStore;
using NServiceBus;

namespace Case00022492.Host.Config
{
    public class NEventStoreStartup : IWantToRunWhenBusStartsAndStops
    {
        public void Start()
        {
            Wireup.Init()
                .UsingInMemoryPersistence()
                .EnlistInAmbientTransaction()
                .NES()
                .Build();
        }

        public void Stop()
        {
        }
    }
}
