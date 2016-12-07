using System;
using NServiceBus;

namespace Case00022492.Messages
{
    public class ExampleCreated : IEvent
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; }
    }
}
