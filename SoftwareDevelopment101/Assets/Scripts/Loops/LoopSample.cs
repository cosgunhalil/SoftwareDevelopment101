using System;
using System.Collections;
using System.Collections.Generic;
using SD101.Common;
using UnityEngine;

namespace SD101.Example.Loops
{
    public class LoopSample : IExample
    {
        private const int NUMBER_COUNT_IN_THE_LIST = 100;
        private List<int> sampleNumberList = new List<int>();

        public void Execute()
        {
            FillTheNumbersList();
            IterateTheNumbersList();
            ClearNumbersList();
        }

        private void FillTheNumbersList()
        {
            for (int i = 0; i < NUMBER_COUNT_IN_THE_LIST; i++)
            {
                sampleNumberList.Add(i);
            }
        }

        private void IterateTheNumbersList()
        {
            foreach (var number in sampleNumberList)
            {
                Debug.Log("Number is = " + number);
            }
        }

        private void ClearNumbersList()
        {
            Debug.Log("sampleNumberList.Count = " + sampleNumberList.Count);

            //way 1 
            for (int i = 0; i < NUMBER_COUNT_IN_THE_LIST; i++)
            {
                sampleNumberList.Remove(i);
            }

            //way 2 - is it works?
            //foreach (var number in sampleNumberList)
            //{
            //    sampleNumberList.Remove(number);
            //}

            //better way
            sampleNumberList.Clear();

            Debug.Log("sampleNumberList.Count = " + sampleNumberList.Count);
        }
    }
}
