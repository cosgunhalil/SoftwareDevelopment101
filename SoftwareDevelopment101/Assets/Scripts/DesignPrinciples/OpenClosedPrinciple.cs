
namespace SD101.Example.OpenClosedPrinciple
{
    using System.Collections.Generic;
    using SD101.Common;
    using UnityEngine;

    public class OpenClosedPrinciple : IExample
    {
        public void Execute()
        {
            var rect = new Rectangle(15,10);
            var circle = new Circle(3);
            var triangle = new Triangle();

            AreaCalculator areaCalculator = new AreaCalculator();
            var shapeList = new List<Shape>() { rect, circle, triangle };

            Debug.Log("Total Area = " + areaCalculator.CalculateArea(shapeList));

        }
    }

    public abstract class Shape
    {
        public abstract int GetArea();
    }

    public class Triangle : Shape
    {
        public override int GetArea()
        {
            return 10;
        }
    }

    public class Rectangle : Shape
    {
        private int height;
        private int width;

        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        public override int GetArea()
        {
            return height * width;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetWidth()
        {
            return width;
        }

    }

    public class Circle : Shape
    {
        private int radious;

        public Circle(int radious)
        {
            this.radious = radious;
        }

        public override int GetArea()
        {
            return radious * radious * 3;
        }

        public int GetRadios()
        {
            return radious;
        }
    }

    public class AreaCalculator
    {
        public int CalculateArea(List<Shape> shapes)
        {
            var totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.GetArea();
            }

            return totalArea;
        }
    }
}


