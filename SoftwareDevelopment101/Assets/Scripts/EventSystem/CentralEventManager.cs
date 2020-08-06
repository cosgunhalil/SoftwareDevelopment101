
namespace SD101.Common
{
    using SD101.Services.Ads;
    using SD101.Services.Coroutine;
    using SD101.Services.Input;

    public class CentralEventManager
    {
        private static readonly CentralEventManager instance = new CentralEventManager();

        private AdsEventSystem adsEventSystem = new AdsEventSystem();
        private CoroutineEventSystem coroutineEventSystem = new CoroutineEventSystem();
        private ExampleInputEventSystem exampleInputSystem = new ExampleInputEventSystem();

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

        public ExampleInputEventSystem GetExampleInputEventSystem()
        {
            return exampleInputSystem;
        }
    }

}

