using System.Collections;
using System.Collections.Generic;


namespace SD101
{
    using UnityEngine;
    using SD101.Common;
    using SD101.Example.AbstaractClass;
    using SD101.Example.Conditions;
    using SD101.Example.ExtensionClass;
    using SD101.Example.Function;
    using SD101.Example.IENumerable;
    using SD101.Example.Interface;
    using SD101.Example.Loops;
    using SD101.Example.Nullable;
    using SD101.Example.BoxingUnboxing;
    using System;

    public class SD101MainComponent : MonoBehaviour
    {
        private List<IExample> examples = new List<IExample>();
        private BoxingUnboxingSample boxingUnboxingSample = new BoxingUnboxingSample();
        private ConditionsSample conditionsSample = new ConditionsSample();
        private LoopSample loopSample = new LoopSample();
        private FunctionExample functionExample = new FunctionExample();
        private NullableExample nullableExample = new NullableExample();
        private EnumerableExample enumeratorExample = new EnumerableExample();
        private InterfaceExample interfaceExample = new InterfaceExample();
        private AbstractClassExample abstractClassExample = new AbstractClassExample();
        private ExtensionClassExample extensionClassExample = new ExtensionClassExample();

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
            else if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                ExecuteExtensionClassExample();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha8))
            {
                ExecuteBoxingUnboxingExample();
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

        private void ExecuteExtensionClassExample()
        {
            extensionClassExample.Execute();
        }

        private void ExecuteBoxingUnboxingExample()
        {
            boxingUnboxingSample.Execute();
        }
    }
}


