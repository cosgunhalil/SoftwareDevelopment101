
namespace SD101.Example.Conditions
{
    using System;
    using UnityEngine;
    using SD101.Common;


    public class ConditionsSample : IExample
    {
        public void Execute()
        {
            ExecuteIfStatement();
            ExecuteIfElseStatement();
            ExecuteIfElseIfStatement();
            ExecuteNestedIfStatements();
            ExecuteSwitchStatement();
            ExecuteNestedSwitchStatements();
        }

        private void ExecuteIfStatement()
        {
            var condition = true;

            if (condition)
            {
                Debug.Log("condition is true");
            }
        }

        private void ExecuteIfElseStatement()
        {
            var condition = false;

            if (condition)
            {
                Debug.Log("condition is true");
            }
            else
            {
                Debug.Log("condition is false");
            }
        }


        private void ExecuteIfElseIfStatement()
        {
            var password = 1234;

            if (password == 1234)
            {
                Debug.Log("pasword is true");
            }
            else if(password == 123)
            {
                Debug.Log("pasword is almost true");
            }
            else
            {
                Debug.Log("pasword is wrong!");
            }
        }

        private void ExecuteNestedIfStatements()
        {
            var condition = true;
            var secondCondition = 1;

            if (condition)
            {
                Debug.Log("condition is true");

                if (secondCondition == 1)
                {
                    Debug.Log("secondCondition is 1");
                }
            }
            else
            {
                Debug.Log("condition is false");

                if (secondCondition != 1)
                {
                    Debug.Log("secondCondition is not 1");
                }
            }
        }

        private void ExecuteSwitchStatement()
        {
            var behavior = 1;
            
            switch (behavior)
            {
                case 0:
                case 1:
                    Debug.Log("behavior is 0 or 1");
                    break;
                default:
                    Debug.Log("undeclared behavior");
                    break;
            }
        }

        private void ExecuteNestedSwitchStatements()
        {
            var behavior = 1;
            var state = 3;

            switch (behavior)
            {
                case 0:
                case 1:
                    Debug.Log("behavior is 0 or 1");

                    switch (state)
                    {
                        case 3:
                            Debug.Log("state is 3");
                            break;
                        default:
                            break;
                    }
                    
                    break;
                default:
                    Debug.Log("undeclared behavior");
                    break;
            }
        }
    }

}
