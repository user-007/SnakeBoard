using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeBoard
{
    /*
     a component can be :

    1) Cell -> defined by indexes  - x,y
    2) Row -> int i = 0; 
    3) Grid ->   
     */
   abstract class Component
    {
      
        //these classes can be overriden, when inherited
        public virtual void goUP()
        {

        }

        public virtual void goDOWN()
        {

        }
        public virtual void goLEFT()
        {

        }
        public virtual void goRIGHT()
        {

        }
    }
}
