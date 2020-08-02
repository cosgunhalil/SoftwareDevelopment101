using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Services.Ads
{
    public class AdManager
    {
        public void ShowRewarded()
        {
            AdEvent rewardedAdCompletedEvent = new AdEvent
            {
                Type = AdEventType.REWARDED_AD_COMPLETED,
                ExtraInfo = 5
            };

            CentralEventManager.Instance.GetAdsEventManager().AddEvent(rewardedAdCompletedEvent);
        }

        public void ShowInterstitial()
        {
            AdEvent interstitialAdCompletedEvent = new AdEvent
            {
                Type = AdEventType.INTERSTITIAL_AD_COMPLETED,
                ExtraInfo = 1 //boxing
            };

            CentralEventManager.Instance.GetAdsEventManager().AddEvent(interstitialAdCompletedEvent);
        }
    }

    public struct AdInfo
    {
        public float Ecpm;
        public string Network;
    }
}


