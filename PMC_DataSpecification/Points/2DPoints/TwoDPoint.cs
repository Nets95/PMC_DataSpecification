using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Points._1DPoints;


namespace Points._2DPoints
{
    public class TwoDPoint<T> : OneDPoint<T> where T : struct
    {
        #region PrivateMembers
        private T _yComponent;
        #endregion

        #region Constructors
        public TwoDPoint(T xComponent, T yComponent) : base(xComponent)
        {
            _yComponent = yComponent;
        }
        #endregion

        #region Excessors
        public T YComponent
        {
            get { return _yComponent; }
            private set { _yComponent = value; }
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
            return "{" + this.XComponent.ToString() + ", " + this._yComponent.ToString() + "}"; 
        }
        #endregion
    }

}
