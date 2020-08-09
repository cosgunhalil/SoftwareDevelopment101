using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Example.ExtensionClass
{
    public class ExtensionClassExample : IExample
    {
        public void Execute()
        {
            Square square = new Square() {

                a = 10

            };

            Debug.Log("area of the square = " + square.CalculateArea());

            List<string> nameList = new List<string> {
                "Bob",
                "Elvis",
                "Ali",
                "Mehmet",
                "Tanınmış Kişi"
            };

            Debug.Log(nameList.GetRandomMember());
        }
    }

    public static class ExtensionMethods
    {
        public static int CalculateArea(this Square square)
        {
            return square.a * square.a;
        }

        public static T GetRandomMember<T>(this List<T> list)
        {
            int random = UnityEngine.Random.Range(0, list.Count);
            return list[random];
        }
    }

    public class Square
    {
        public int a;
    }
}


