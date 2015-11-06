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
        }

        public bool isAlive()
        {
            return alive;
        }

        public int getAliveNeighbors()
        {
            //will have to make an exception for the border cells
            checkHorizontal();
            checkVertical();
            checkCorners();
            return nCount;
        }
        
        public void checkHorizontal()
        {
            if(map[y][x+1] == true)
            {
                nCount++;
            }
            if(map[y][x-1] == true)
            {
                nCount++;
            }
        }
        public void checkVertical()
        {
            if (map[y+1][x] == true)
            {
                nCount++;
            }
            if (map[y-1][x] == true)
            {
                nCount++;
            }
        }
        public void checkCorners()
        {
            if (map[y + 1][x + 1] == true)
            {
                nCount++;
            }
            if (map[y - 1][x - 1] == true)
            {
                nCount++;
            }
            if (map[y + 1][x - 1] == true)
            {
                nCount++;
            }
            if (map[y - 1][x + 1] == true)
            {
                nCount++;
            }
        }

        public void rule1()
        {
            if(nCount < 2)
            {
                alive = false;
            }
        }

        public void rule2()
        {
            if (nCount == 2 || nCount == 3)
            {
                alive = true;
            }
        }

        public void rule3()
        {
            if (nCount > 3)
            {
                alive = false;
            }
        }

        public void rule4()
        {
            if (nCount == 3)
            {
                alive = true;
            }
        }
    }
}
