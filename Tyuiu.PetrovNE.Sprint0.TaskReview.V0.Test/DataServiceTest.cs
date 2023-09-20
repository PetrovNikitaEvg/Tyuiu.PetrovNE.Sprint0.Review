using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PetrovNE.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PetrovNE.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 2;
            int y = 2;
            int z = 4;

            int res = DataService.Calc(x, y, z);

            Assert.AreEqual(40, res);
        }
    }
}
