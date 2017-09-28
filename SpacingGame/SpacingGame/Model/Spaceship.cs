using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacingGame.Model
{
    public enum Direction { Right, Left, Down };

    public class Spaceship
    {
        private int xkoordinate;

        public int XKOORDINATE
        {
            get { return xkoordinate; }
        }

        public Spaceship(int xkoordinate)
        {
            this.xkoordinate = xkoordinate;
        }

        public void MoveTo(Direction dir)
        {
            switch (dir)
            {
                case Direction.Right:
                    ++xkoordinate;
                    break;
                case Direction.Left:
                    --xkoordinate;
                    break;
                case Direction.Down:
                    break;
                default:
                    break;
            }
        }
    }
}
