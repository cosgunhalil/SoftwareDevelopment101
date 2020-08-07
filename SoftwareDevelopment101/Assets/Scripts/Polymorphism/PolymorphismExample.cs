
namespace SD101.Example.Polymorphism
{
    using SD101.Common;
    using UnityEngine;

    public class PolymorphismExample : IExample
    {
        public void Execute()
        {
            Animal animal = new Dog();
            animal.Yell();
            
        }
    }

    public class Animal
    {
        public virtual void Yell()
        {
            Debug.Log("I am an animal!");
        }
    }

    public class Dog : Animal
    {
        public override void Yell()
        {
            Debug.Log("I am a dog!");
        }
    }

    public class Cat : Animal
    {
        public override void Yell()
        {
            Debug.Log("I am a cat!");
        }
    }
}


