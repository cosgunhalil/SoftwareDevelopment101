using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using SD101.Common.Observer;
using UnityEngine;

namespace SD101.Examples.BoxingUnboxing
{
    public class AdDataCollector : IObserver<SD101.Common.AdEvent>
    {
        private AdDataSender adDataSender = new AdDataSender(); // todo use dependency injection

        public void Init()
        {
            CentralEventManager.Instance.GetAdsEventManager().Register(this);
        }

        public void Destroy()
        {
            CentralEventManager.Instance.GetAdsEventManager().Unregister(this);
        }

        //todo handle
        public void Notify(object sender, Common.AdEvent e)
        {
            adDataSender.SendAdData(e.Type, (int)e.ExtraInfo);//unboxing
        }

    }

    public class AdDataSender
    {
        
        public void SendAdData(AdEventType type, int ecpm)
        {
            //send adData to some server in somewhere
            Debug.Log("Data Send: " + type.ToString() + " / " + ecpm);
        }
    }
}


