using System;
using Points.Abstraction;

namespace Points._1DPoints
{
    public class OneDPoint<T> : BaseMethods where T : struct
    {
        #region PrivateMembers
        private T _xComponent;
        #endregion

        #region Constructors
        public OneDPoint() { }

        public OneDPoint(T xComponent)
        {
            _xComponent = xComponent;
        }
        #endregion

        #region Excessors
        public T XComponent
        {
            get { return _xComponent; }
            private set { _xComponent = value; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Represents point
        /// </summary>
        /// <returns></returns>
        public override string ShowPoint()
        {
            return this.ToString();
        }

        /// <summary>
        /// Overriden ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "{" + this._xComponent.ToString() + " }";
        }
        #endregion
    }
}
