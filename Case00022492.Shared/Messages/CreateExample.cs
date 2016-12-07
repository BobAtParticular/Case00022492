using System;
using NServiceBus;

namespace Case00022492.Messages
{
    public class CreateExample : ICommand
    {
        public Guid Id { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
