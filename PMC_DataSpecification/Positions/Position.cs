using System;
using Points;
using Points._1DPoints;
using Points._2DPoints;
using Points._3DPoints;

namespace Positions
{
    public class Position<T> where T : class
    {
        #region PrivateMembers
        private T[][] _points;
        private int _currentIndex;
        private int _length;
        #endregion

        #region Excessors
        public T this[int i, int j]
        {
            get { return _points[i][j]; } 
            private set
            {
                if ((i >= 0 && i < _points.Length) &&
                    (j >= 0 && j < _points.Length))
                {
                    _points[i][j] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }
            }
        }

        public int Length
        {
            get { return _length; }
        }
        #endregion
        #region Constructors
        public Position(int size)
        {
            _points = new T[size][];
            _currentIndex = 0;
            _length = size;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Add range of points to container
        /// </summary>
        /// <param name="points">array of point</param>
        public void AddPointsRange(T[] points)
        {
            _points[_currentIndex] = points;
            _currentIndex++;
        }

        /// <summary>
        /// Get array of points 
        /// </summary>
        /// <returns></returns>
        public T[][] GetPositions()
        {
            return this._points;
        }
        #endregion
    }
}
