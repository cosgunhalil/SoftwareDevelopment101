
namespace SD101.Example.MVC 
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using System;

    public class FloorEventArgs : EventArgs 
    { 
        FloorData floorData { get; set; }
    }

    public interface IBuildingModel 
    {
        event EventHandler<EventArgs> OnNumberOfFloorsChanged;
        int NumberOfFloors { get; set; }

        void AddFloorData(FloorData floorData);
    }

    public class BuildingModel : IBuildingModel
    {
        public event EventHandler<EventArgs> OnNumberOfFloorsChanged;

        public List<FloorData> FloorDataList = new List<FloorData>();

        public int NumberOfFloors 
        { 
            get 
            { 
                return numberOfFloors; 
            }

            set 
            {
                numberOfFloors = value;

                var eventArgs = new EventArgs();
                OnNumberOfFloorsChanged(this, eventArgs);
            }
        }

        private int numberOfFloors;

        public void AddFloorData(FloorData floorData) 
        {
            FloorDataList.Add(floorData);
            NumberOfFloors++;
        }

        public void RemoveFloorData(int floorIndex) 
        {
            if (FloorDataList.Count == 0) 
            {
                return;
            }

            if (floorIndex < 0) 
            {
                return;
            }

            if (floorIndex > FloorDataList.Count - 1) 
            {
                return;
            }

            FloorDataList.RemoveAt(floorIndex);
        }
    }

    public struct FloorData 
    {
        public Vector3 Size;
    }
}
