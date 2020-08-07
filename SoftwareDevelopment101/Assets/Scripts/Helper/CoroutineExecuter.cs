using System;
using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using SD101.Services.Coroutine;
using UnityEngine;

public class CoroutineExecuter : MonoBehaviour, SD101.Common.Observer.IObserver<CoroutineEvent>
{
    private void Start()
    {
        CentralEventManager.Instance.GetCoroutineEventsManager().Register(this);      
    }

    private void OnDestroy()
    {
        CentralEventManager.Instance.GetCoroutineEventsManager().Unregister(this);
    }

    public void Notify(object sender, CoroutineEvent e)
    {
        StartCoroutine(e.enumerator);
    }
}
