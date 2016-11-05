using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Points._2DPoints;

namespace Points._3DPoints
{
    public class ThreeDPoint<T> : TwoDPoint<T> where T : struct 
    {
        #region PrivateMembers
        private T _zComponent;
        #endregion

        #region Constructors
        public ThreeDPoint(T xComponent, T yComponent, T zComponent) : base(xComponent, yComponent)
        {
            _zComponent = zComponent;
        }
        #endregion

        #region Excessors
        public T ZComponent
        {
            get { return _zComponent; }
            private set { _zComponent = value; }
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
            return "{" + this.XComponent.ToString() + ", " + this.YComponent.ToString() + ", " +
                    this._zComponent.ToString()+ "}";
        }
        #endregion
    }
}
