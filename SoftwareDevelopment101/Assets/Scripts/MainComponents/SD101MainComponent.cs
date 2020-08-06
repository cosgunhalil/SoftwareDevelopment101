using System.Collections;
using System.Collections.Generic;


namespace SD101
{
    using System;
    using SD101.Common;
    using SD101.Example.AbstaractClass;
    using SD101.Example.Conditions;
    using SD101.Example.Function;
    using SD101.Example.IENumerable;
    using SD101.Example.Interface;
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
        private InterfaceExample interfaceExample = new InterfaceExample();
        private AbstractClassExample abstractClassExample = new AbstractClassExample();


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
            else if(Input.GetKeyDown(KeyCode.Alpha4))
            {
                ExecuteInterfaceExample();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                ExecuteAbstractClassExample();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                ExecuteNullableExample();
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

        private void ExecuteInterfaceExample()
        {
            interfaceExample.Execute();
        }

        private void ExecuteAbstractClassExample()
        {
            abstractClassExample.Execute();
        }

        private void ExecuteNullableExample()
        {
            nullableExample.Execute();
        }
    }
}


