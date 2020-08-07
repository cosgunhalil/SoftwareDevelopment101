using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Example.Encapsulation
{
    public class EncapsulationExample : IExample
    {
        public void Execute()
        {
            Debug.Log("SomeObject Id = " + new SomeObject().GetId());
        }
    }

    public class SomeObject
    {
        private int id;//encapsulated field

        public int GetId()
        {
            return id;
        }
    }
    
}


