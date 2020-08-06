using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace SD101.Example.UserInterface
{
    using LB.SuperUI.BaseComponents;
    using SD101.Common;

    public class ExampleInputButton : LB_Button
    {
        private ExampleType type;
        [SerializeField]
        private TMPro.TextMeshProUGUI textContainer;

        public void SetType(ExampleType type)
        {
            this.type = type;
            SyncView();
        }

        private void SyncView()
        {
            textContainer.text = type.ToString();
        }

        protected override void OnPointerDown()
        {
            CentralEventManager.Instance.GetExampleInputEventSystem().AddEvent(new Services.Input.ExampleInputEvent(type));
        }
    }
}


