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
    using SD101.Example.DataTypes;
    using SD101.Services.Input;
    using SD101.Example.Inheritence;
    using SD101.Example.Encapsulation;

    public class SD101MainComponent : MonoBehaviour, SD101.Common.Observer.IObserver<ExampleInputEvent>
    {
        private Dictionary<ExampleType, IExample> exampleDictionary = new Dictionary<ExampleType, IExample>
        {
            { ExampleType.DATA_TYPE, new DataTypeSample() },
            { ExampleType.NULLABLE, new NullableExample() },
            { ExampleType.BOXING_UNBOXING, new BoxingUnboxingSample() },
            { ExampleType.CONDITIONS, new ConditionsSample() },
            { ExampleType.LOOPS, new LoopSample() },
            { ExampleType.FUNCTIONS, new FunctionExample() },
            { ExampleType.ENUMERABLE, new EnumerableExample() },
            { ExampleType.INTERFACE, new InterfaceExample() },
            { ExampleType.ABSTRACT_CLASS, new AbstractClassExample() },
            { ExampleType.EXTENSION_CLASS, new ExtensionClassExample() },
            { ExampleType.INHERITENCE, new InheritenceExample()},
            { ExampleType.ENCAPSULATION, new EncapsulationExample()}


        };

        private void Start()
        {
            CentralEventManager.Instance.GetExampleInputEventSystem().Register(this);
        }

        private void OnDestroy()
        {
            CentralEventManager.Instance.GetExampleInputEventSystem().Unregister(this);
        }

        public void Notify(object sender, ExampleInputEvent e)
        {
            exampleDictionary[e.GetEventType()].Execute();
        }
    }

    public enum ExampleType
    {
        DATA_TYPE,
        NULLABLE,
        BOXING_UNBOXING,
        CONDITIONS,
        LOOPS,
        FUNCTIONS,
        ENUMERABLE,
        INTERFACE,
        ABSTRACT_CLASS,
        EXTENSION_CLASS,
        INHERITENCE,
        ENCAPSULATION,
        COUNT
    }
}


