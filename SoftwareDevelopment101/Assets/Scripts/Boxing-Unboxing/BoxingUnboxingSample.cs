using System.Collections;
using System.Collections.Generic;
using SD101.Services.Ads;
using UnityEngine;

namespace SD101.Examples.BoxingUnboxing
{
    public class BoxingUnboxingSample : MonoBehaviour
    {
        void Start()
        {
            AdDataSender dataSender = new AdDataSender();
            AdDataCollector adDataCollector = new AdDataCollector(dataSender);

            adDataCollector.Init();

            AdManager adManager = new AdManager();
            adManager.ShowRewarded();

            adDataCollector.Destroy();
        }
    }
}


