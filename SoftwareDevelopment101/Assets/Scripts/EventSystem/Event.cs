
namespace SD101.Common
{
    using System;

    public class AdEvent : EventArgs
    {
        public AdEventType Type;
        public object ExtraInfo;
    }

    public enum AdEventType
    {
        INTERSTITIAL_AD_COMPLETED,
        REWARDED_AD_SKIPPED,
        REWARDED_AD_COMPLETED
    }
}
