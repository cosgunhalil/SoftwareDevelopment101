

namespace SD101.Services.Input
{
    using System;
    using System.Collections.Generic;
    using SD101.Common.Observer;

    public class ExampleInputEventSystem : ISubject<ExampleInputEvent>
    {
        private List<SD101.Common.Observer.IObserver<ExampleInputEvent>> observers = new List<Common.Observer.IObserver<ExampleInputEvent>>();

        public void Register(Common.Observer.IObserver<ExampleInputEvent> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unregister(Common.Observer.IObserver<ExampleInputEvent> observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void AddEvent(ExampleInputEvent eventArgs)
        {
            //DATA_TYPE Event burada!
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Notify(this, eventArgs); //SD101MainComponent de burada!
            }
        }
    }

    public class ExampleInputEvent : EventArgs
    {
        private ExampleType exampleType;

        public ExampleInputEvent(ExampleType type)
        {
            exampleType = type;
        }

        public ExampleType GetEventType()
        {
            return exampleType;
        }
    }

}

