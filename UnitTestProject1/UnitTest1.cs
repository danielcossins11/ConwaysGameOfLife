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
            map.Add(new List<bool>(new bool[] { false }));
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
            Assert.AreEqual(true, cell.isAlive());
        }

        [TestMethod]
        public void CheckIfIndexIsCorrect()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { false, false }));
            map.Add(new List<bool>(new bool[] { false, true }));
            Cell cell = new Cell(1, 1, map);
            Assert.AreEqual(true, cell.isAlive());
        }

        [TestMethod]
        public void CheckNeighbors()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, false, false }));
            //                                         cell
            map.Add(new List<bool>(new bool[] { false, true, true }));
            map.Add(new List<bool>(new bool[] { false, true, false }));
            Cell cell = new Cell(1, 1, map);
            Assert.AreEqual(3, cell.getAliveNeighbors());
        }

        [TestMethod]
        public void CheckNeighborsWithAllDead()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { false, false, false }));
            //                                         cell
            map.Add(new List<bool>(new bool[] { false, true, false }));
            map.Add(new List<bool>(new bool[] { false, false, false }));
            Cell cell = new Cell(1, 1, map);
            Assert.AreEqual(0, cell.getAliveNeighbors());
        }

        [TestMethod]
        public void CheckNeighborsWithAllAlive()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            //                                         cell
            map.Add(new List<bool>(new bool[] { true, false, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            Cell cell = new Cell(1, 1, map);
            Assert.AreEqual(8, cell.getAliveNeighbors());
        }

        [TestMethod]
        public void TestRule1()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true }));
            Cell cell = new Cell(0, 0, map);
            cell.rule1();
            Assert.AreEqual(false, cell.isAlive());
        }

        [TestMethod]
        public void TestRule2()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { false, false, false }));
            map.Add(new List<bool>(new bool[] { false, true, false }));
            map.Add(new List<bool>(new bool[] { true, true, false }));
            Cell cell = new Cell(1, 1, map);
            cell.rule2();
            Assert.AreEqual(true, cell.isAlive());
        }
    }
}
