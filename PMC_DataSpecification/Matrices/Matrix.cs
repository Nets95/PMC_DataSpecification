using System;
using System.Collections;
using Positions;
using Points._1DPoints;
using Points._2DPoints;
namespace Matrices
{
    public class Matrix<T> : IEnumerable  where T :class
    {
        #region PrivateMembers
        private T[] _positions;
        private int _currentIndex;
        private int _length;
        #endregion

        #region Axcessors
        public T this[int i]
        {
            get { return _positions[i]; }
            private set
            {
                if (i >= 0 && i < _positions.Length)
                {
                    _positions[i] = value;
                }
            }
        }
        public int Lenght
        {
            get { return _length; }
        }
        #endregion

        #region Constructors
        public Matrix(int size)
        {
            _positions = new T[size];
            _currentIndex = 0;
            _length = size;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Add position to container
        /// </summary>
        /// <param name="position"></param>
        public void AddPositions(T position)
        {
            _positions[_currentIndex] = position;
            _currentIndex++;   
        }

        /// <summary>
        /// Returns matrix of positions 
        /// </summary>
        /// <returns>array of positions</returns>
        public T[] GetMatrix()
        {
            return this._positions; 
        }

        /// <summary>
        /// To go through container with foreach
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _positions)
            {
                yield return item;
            }
        }
        #endregion


    }
}
