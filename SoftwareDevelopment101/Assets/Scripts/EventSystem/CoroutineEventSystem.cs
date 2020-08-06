

namespace SD101.Services.Coroutine
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using SD101.Common.Observer;


    public class CoroutineEventSystem : ISubject<CoroutineEvent>
    {
        private List<SD101.Common.Observer.IObserver<CoroutineEvent>> observers = new List<SD101.Common.Observer.IObserver<CoroutineEvent>>();

        public void Register(Common.Observer.IObserver<CoroutineEvent> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unregister(Common.Observer.IObserver<CoroutineEvent> observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void AddEvent(CoroutineEvent eventArgs)
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Notify(this, eventArgs);
            }
        }
    }

    public class CoroutineEvent : EventArgs
    {
        public IEnumerator enumerator;
    }
}


