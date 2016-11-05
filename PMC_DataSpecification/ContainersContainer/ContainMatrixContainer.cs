using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Containers;
using Points._1DPoints;
using Points._2DPoints;
using Points._3DPoints;
using Matrices;
using Positions;

namespace ContainersContainer
{
    public class ContainMatrixContainer<T>: IEnumerable, IDisposable where T : class
    {
        #region PrivateMembers
        private T[] _containers;
        private static int _currentIndex;
        private static int _length;
        #endregion
        #region Constructors
        public ContainMatrixContainer(int size)
        {
            _containers = new T[size];
            _currentIndex = 0;
            _length = size;
        }
        #endregion
        #region Excessors
        public T this[int i]
        {
            get { return _containers[i]; }
            set
            {
                if (i >= 0 && i < _containers.Length)
                {
                    _containers[i] = value;
                }
            }
        }
        public int Length
        {
            get { return _length; }
        }
        #endregion
        #region Methods
        
        /// <summary>
        /// Add container of matrix to container
        /// </summary>
        /// <param name="matrixContainer"></param>
        public void AddContainer(T matrixContainer)
        {
            _containers[_currentIndex] = matrixContainer;
            _currentIndex++;  
        }
        
        /// <summary>
        /// Clears container
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < _containers.Length; i++)
            {
                _containers[i] = null;
            }
            _currentIndex = 0;
            _length = 0;
            this.Dispose();
        }
        
        /// <summary>
        /// To go through container with foreach 
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var container in _containers)
            {
                yield return container;
            }
        }
        
        /// <summary>
        /// To start garbage collection in a moment
        /// </summary>
        public void Dispose()
        {
            GC.Collect();
        }
        
        /// <summary>
        /// Inserts matrixContainer by index
        /// </summary>
        /// <param name="index">index of array</param>
        /// <param name="matrixContainer">matrix container</param>
        public void Insert(int index, T matrixContainer)
        {
            _containers[index] = matrixContainer;
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>OneDPoint of type int</returns>
        public OneDPoint<int> GetpointByIndex(int iIndex, int jIndex, Position<OneDPoint<int>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>OneDPoint of type double</returns>
        public OneDPoint<double> GetpointByIndex(int iIndex, int jIndex, Position<OneDPoint<double>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>OneDPoint of type decimal</returns>
        public OneDPoint<decimal> GetpointByIndex(int iIndex, int jIndex, Position<OneDPoint<decimal>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>TwoDPoint of type int</returns>
        public TwoDPoint<int> GetpointByIndex(int iIndex, int jIndex, Position<TwoDPoint<int>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>TwoDPoint of type double</returns>
        public TwoDPoint<double> GetpointByIndex(int iIndex, int jIndex, Position<TwoDPoint<double>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>TwoDPoint of type decimal</returns>
        public TwoDPoint<decimal> GetpointByIndex(int iIndex, int jIndex, Position<TwoDPoint<decimal>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }


        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>ThreeDPoint of type int</returns>
        public ThreeDPoint<int> GetpointByIndex(int iIndex, int jIndex, Position<ThreeDPoint<int>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>ThreeDPoint of type double</returns>
        public ThreeDPoint<double> GetpointByIndex(int iIndex, int jIndex, Position<ThreeDPoint<double>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        
        /// <summary>
        /// To get point by index
        /// </summary>
        /// <param name="iIndex">index of point array</param>
        /// <param name="jIndex">index of point array</param>
        /// <param name="position">object Position</param>
        /// <returns>ThreeDPoint of type decimal</returns>
        public ThreeDPoint<decimal> GetpointByIndex(int iIndex, int jIndex, Position<ThreeDPoint<decimal>> position)
        {
            return position.GetPositions()[iIndex][jIndex];
        }
        #endregion
    }
}
