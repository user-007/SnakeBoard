using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeBoard
{
    sealed class Row : Component {
        private int i;
        private int j;
      /*  public void define_x(int x)
        {
            this.x = x;
        }

        public  void define_y(int y)
        {
            this.y = y;
        }
      */
      public Row(int i,int j)
        {
            this.i = i;
            this.j = j;
        }
    }
 
}
