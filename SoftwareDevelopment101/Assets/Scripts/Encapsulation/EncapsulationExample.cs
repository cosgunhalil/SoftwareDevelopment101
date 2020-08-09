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
            SomeObject obj = new SomeObject(1);
            obj.SetId(1245);

            Debug.Log("SomeObject Id = " + new SomeObject(1).GetId());
        }
    }

    public class SomeObject
    {
        private int id;//encapsulated field

        public SomeObject(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }
    }
    
}


