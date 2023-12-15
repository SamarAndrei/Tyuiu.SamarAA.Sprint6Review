using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SamarAA.SprintReview.V15.Lib;

namespace Tyuiu.SamarAA.SprintReview.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int n1 = 1;
            int n2 = 12;
            int c = 2;
            int k = 3;
            int l = 3;
            int[,] arr = new int[,] { { 3, 4, 7 }, { 4, 2, 12 }, { 1, 2, 3 } };

            

            int wait = 12;
            Assert.AreEqual(wait, res);

           
        }
    }
}
