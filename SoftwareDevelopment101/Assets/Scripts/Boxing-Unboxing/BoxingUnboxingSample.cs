

namespace SD101.Example.BoxingUnboxing
{
    using SD101.Common;
    using SD101.Services.Ads;

    public class BoxingUnboxingSample : IExample
    {
        public void Execute()
        {
            //Inject AdDataSender to AdDataCollector
            AdDataSender dataSender = new AdDataSender();
            AdDataCollector adDataCollector = new AdDataCollector(dataSender);

            adDataCollector.Init();

            AdManager adManager = new AdManager();
            adManager.ShowRewarded();

            adDataCollector.Destroy();
        }
    }
}


