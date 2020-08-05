using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using SD101.Common.Observer;
using UnityEngine;

namespace SD101.Example.BoxingUnboxing
{
    public class AdDataCollector : IObserver<SD101.Common.AdEvent>
    {
        private AdDataSender adDataSender;

        public AdDataCollector(AdDataSender dataSender)
        {
            adDataSender = dataSender;
        }

        public void Init()
        {
            CentralEventManager.Instance.GetAdsEventManager().Register(this);
        }

        public void Destroy()
        {
            CentralEventManager.Instance.GetAdsEventManager().Unregister(this);
        }

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


