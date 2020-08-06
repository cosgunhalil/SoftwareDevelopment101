

namespace SD101.Example.Nullable
{
    using UnityEngine;
    using SD101.Common;

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


