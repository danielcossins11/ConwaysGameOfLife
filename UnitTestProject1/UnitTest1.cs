using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGameOfLife;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitializeCell()
        {
            Cell cell = new Cell(0, 0);
            Assert.IsNotNull(cell);
        }
    }
}
