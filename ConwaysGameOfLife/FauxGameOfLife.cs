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
            //List<List<bool>> storageCells = cells;
            //for (int y=0; y<cells.Count(); y++)
            //{
            //    for(int x=0; x<cells[y].Count(); x++)
            //    {
            //        Cell cell = new Cell(x, y, storageCells);
            //        cells[y][x] = cell.doAll();
            //    }
            //}


            if(cells[0][0] == true)
            {
                cells[0][0] = false;
            }
            else
            {
                cells[0][0] = true;
            }
            //Tick();
        }

        public List<List<bool>> getBlank()
        {
            List<List<bool>> blank = new List<List<bool>>();
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, true, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            //blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false }));
            return blank;
        }
    }
}
