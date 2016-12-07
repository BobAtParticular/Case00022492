using System;
using NES;
using NServiceBus;

namespace Case00022492.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Case00022492.Host";

            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Case00022492.Host");
            busConfiguration.Case00022492CommonConfig();

            busConfiguration.RegisterComponents(c =>
            {
                c.ConfigureComponent<Repository>(DependencyLifecycle.InstancePerUnitOfWork);
            });

            using (var bus = Bus.Create(busConfiguration).Start())
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
