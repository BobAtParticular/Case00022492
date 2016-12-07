using NServiceBus;

namespace Case00022492
{
    public static class CommonNServiceBusConfig
    {
        public static BusConfiguration Case00022492CommonConfig(this BusConfiguration config)
        {
            config.UseSerialization<JsonSerializer>();
            config.EnableInstallers();
            config.UsePersistence<InMemoryPersistence>();

            return config;
        }
    }
}
