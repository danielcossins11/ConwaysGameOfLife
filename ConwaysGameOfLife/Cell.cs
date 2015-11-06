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
        public Cell(int a, int b, List<List<bool>> list)
        {
            x = a;
            y = b;
            map = list;
        }
        
    }
}
