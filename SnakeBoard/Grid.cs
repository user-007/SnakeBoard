using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeBoard
{
    sealed class Grid : Component {
        public Grid(int[][] arr,int x,int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i][j] = '*';
                }
            }
        }
    }
   
}
