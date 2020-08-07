using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Example.Inheritence
{
    public class InheritenceExample : IExample
    {
        public void Execute()
        {
            new Fruit().Yell();
            new Orange().Yell();
            new Tomato().Yell();
        }
    }

    public class Fruit
    {
        public virtual void Yell()
        {
            Debug.Log("I am a Fruit!");
        }
    }

    public class Tomato : Fruit
    {
        public override void Yell()
        {
            Debug.Log("I am a Tomato!");
        }
    }

    public class Orange : Fruit
    {
        public override void Yell()
        {
            Debug.Log("I am an Orange!");
        }
    }
}


