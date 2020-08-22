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
    using SD101.Example.Polymorphism;
    using SD101.Example.Abstraction;
    using SD101.Example.SingleResponsibility;
    using SD101.Example.OpenClosedPrinciple;
    using SD101.Example.LiskovSubstition;
    using SD101.Example.DependencyInversion;

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
            { ExampleType.ENCAPSULATION, new EncapsulationExample()},
            { ExampleType.POLYMORPHISM, new PolymorphismExample()},
            { ExampleType.ABSTRACTION, new AbstractionExample()},
            { ExampleType.SINGLE_RESPONSIBILTY, new SingleResponsibilityExample()},
            { ExampleType.OPEN_CLOSED_PRINCIPLE, new OpenClosedPrinciple()},
            { ExampleType.LISKOV_PRINCIPLE, new LiskovSubstitionPrinciple()},
            { ExampleType.DEPENDENCY_INVERSION, new DependencyInversion()}
        };

        private void Start()
        {
            //userdan input gelirse haberdar olmalıyım. O yüzden de register olayım.
            CentralEventManager.Instance.GetExampleInputEventSystem().Register(this);
        }

        private void OnDestroy()
        {
            CentralEventManager.Instance.GetExampleInputEventSystem().Unregister(this);
        }

        //DATA_TYPE
        public void Notify(object sender, ExampleInputEvent e)
        {
            //DATA_TYPE
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
        POLYMORPHISM,
        ABSTRACTION,
        SINGLE_RESPONSIBILTY,
        OPEN_CLOSED_PRINCIPLE,
        LISKOV_PRINCIPLE,
        DEPENDENCY_INVERSION,
        COUNT
    }
}


