using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfBilletSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfBilletSystem.Tests
{
    [TestClass()]
    public class BilletServiceTests
    {
        [TestMethod()]
        public void BilPrisUdenRabatTest()
        {
            //Arrange
            BilletService bil = new BilletService();
            //Act
            int int1 = bil.BilPrisUdenRabat();
            //Assert
            Assert.AreEqual(240, int1);
        }

        [TestMethod()]
        public void MCPrisUdenRabatTest()
        {
            //Arrange
            BilletService mc = new BilletService();
            //Act
            int int1 = mc.MCPrisUdenRabat();
            //Assert
            Assert.AreEqual(125, int1);
        }

        [TestMethod()]
        public void BilPrisMedRabatTest()
        {
            //Arrange
            BilletService bil = new BilletService();
            //Act
            int int1 = bil.BilPrisMedRabat();
            //Assert
            Assert.AreEqual(230, int1);
        }

        [TestMethod()]
        public void MCPrisMedRabatTest()
        {
            //Arrange
            BilletService mc = new BilletService();
            //Act
            int int1 = mc.MCPrisMedRabat();
            //Assert
            Assert.AreEqual(120, int1);
        }
    }
}