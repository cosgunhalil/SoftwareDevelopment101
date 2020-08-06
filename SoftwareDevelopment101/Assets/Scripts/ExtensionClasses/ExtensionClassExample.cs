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
        }
    }

    public static class ExtensionMethods
    {
        public static int CalculateArea(this Square square)
        {
            return square.a * square.a;
        }
    }

    public class Square
    {
        public int a;
    }
}


