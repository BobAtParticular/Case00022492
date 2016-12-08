using System;
using NServiceBus;

namespace Case00022492.Messages
{
    public class StreamExample : ICommand
    {
        public Guid Id { get; set; }
    }
}
