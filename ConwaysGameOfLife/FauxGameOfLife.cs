using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace ConwaysGameOfLife
{
    public class FauxGameOfLife : Board
    {
        private List<List<bool>> cells = new List<List<bool>>();
        //private Dictionary<char, List<List<bool>>> font = new Dictionary<char, List<List<bool>>>();

        

        public FauxGameOfLife()
        {
            cells = getBlank();
            Tick();
        }

        public List<List<bool>> ToList()
        {
            return cells;
        }

        public void Tick()
        {
            //cells = getBlank();
            //Cell cell = new Cell(0, 0, cells);


            //for(int y=0; y<cells.Count(); y++)
            //{
            //    for(int x=0; x<cells[y].Count(); x++)
            //    {
            //        Cell cell = new Cell(x, y, cells);
            //        cells[y][x] = cell.doAll();
            //    }
            //}

            cells[2][3] = true;
        }

        public List<List<bool>> getBlank()
        {
            List<List<bool>> blank = new List<List<bool>>();
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            return blank;
        }
    }
}
