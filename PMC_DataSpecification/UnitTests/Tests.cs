using System;
using NUnit.Framework;
using System.Reflection;
using Containers;
using Matrices;
using Points._1DPoints;
using Points._2DPoints;
using Points._3DPoints;
using Positions;
using ContainersContainer;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public static void TestOperations()
        {
            Position<OneDPoint<int>> position = new Position<OneDPoint<int>>(5);
            MatrixContainer<Matrix<Position<OneDPoint<int>>>> matrixContainer =
                     new MatrixContainer<Matrix<Position<OneDPoint<int>>>>(3);
            Matrix<Position<OneDPoint<int>>> matrix1 = new Matrix<Position<OneDPoint<int>>>(1);

            ContainMatrixContainer<MatrixContainer<Matrix<Position<OneDPoint<int>>>>> containerContainers =
               new ContainMatrixContainer<MatrixContainer<Matrix<Position<OneDPoint<int>>>>>(3);

            Assert.IsInstanceOf<Matrix<Position<OneDPoint<int>>>>(matrixContainer.GetMatrixContainer());
            Assert.IsInstanceOf<Position<OneDPoint<int>>>(matrix1.GetMatrix());
            Assert.IsInstanceOf<OneDPoint<int>>(position.GetPositions());
        }
    }
}
