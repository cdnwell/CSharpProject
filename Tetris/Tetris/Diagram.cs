using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tetris
{
    internal class Diagram
    {
        internal int X
        {
            get; private set;
        }
        internal int Y
        {
            get; private set;
        }
        internal Diagram()
        {
            Reset();
        }

        private void Reset()
        {
            X = GameRule.SX; 
            Y = GameRule.SY;
        }
        internal void MoveLeft()
        {
            X--;
        }
        internal void MoveRight() {
            X++;
        }

        internal void MoveDown()
        {
            Y++;
        }

    }
}
