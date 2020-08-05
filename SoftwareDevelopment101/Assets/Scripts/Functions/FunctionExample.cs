

namespace SD101.Example.Function
{
    using System;
    using System.Collections.Generic;
    using SD101.Common;
    using UnityEngine;

    public class FunctionExample : IExample
    {
        public void Execute()
        {
            ExecuteSimpleFunction();
            ExecuteLambdaExpression();
            ExecuteActionsExample();
        }

        private void ExecuteSimpleFunction()
        {
            Debug.Log("Simple function executed!");
        }

        private void ExecuteLambdaExpression()
        {
            Func<int, string> GetColor = (colorCode) => {

                switch (colorCode)
                {
                    case 0:
                        return "yellow";
                    default:
                        return "black";
                }

            };

            Debug.Log("color = " + GetColor(0));
        }

        //private string GetColor(int colorCode)
        //{
        //    switch (colorCode)
        //    {
        //        case 0:
        //            return "yellow";
        //        default:
        //            return "black";
        //    }
        //}


        private void ExecuteActionsExample()
        {

            Action<Robot> moveLeft = (robot) => {
                robot.x--;
                Debug.Log("x:" + robot.x + ", y: " + robot.y);
            };

            Action<Robot> moveRight = (robot) => {
                robot.x++;
                Debug.Log("x:" + robot.x + ", y: " + robot.y);
            };

            Action<Robot> moveUp = (robot) => {
                robot.y++;
                Debug.Log("x:" + robot.x + ", y: " + robot.y);
            };

            Action<Robot> moveDown = (robot) => {
                robot.y--;
                Debug.Log("x:" + robot.x + ", y: " + robot.y);
            };


            Dictionary<string, Action<Robot>> actionDictionary = new Dictionary<string, Action<Robot>>();

            actionDictionary.Add("left", moveLeft);
            actionDictionary.Add("right", moveRight);
            actionDictionary.Add("up", moveUp);
            actionDictionary.Add("down", moveDown);

            //move the robot

            Robot autobot = new Robot();

            actionDictionary["left"](autobot);
            actionDictionary["left"](autobot);
            actionDictionary["down"](autobot);
            actionDictionary["right"](autobot);
            actionDictionary["left"](autobot);
        }
    }

    public class Robot
    {
        public int x;
        public int y;
    }

}

