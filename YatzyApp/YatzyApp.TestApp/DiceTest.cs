using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YatzyApp.Core;
namespace YatzyApp.TestApp
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void CreateDiceTest()
        {

            Dice d = new Dice(1);

            Assert.IsTrue(d.Value==1);
            Assert.IsTrue(d.DiceVal() == "[1]");



        }
    }
}
