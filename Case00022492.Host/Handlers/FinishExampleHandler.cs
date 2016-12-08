using System;
using Case00022492.Host.Model;
using Case00022492.Messages;
using NES.Contracts;
using NServiceBus;

namespace Case00022492.Host.Handlers
{
    public class FinishExampleHandler : IHandleMessages<FinishExample>
    {
        private readonly IRepository _repository;
        private readonly IBus _bus;

        public FinishExampleHandler(IRepository repository, IBus bus)
        {
            _repository = repository;
            _bus = bus;
        }

        public void Handle(FinishExample message)
        {
            Console.WriteLine($"FinishExample handled for Id {message.Id}");

            var example = _repository.Get<Example>(message.Id);

            Console.WriteLine($"Marking Example Id {message.Id} as Finished");

            example.Finish();

            _bus.Publish<ExampleFinished>(evt => evt.Id = message.Id);
        }
    }
}