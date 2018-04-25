using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nyan_cat
{
    public enum CatState
    {
        Run,
        Jump,
        Fall
    }

    public class NyanCat
    {
        public Point Position { get; }
        public CatState State;
        public IGem CurrentGem { get; }
        public IPowerUp CurrentPowerUp { get; }

        public NyanCat(Point position)
        {
            Position = position;
        }

        public void Jump()
        {

        }
    }
}
