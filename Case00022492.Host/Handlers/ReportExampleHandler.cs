using System;
using Case00022492.Host.Model;
using Case00022492.Messages;
using NES.Contracts;
using NServiceBus;

namespace Case00022492.Host.Handlers
{
    public class ReportExampleHandler : IHandleMessages<ReportExample>
    {
        private readonly IRepository _repository;

        public ReportExampleHandler(IRepository repository)
        {
            _repository = repository;
        }

        public void Handle(ReportExample message)
        {
            var example = _repository.Get<Example>(message.Id);

            Console.WriteLine($"Example from repository with Id {example.Id} and LastCreated {example.LastCreated} retrieved");
        }
    }
}