using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace Case00022492.Host.Config
{
    class ConfigErrorQueue :
        IProvideConfiguration<MessageForwardingInCaseOfFaultConfig>
    {
        public MessageForwardingInCaseOfFaultConfig GetConfiguration()
        {
            return new MessageForwardingInCaseOfFaultConfig
            {
                ErrorQueue = "error"
            };
        }
    }
}
