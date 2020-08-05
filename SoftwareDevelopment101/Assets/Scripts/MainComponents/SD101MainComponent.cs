using System.Collections;
using System.Collections.Generic;


namespace SD101
{
    using System;
    using SD101.Common;
    using SD101.Example.Conditions;
    using SD101.Example.Loops;
    using UnityEngine;

    public class SD101MainComponent : MonoBehaviour
    {
        private List<IExample> examples = new List<IExample>();
        private ConditionsSample conditionsSample = new ConditionsSample();
        private LoopSample loopSample = new LoopSample();
        // Start is called before the first frame update
        void Start()
        {
            SetupExamplesList();
        }

        private void SetupExamplesList()
        {
            examples.Add(conditionsSample);
            examples.Add(loopSample);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ExecuteLoopsExample();
            }
        }

        private void ExecuteLoopsExample()
        {
            loopSample.Execute();
        }
    }
}


