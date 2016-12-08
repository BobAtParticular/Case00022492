using System;
using NServiceBus;

namespace Case00022492.Messages
{
    public class FinishExample : ICommand
    {
        public Guid Id { get; set; }
    }
}
