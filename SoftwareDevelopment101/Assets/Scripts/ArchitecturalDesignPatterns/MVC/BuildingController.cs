
namespace SD101.Example.MVC 
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public interface IBuildingController 
    { 
        
    }

    public class BuildingController : IBuildingController
    {
        private IBuildingModel buildingModel;
        private IBuildingView buildingView;

        private BuildingController()
        {
            
        }

        public BuildingController(IBuildingModel model, IBuildingView view) 
        {
            buildingModel = model;
            buildingView = view;

            model.OnNumberOfFloorsChanged += Model_OnNumberOfFloorsChanged;
            view.OnAddFloorClicked += View_OnAddFloorClicked;
            view.OnRemoveFloorClicked += View_OnRemoveFloorClicked;
        }

        private void Model_OnNumberOfFloorsChanged(object sender, System.EventArgs e)
        {
            buildingView.UpdateFloorCount(buildingModel.NumberOfFloors);
        }

        private void View_OnAddFloorClicked(object sender, EventArgs e)
        {
            buildingModel.AddFloorData(new FloorDataGenerator().generateRandomFloorData());
            buildingModel.NumberOfFloors++;
        }


        private void View_OnRemoveFloorClicked(object sender, System.EventArgs e)
        {
            if (buildingModel.NumberOfFloors == 0)
            {
                return;
            }

            buildingModel.NumberOfFloors--;

            
        }


    }
}
