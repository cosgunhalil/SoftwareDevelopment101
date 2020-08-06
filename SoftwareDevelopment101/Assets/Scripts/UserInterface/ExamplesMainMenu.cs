using System;
using System.Collections;
using System.Collections.Generic;
using SD101;
using SD101.Example.UserInterface;
using UnityEngine;

public class ExamplesMainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject exampleInputButtonPrefab;
    [SerializeField]
    private Transform buttonContainer;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateButtons();
    }

    private void InstantiateButtons()
    {
        for (int i = 0; i < (int)ExampleType.COUNT; i++)
        {
            var button = Instantiate(exampleInputButtonPrefab).GetComponent<ExampleInputButton>();
            button.Init();
            button.SetType((ExampleType)i);

            button.transform.localScale = new Vector3(1, 1, 1);
            button.transform.SetParent(buttonContainer);

        }
    }
}
