using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacingGame.Model
{
    public class Asteroid
    {
        Tuple<int, int> koordinates;
        public Tuple<int, int> KOORDINATES
        {
            get { return koordinates; }
        }
            

        public Asteroid(int xkoordinate)
        {
            koordinates = new Tuple<int, int>(xkoordinate, 0);
        }
    }
}
