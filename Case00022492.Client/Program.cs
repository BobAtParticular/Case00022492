using System;
using Case00022492.Messages;
using NServiceBus;

namespace Case00022492.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Case00022492.Client";

            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Case00022492.Client");
            busConfiguration.Case00022492CommonConfig();

            using (var bus = Bus.CreateSendOnly(busConfiguration))
            {
                ConsoleKeyInfo cki;
                var id = Guid.NewGuid();
                Console.WriteLine("Press 1 to Send a Command");
                Console.WriteLine("Press ESC to stop");
                do
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key.ToString() != "D1" && cki.Key.ToString() != "NumPad1") continue;

                    var command = new CreateExample
                    {
                        Id = id
                    };

                    bus.Send("Case00022492.Host", command);
                    Console.WriteLine($"CreateExample sent for Id {command.Id} created {command.Created}");
                } while (cki.Key != ConsoleKey.Escape);
            }
        }
    }
}
