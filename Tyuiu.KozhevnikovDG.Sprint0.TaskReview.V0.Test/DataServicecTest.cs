using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KozhevnikovDG.Sprint0.TaskReview.V0.Lid;

namespace Tyuiu.KozhevnikovDG.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServicecTest
    {
        [TestMethod]
        public void Calculate()
        {
            Assert.AreEqual(30, DataService.Calc(1, 2, 3));
        }
    }
}
    

