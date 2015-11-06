using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class Cell
    {
        private bool alive = false;
        private int x;
        private int y;
        public Cell(int a, int b)
        {
            x = a;
            y = b;
        }

    }
}
