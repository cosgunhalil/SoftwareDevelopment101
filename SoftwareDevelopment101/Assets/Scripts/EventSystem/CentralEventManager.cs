
namespace SD101.Common
{
    using SD101.Services.Ads;
    using SD101.Services.Coroutine;

    public class CentralEventManager
    {
        private static readonly CentralEventManager instance = new CentralEventManager();

        private AdsEventSystem adsEventSystem = new AdsEventSystem();
        private CoroutineEventSystem coroutineEventSystem = new CoroutineEventSystem();

        static CentralEventManager()
        {

        }

        private CentralEventManager()
        {

        }

        public static CentralEventManager Instance
        {
            get
            {
                return instance;
            }
        }

        public AdsEventSystem GetAdsEventManager()
        {
            return adsEventSystem;
        }

        public CoroutineEventSystem GetCoroutineEventsManager()
        {
            return coroutineEventSystem;
        }
    }

}

