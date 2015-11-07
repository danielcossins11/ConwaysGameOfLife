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
            map.Add(new List<bool>(new bool[] { false, true }));
            map.Add(new List<bool>(new bool[] { false, false }));
            Cell cell = new Cell(1, 0, map);
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
        public void CheckForEdge()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true }));
            Cell cell = new Cell(0, 0, map);
            Assert.AreEqual(true, cell.isOnEdge());
        }

        [TestMethod]
        public void CheckForLeftEdge()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            Cell cell = new Cell(0, 1, map);
            Assert.AreEqual(true, cell.isOnLeftEdge());
        }

        [TestMethod]
        public void CheckForRightEdge()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            Cell cell = new Cell(2, 1, map);
            Assert.AreEqual(true, cell.isOnRightEdge());
        }

        [TestMethod]
        public void CheckForTopEdge()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            Cell cell = new Cell(1, 0, map);
            Assert.AreEqual(true, cell.isOnTopEdge());
        }

        [TestMethod]
        public void CheckForBottomEdge()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            Cell cell = new Cell(1, 2, map);
            Assert.AreEqual(true, cell.isOnBottomEdge());
        }

        [TestMethod]
        public void TestRule1()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true }));
            Cell cell = new Cell(0, 0, map);
            cell.getAliveNeighbors();
            cell.rule1();
            Assert.AreEqual(false, cell.isAlive());
        }

        [TestMethod]
        public void TestRule2()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { false, false, false }));
            map.Add(new List<bool>(new bool[] { false, false, false }));
            map.Add(new List<bool>(new bool[] { true, true, false }));
            Cell cell = new Cell(1, 1, map);
            cell.getAliveNeighbors();
            cell.rule2();
            Assert.AreEqual(true, cell.isAlive());
        }

        [TestMethod]
        public void TestRule3()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { true, true, true }));
            Cell cell = new Cell(1, 1, map);
            cell.getAliveNeighbors();
            cell.rule3();
            Assert.AreEqual(false, cell.isAlive());
        }

        [TestMethod]
        public void TestRule4()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { true, true, true }));
            map.Add(new List<bool>(new bool[] { false, false, false }));
            map.Add(new List<bool>(new bool[] { false, false, false }));
            Cell cell = new Cell(1, 1, map);
            cell.getAliveNeighbors();
            cell.rule4();
            Assert.AreEqual(true, cell.isAlive());
        }

        [TestMethod]
        public void TestDoAllWithOneElement()
        {
            List<List<bool>> map = new List<List<bool>>();
            map.Add(new List<bool>(new bool[] { false }));
            List<List<bool>> storageMap = map;

            for (int y=0; y<map.Count(); y++)
            {
                for(int x=0; x< map[y].Count(); x++)
                {
                    Cell cell = new Cell(x, y, storageMap);
                    map[y][x] = cell.doAll();
                }
            }
            //Cell cell = new Cell(0, 0, storageMap);
            //map[0][0] = cell.doAll();

            List<List<bool>> result = new List<List<bool>>();
            result.Add(new List<bool>(new bool[] { false }));
            //only working with each individual line
            CollectionAssert.AreEqual(result[0], map[0]);
        }

        //[TestMethod]
        //public void TestDoAll()
        //{
        //    List<List<bool>> map = new List<List<bool>>();
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    map.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    List<List<bool>> storageMap = map;


        //    for (int y=0; y<map.Count(); y++)
        //    {
        //        for(int x=0; x< map[y].Count(); x++)
        //        {
        //            Cell cell = new Cell(x, y, storageMap);
        //            map[y][x] = cell.doAll();
        //        }
        //    }

        //    List<List<bool>> result = new List<List<bool>>();
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    result.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
        //    CollectionAssert.AreEqual(result, map);
        //}
    }
}
