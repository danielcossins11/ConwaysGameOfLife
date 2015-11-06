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
        private Dictionary<char, List<List<bool>>> font = new Dictionary<char, List<List<bool>>>();

        

        public FauxGameOfLife()
        {
            //List<List<bool>> letter = new List<List<bool>>();
            //letter.Add(new List<bool>(new bool[] { true, true, true, true, true, true }));
            //letter.Add(new List<bool>(new bool[] { true, false, true, true, false, true }));
            //letter.Add(new List<bool>(new bool[] { true, false, true, true, false, true }));
            //letter.Add(new List<bool>(new bool[] { true, false, false, false, false, true }));
            //letter.Add(new List<bool>(new bool[] { true, false, true, true, false, true }));
            //letter.Add(new List<bool>(new bool[] { true, false, true, true, false, true }));
            //letter.Add(new List<bool>(new bool[] { true, true, true, true, true, true }));
            //font['H'] = letter;



            Tick();
        }

        public List<List<bool>> ToList()
        {
            return cells;
        }

        public void Tick()
        {
            //if(index >= phrase.Length)
            //{
            //    index = 0;
            //}
            //char letter = phrase[index];
            //cells = font[letter];
            //index++;
            cells = getBlank();
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
