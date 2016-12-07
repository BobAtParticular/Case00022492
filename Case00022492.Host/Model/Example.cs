using System;
using Case00022492.Messages;
using NES;

namespace Case00022492.Host.Model
{
    public class Example : AggregateBase<Guid>
    {
        public Example(Guid id, DateTime created)
        {
            Apply<ExampleCreated>(evt =>
            {
                evt.Id = id;
                evt.Created = created;
            });
        }

        private Example()
        {

        }

        private void Handle(ExampleCreated @event)
        {
            Console.WriteLine($"Aggregate Example ExampleCreated handled for id {@event.Id} and created {@event.Created}");
            Id = @event.Id;
            LastCreated = @event.Created;
        }

        public DateTime LastCreated { get; set; }
    }
}
