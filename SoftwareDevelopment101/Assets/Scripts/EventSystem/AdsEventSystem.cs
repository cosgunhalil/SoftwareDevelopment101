
namespace SD101.Services.Ads
{
    using System.Collections.Generic;
    using SD101.Common.Observer;

    public class AdsEventSystem : ISubject<SD101.Common.AdEvent>
    {
        private List<IObserver<SD101.Common.AdEvent>> observers = new List<IObserver<SD101.Common.AdEvent>>();

        public void Register(IObserver<SD101.Common.AdEvent> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unregister(IObserver<SD101.Common.AdEvent> observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void AddEvent(SD101.Common.AdEvent eventArgs)
        {
            for (int i = 0; i < observers.Count; i++)
            {
                observers[i].Notify(this, eventArgs);
            }
        }
    }

}

