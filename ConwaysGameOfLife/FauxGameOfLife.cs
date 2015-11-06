using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class FauxGameOfLife : Board
    {
        private List<List<bool>> cells = new List<List<bool>>();
        //private Dictionary<char, List<List<bool>>> font = new Dictionary<char, List<List<bool>>>();

        

        public FauxGameOfLife()
        {

            Tick();
        }

        public List<List<bool>> ToList()
        {
            return cells;
        }

        public void Tick()
        {
            cells = getBlank();
            //Cell cell = new Cell();
        }

        public List<List<bool>> getBlank()
        {
            List<List<bool>> blank = new List<List<bool>>();
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            blank.Add(new List<bool>(new bool[] { false, false, false, false, false, false }));
            return blank;
        }
    }
}
