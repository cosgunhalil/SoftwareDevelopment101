
namespace SD101.Example.Abstraction
{
    using System;
    using SD101.Common;
    using UnityEngine;

    public class AbstractionExample : IExample
    {
        public void Execute()
        {

            ExecuteExample1();
            ExecuteExample2();

        }

        private void ExecuteExample1()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Debug.Log(coffeeMachine.GetCoffee("cold brew"));

            Mathf.Pow(2, 3);
        }

        private void ExecuteExample2()
        {
            BuildingBuilder buildingBuilder = new BuildingBuilder();
            var building = buildingBuilder.GetBuilding(BuildingType.Home);
        }
    }

    public class CoffeeMachine
    {
        private Coffee coffee;

        public Coffee GetCoffee(string coffeeCode)
        {

            SetupColdWater();
            AddCoffeeInTheColdWater();
            CompleteCoffee();

            return coffee;
        }

        private void SetupColdWater()
        {
            Debug.Log("COLD WATER!");
        }

        private void AddCoffeeInTheColdWater()
        {
            Debug.Log("COFFEE IS ADDED");
        }

        private void CompleteCoffee()
        {
            coffee = new Coffee("Cold Brew");
        }
    }

    public class Coffee
    {
        private string name;

        public Coffee(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }

    public class BuildingBuilder
    {
        private Building building;

        public Building GetBuilding(BuildingType buildingType)
        {
            SetupWalls();
            PrepereBuilding();
            CreateMeshes();
            CreateWindows();
            CreateDoor();

            return building;
        }

        private void SetupWalls()
        {
            Debug.Log("SetupWalls");
        }

        private void PrepereBuilding()
        {
            Debug.Log("PrepereBuilding");
        }

        private void CreateMeshes()
        {
            Debug.Log("CreateMeshes");
        }

        private void CreateWindows()
        {
            Debug.Log("CreateWindows");
        }

        private void CreateDoor()
        {
            Debug.Log("CreateDoor");
        }
    }

    public class Building
    {
        private int id;

        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }

    }

    public enum BuildingType
    {
        Barrack,
        Port,
        Home
    }

}

