using System;
using System.Collections;
using Matrices;


namespace Containers
{
    public class MatrixContainer<T>: IEnumerable where T : class
    {
        #region PrivateMembers
        private T[] _matrices;
        private int _currentIndex;
        private int _length;
        #endregion

        #region Excessors
        public T this[int i]
        {
            get { return _matrices[i]; }
            private set
            {
                if (i >= 0 && i < _matrices.Length)
                {
                    _matrices[i] = value;
                }
            }
        }

        public int Length
        {
            get { return _length; }
        }
        #endregion

        #region Constructors
        public MatrixContainer(){}

        public MatrixContainer(int size)
        {
            _matrices = new T[size];
            _currentIndex = 0;
            _length = size;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Add matrix to container
        /// </summary>
        /// <param name="matrix">instance of matrix</param>
        public void AddMatrix(T matrix)
        {
            _matrices[_currentIndex] = matrix;
            _currentIndex++;
        }

        /// <summary>
        /// Insert matrix by index
        /// </summary>
        /// <param name="index">index of array</param>
        /// <param name="matrix">instance of matrix</param>
        public void Insert(int index, T matrix)
        {
            if (index >= 0 && index <= _length)
            {
                _matrices[index] = matrix;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }

        /// <summary>
        /// Returns matrices
        /// </summary>
        /// <returns>array of matrices</returns>
        public T[] GetMatrixContainer()
        {
            return this._matrices;
        }

        /// <summary>
        /// To go through container with foreach
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var item in _matrices)
            {
                yield return _matrices;
            }
        }
        #endregion
    }
}
