using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace Case00022492.Host.Config
{
    class ConfigRecoverability :
        IProvideConfiguration<TransportConfig>,
        IProvideConfiguration<SecondLevelRetriesConfig>
    {
        public TransportConfig GetConfiguration()
        {
            return new TransportConfig
            {
                MaxRetries = 1
            };
        }

        SecondLevelRetriesConfig IProvideConfiguration<SecondLevelRetriesConfig>.GetConfiguration()
        {
            return new SecondLevelRetriesConfig
            {
                Enabled = false
            };
        }
    }
}
