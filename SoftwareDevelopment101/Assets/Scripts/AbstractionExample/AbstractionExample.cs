
namespace SD101.Example.Abstraction
{
    using System;
    using SD101.Common;
    using UnityEngine;

    public class AbstractionExample : IExample
    {
        public void Execute()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Debug.Log(coffeeMachine.GetCoffee("cold brew"));

            Mathf.Pow(2,3);
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

}

