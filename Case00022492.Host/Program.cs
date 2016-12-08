using System;
using NES;
using NES.NEventStore;
using NEventStore;
using NServiceBus;

namespace Case00022492.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Case00022492.Host";

            var store = Wireup.Init()
                .UsingInMemoryPersistence()
                .EnlistInAmbientTransaction()
                .NES()
                .Build();

            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Case00022492.Host");
            busConfiguration.Case00022492CommonConfig();

            busConfiguration.RegisterComponents(c =>
            {
                c.ConfigureComponent<Repository>(DependencyLifecycle.InstancePerUnitOfWork);
                c.RegisterSingleton(store);
            });

            using (var bus = Bus.Create(busConfiguration).Start())
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
