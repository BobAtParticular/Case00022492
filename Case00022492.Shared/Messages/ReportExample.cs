using System;
using NServiceBus;

namespace Case00022492.Messages
{
    public class ReportExample : ICommand
    {
        public Guid Id { get; set; }
    }
}
