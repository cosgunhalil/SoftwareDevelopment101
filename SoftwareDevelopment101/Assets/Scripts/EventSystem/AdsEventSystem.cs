using System.Collections;
using System.Collections.Generic;
using SD101.Common.Observer;
using UnityEngine;

public class AdsEventSystem : ISubject<SD101.Common.Event>
{
    private List<IObserver<SD101.Common.Event>> observers = new List<IObserver<SD101.Common.Event>>();

    public void Register(IObserver<SD101.Common.Event> observer)
    {
        if (!observers.Contains(observer))
        {
            observers.Add(observer);
        }
    }

    public void UnRegister(IObserver<SD101.Common.Event> observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void AddEvent(SD101.Common.Event eventArgs)
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].Notify(this, eventArgs);
        }
    }
}
