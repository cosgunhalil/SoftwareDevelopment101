using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Example.Nullable
{
    public class NullableExample : IExample
    {
        private int? nullableInt = null;

        public void Execute()
        {
            if (nullableInt == null)
            {
                Debug.Log("nullable int is null!");
            }
        }
    }
}


