using System;
using Case00022492.Messages;
using NEventStore;
using NServiceBus;

namespace Case00022492.Host.Handlers
{
    public class StreamExampleHandler : IHandleMessages<StreamExample>
    {
        private readonly IStoreEvents _store;

        public StreamExampleHandler(IStoreEvents store)
        {
            _store = store;
        }

        public void Handle(StreamExample message)
        {
            Console.WriteLine($"StreamExample handled for Id {message.Id}");

            using (var stream = _store.OpenStream(Bucket.Default, message.Id.ToString(), int.MinValue, int.MaxValue))
            {
                foreach (var @event in stream.CommittedEvents)
                {
                    Console.Write($"Event: {@event.Body}");
                }
            }
        }
    }
}