using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConwaysGameOfLife;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InitializeCell()
        {
            List<List<bool>> map = new List<List<bool>>();
            Cell cell = new Cell(0, 0, map);
            Assert.IsNotNull(cell);
        }

        [TestMethod]
        public void CheckIfCellIsAlive()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, false }));
            map.Add(new List<bool>(new bool[] { false, false }));
            Cell cell = new Cell(0, 0, map);
            Assert.AreEqual(cell.isAlive(), true);
        }

        [TestMethod]
        public void CheckIfIndexIsCorrect()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { false, false }));
            map.Add(new List<bool>(new bool[] { false, true }));
            Cell cell = new Cell(1, 1, map);
            Assert.AreEqual(cell.isAlive(), true);
        }
    }
}
