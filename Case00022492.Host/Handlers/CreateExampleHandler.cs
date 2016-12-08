using System;
using Case00022492.Host.Model;
using Case00022492.Messages;
using NES.Contracts;
using NServiceBus;

namespace Case00022492.Host.Handlers
{
    public class CreateExampleHandler : IHandleMessages<CreateExample>
    {
        private readonly IRepository _repository;

        public CreateExampleHandler(IRepository repository)
        {
            _repository = repository;
        }

        public void Handle(CreateExample message)
        {
            Console.WriteLine($"CreateExample Command Handled for {message.Id} created {message.Created}");
            var example = _repository.Get<Example>(message.Id);
            if (example == null)
            {
                _repository.Add(new Example(message.Id, message.Created));
            }
        }
    }
}
