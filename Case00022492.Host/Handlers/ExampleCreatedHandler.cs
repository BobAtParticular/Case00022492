﻿using System;
using Case00022492.Messages;
using NServiceBus;

namespace Case00022492.Host.Handlers
{
    public class ExampleCreatedHandler : IHandleMessages<ExampleCreated>
    {
        private readonly IBus _bus;

        public ExampleCreatedHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(ExampleCreated message)
        {
            Console.WriteLine($"ExampleCreated handled for Id {message.Id} created {message.Created}");

            _bus.SendLocal(new FinishExample
            {
                Id = message.Id
            });
        }
    }
}
