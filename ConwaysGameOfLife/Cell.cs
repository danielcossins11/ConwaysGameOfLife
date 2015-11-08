using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConwaysGameOfLife;

namespace ConwaysGameOfLife
{
    public class Cell
    {
        private bool alive = false;
        private int x;
        private int y;
        private List<List<bool>> map;
        private int nCount = 0;
        public Cell(int a, int b, List<List<bool>> list)
        {
            x = a;
            y = b;
            map = list;
            if (map[y][x] == true)
            {
                alive = true;
            }
            else
            {
                alive = false;
            }
            //getAliveNeighbors();
            //rule1();
            //rule2();
            //rule3();
            //rule4();
            //isAlive();
        }

        public bool isAlive()
        {
            return alive;
        }

        public int getAliveNeighbors()
        {
            checkHorizontal();
            checkVertical();
            checkCorners();
            return nCount;
        }

        
        public void checkHorizontal()
        {
            if (!isOnRightEdge())
            {
                if (map[y][x + 1] == true)
                {
                    nCount++;
                }
            }
            if (!isOnLeftEdge())
            {
                if (map[y][x - 1] == true)
                {
                    nCount++;
                }
            }
        }
        public void checkVertical()
        {
            if (!isOnBottomEdge())
            {
                if (map[y + 1][x] == true)
                {
                    nCount++;
                }
            }
            if (!isOnTopEdge())
            {
                if (map[y - 1][x] == true)
                {
                    nCount++;
                }
            }
        }
        public void checkCorners()
        {
            if(!isOnTopEdge() && !isOnRightEdge())
            {
                if (map[y - 1][x + 1] == true)
                {
                    nCount++;
                }
            }
            if(!isOnTopEdge() && !isOnLeftEdge())
            {
                if (map[y - 1][x - 1] == true)
                {
                    nCount++;
                }
            }
            if(!isOnBottomEdge() && !isOnLeftEdge())
            {
                if (map[y + 1][x - 1] == true)
                {
                    nCount++;
                }
            }
            if(!isOnBottomEdge() && !isOnRightEdge())
            {
                if (map[y + 1][x + 1] == true)
                {
                    nCount++;
                }
            }
            //if (map[y + 1][x + 1] == true)
            //{
            //    nCount++;
            //}
            //if (map[y - 1][x - 1] == true)
            //{
            //    nCount++;
            //}
            //if (map[y + 1][x - 1] == true)
            //{
            //    nCount++;
            //}
            //if (map[y - 1][x + 1] == true)
            //{
            //    nCount++;
            //}
        }

        public bool isOnLeftEdge()
        {
            if(x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isOnRightEdge()
        {
            if (x == map[y].Count-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isOnTopEdge()
        {
            if(y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isOnBottomEdge()
        {
            if (y == map.Count -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isOnEdge()
        {
            if(isOnLeftEdge() || isOnRightEdge() || isOnTopEdge() || isOnBottomEdge())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void rule1()
        {
            if (isAlive())
            {
                if (nCount < 2)
                {
                    alive = false;
                }
            }
        }

        public void rule2()
        {
            if (isAlive())
            {
                if (nCount == 2 || nCount == 3)
                {
                    alive = true;
                }
            }
        }

        public void rule3()
        {
            if (isAlive())
            {
                if (nCount > 3)
                {
                    alive = false;
                }
            }
        }

        public void rule4()
        {
            if (!isAlive())
            {
                if (nCount == 3)
                {
                    alive = true;
                }
            }
        }

        public bool doAll()
        {
            getAliveNeighbors();
            rule1();
            rule2();
            rule3();
            rule4();
            return isAlive();
        }
    }
}
