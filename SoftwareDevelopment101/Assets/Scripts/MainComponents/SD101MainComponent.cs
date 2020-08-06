using System.Collections;
using System.Collections.Generic;


namespace SD101
{
    using System;
    using SD101.Common;
    using SD101.Example.Conditions;
    using SD101.Example.Function;
    using SD101.Example.IENumerable;
    using SD101.Example.Loops;
    using SD101.Example.Nullable;
    using UnityEngine;

    public class SD101MainComponent : MonoBehaviour
    {
        private List<IExample> examples = new List<IExample>();
        private ConditionsSample conditionsSample = new ConditionsSample();
        private LoopSample loopSample = new LoopSample();
        private FunctionExample functionExample = new FunctionExample();
        private NullableExample nullableExample = new NullableExample();
        private EnumerableExample enumeratorExample = new EnumerableExample();


        void Start()
        {
            SetupExamplesList();
        }

        private void SetupExamplesList()
        {
            //todo setup the examples list
            examples.Add(conditionsSample);
            examples.Add(loopSample);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ExecuteLoopsExample();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ExecuteFunctionExample();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                ExecuteEnumeratorExample();
            }
        }

        private void ExecuteLoopsExample()
        {
            loopSample.Execute();
        }

        private void ExecuteFunctionExample()
        {
            functionExample.Execute();
        }

        private void ExecuteEnumeratorExample()
        {
            enumeratorExample.Execute();
        }
    }
}


