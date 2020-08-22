
namespace SD101.Example.LiskovSubstition
{
    using System.Collections.Generic;
    using SD101.Common;
    using UnityEngine;

    public class LiskovSubstitionPrinciple : IExample
    {
        public void Execute()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(10);
            rectangle.SetHeight(5);

            Square square = new Square();
            square.SetHeight(5);

            List<Rectangle> rectangles = new List<Rectangle>() {
                rectangle,
                square
            };

            //
            for (int i = 0; i < rectangles.Count; i++)
            {
                rectangles[i].SetHeight(10);
                rectangles[i].SetWidth(7);

                Debug.Log("Area = " + rectangles[i].GetArea());
            }
        }
    }

    public class Rectangle
    {
        protected float height;
        protected float width;

        public virtual void SetHeight(float height)
        {
            this.height = height;
        }

        public virtual void SetWidth(float width)
        {
            this.width = width;
        }

        public float GetHeight()
        {
            return height;
        }

        public float GetWidth()
        {
            return width;
        }

        public float GetArea()
        {
            return width * height;
        }

    }

    public class Square : Rectangle
    {
        public override void SetHeight(float height)
        {
            this.height = height;
            width = height;
        }

        public override void SetWidth(float width)
        {
            this.width = width;
            height = width;
        }
    }
}
