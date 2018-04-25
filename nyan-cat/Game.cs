using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyan_cat
{
    public class Game
    {
        public NyanCat nyanCat { get; }
        public int Score { get; }
        public int Combo { get; }

        public Game()
        {
            nyanCat = new NyanCat(new Point(0, 0));
        }
    }
}
