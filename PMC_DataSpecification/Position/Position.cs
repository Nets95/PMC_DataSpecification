using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point;


namespace Position
{
    public class Position <T> 
    {
        private Point[][] _positions;

        public Position(int size)
        {
            _positions = new T[size][];
        }
    }
}
