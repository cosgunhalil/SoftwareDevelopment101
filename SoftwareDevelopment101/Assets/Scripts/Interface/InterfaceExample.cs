﻿
namespace SD101.Example.Interface
{
    using SD101.Common;
    using UnityEngine;

    public class InterfaceExample : IExample
    {
        public void Execute()
        {
            //IExample example = new IExample();

            Runner runner = new Runner();
            runner.Run();
            runner.Compete();
        }
    }

    public class Runner : IRunnerAthlete
    {
        public void Compete()
        {
            Debug.Log("Runner Compete!");
        }

        public void Run()
        {
            Debug.Log("Runner Run!");
        }
    }

    public interface IRunnerAthlete : IAthlete
    {
        void Run();
    }

    public interface IAthlete
    {
        void Compete();
    }
}


