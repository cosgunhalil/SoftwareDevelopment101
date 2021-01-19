

namespace SD101.Example.MVC 
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class BuildingMVC : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            BuildingModel buildingModel = new BuildingModel();
            var buildingView = new GameObject("BuildingView").AddComponent<BuildingView>();

            BuildingController buildingController = new BuildingController(buildingModel, buildingView);

            buildingView.AddFloor();
            buildingView.AddFloor();
            buildingView.RemoveFloor();
        }
    }
}


