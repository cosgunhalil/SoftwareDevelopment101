using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
