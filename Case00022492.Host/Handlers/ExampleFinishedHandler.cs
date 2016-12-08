using System;
using Case00022492.Messages;
using NServiceBus;

namespace Case00022492.Host.Handlers
{
    public class ExampleFinishedHandler : IHandleMessages<ExampleFinished>
    {
        private readonly IBus _bus;

        public ExampleFinishedHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(ExampleFinished message)
        {
            Console.WriteLine($"Example finished handled for Id {message.Id}");

            _bus.SendLocal(new StreamExample
            {
                Id = message.Id
            });
        }
    }
}