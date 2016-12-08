using System;
using NServiceBus;

namespace Case00022492.Messages
{
    public class ExampleFinished : IEvent
    {
        public Guid Id { get; set; }
    }
}