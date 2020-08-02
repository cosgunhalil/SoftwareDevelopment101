
namespace SD101.Common
{
    using SD101.Services.Ads;

    public class CentralEventManager
    {
        private static readonly CentralEventManager instance = new CentralEventManager();

        private AdsEventSystem adsEventSystem = new AdsEventSystem();

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

        public AdsEventSystem GetUIStateEventManager()
        {
            return adsEventSystem;
        }
    }

}

