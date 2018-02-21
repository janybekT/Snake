using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine :Figura
    {
 
        public HorizontalLine(int xleft, int xRignt, int y, char sym)
        {
            plist = new List<Point>();
            for(int x= xleft; x <= xRignt; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
            
        }

    }
}
