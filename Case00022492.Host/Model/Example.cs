using System;
using Case00022492.Messages;
using NES;

namespace Case00022492.Host.Model
{
    public class Example : AggregateBase<Guid>
    {
        private bool _finished;

        public Example(Guid id, DateTime created)
        {
            Console.WriteLine($"Applying ExampleCreated for {id}");
            Apply<ExampleCreated>(evt =>
            {
                evt.Id = id;
                evt.Created = created;
            });
        }

        public void Finish()
        {
            Console.WriteLine($"Applying ExampleFinished for {Id}");
            Apply<ExampleFinished>(evt =>
            {
                evt.Id = Id;
            });
        }

        private Example()
        {
            Console.WriteLine($"Initialized Example Aggregate");
        }

        private void Handle(ExampleCreated @event)
        {
            Id = @event.Id;
            LastCreated = @event.Created;
            Console.WriteLine($"Applied ExampleCreated to Example Aggregate {Id}");
        }

        private void Handle(ExampleFinished @event)
        {
            Finished = true;
            Console.WriteLine($"Applied ExampleFinished to Example Aggregate {Id}");
        }

        public DateTime LastCreated { get; set; }

        public bool Finished { get; set; }
    }
}
