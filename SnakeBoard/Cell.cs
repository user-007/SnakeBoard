using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeBoard {
    sealed class Cell : Component
    {
        private int x;
        private int y;
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int print_x()
        {
            return x;
        }
        public int print_y()
        {
            return y;
        }
    }

}
