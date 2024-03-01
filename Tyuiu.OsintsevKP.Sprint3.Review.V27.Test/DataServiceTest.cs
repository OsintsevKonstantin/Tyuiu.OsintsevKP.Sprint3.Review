using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint3.Review.V27.Lib;

namespace Tyuiu.OsintsevKP.Sprint3.Review.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -15.41;
            valueWaitArray[1] = -11.00;
            valueWaitArray[2] = -7.32;
            valueWaitArray[3] = -5.08;
            valueWaitArray[4] = 0;
            valueWaitArray[5] = -0.20; ;
            valueWaitArray[6] = 2.62;
            valueWaitArray[7] = 6.36;
            valueWaitArray[8] = 9.94;
            valueWaitArray[9] = 12.65;
            valueWaitArray[10] = 14.71;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
