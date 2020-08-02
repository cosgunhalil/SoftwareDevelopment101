using System.Collections;
using System.Collections.Generic;
using SD101.Services.Ads;
using UnityEngine;

namespace SD101.Examples.BoxingUnboxing
{
    public class BoxingUnboxingSample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            AdDataCollector adDataCollector = new AdDataCollector();
            adDataCollector.Init();

            AdManager adManager = new AdManager();
            adManager.ShowRewarded();

            adDataCollector.Destroy();
        }
    }
}


