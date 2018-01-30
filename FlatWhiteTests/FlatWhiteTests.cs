using Microsoft.VisualStudio.TestTools.UnitTesting;
using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe.Tests
{
    [TestClass()]
    public class FlatWhiteTests
    {
        [TestMethod()]
        public void MlMælkTest()
        {
            // Arrange
            var flatWhite = new FlatWhite();
            // Act
            int Ml = flatWhite.MlMælk();
            // Assert
            Assert.AreEqual(160, Ml);
        }

        [TestMethod()]
        public void PrisTest()
        {
            var flatWhite = new FlatWhite();

            int pris = flatWhite.Pris();

            Assert.AreEqual(45, pris);
        }

        [TestMethod()]
        public void StyrkeTest()
        {
            var flatWhite = new FlatWhite();

            string styrke = flatWhite.Styrke();

            Assert.AreEqual("mild", styrke);
        }
    }
}