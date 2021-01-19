
namespace SD101.Example.MVC 
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public interface IBuildingView 
    {
        event EventHandler<EventArgs> OnAddFloorClicked;
        event EventHandler<EventArgs> OnRemoveFloorClicked;

        void UpdateFloorCount(int floorCount);
    }

    public class BuildingView : MonoBehaviour, IBuildingView 
    {
        public event EventHandler<EventArgs> OnAddFloorClicked;
        public event EventHandler<EventArgs> OnRemoveFloorClicked;

        public void AddFloor() 
        {
            var eventArgs = new EventArgs();
            OnAddFloorClicked(this, eventArgs);
        }

        public void RemoveFloor() 
        {
            var eventArgs = new EventArgs();
            OnRemoveFloorClicked(this, eventArgs);
        }

        public void UpdateFloorCount(int floorCount)
        {
            //TODO: update floor count!
            Debug.Log("<color=green> CURRENT FLOOR COUNT: </color>" + floorCount);
        }
    }
}