
namespace SD101.Example.AbstaractClass
{
    using UnityEngine;
    using SD101.Common;

    public class AbstractClassExample : IExample
    {
        public void Execute()
        {
            //Animal animal = new Animal();
            Golden golden = new Golden();
            golden.Bark();
            golden.Survive();
        }
    }

    public class Golden : Dog
    {
        public override void Bark()
        {
            Debug.Log("Golden barks!");
        }

        public override void Survive()
        {
            Debug.Log("Golden survives!");
        }
    }

    public abstract class Dog : Animal
    {
        public abstract void Bark();
    }

    public abstract class Animal
    {
        protected int id;
        public abstract void Survive();
    }
}


