using NES.NServiceBus;
using NServiceBus;
using NServiceBus.Config;

namespace Case00022492.Host.Config
{
    public class StartNES : IWantToRunWhenConfigurationIsComplete {
        public void Run(Configure config)
        {
            config.NES();
        }
    }
}