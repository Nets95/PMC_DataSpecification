using System;
using Points._1DPoints;
using Points._2DPoints;
using Points._3DPoints;
using Matrices;
using Containers;
using ContainersContainer;
using Positions;
using System.Threading;
using System.Collections.Generic;

namespace PMC_DataSpecification
{
    class Program
    {
        public static Random GenerateRandom()
        {
            return new Random();
        }

        public static void GenerateExample()
        {
            try
            {
                Random x = GenerateRandom();
                Random y = GenerateRandom();
                Random z = GenerateRandom();

                OneDPoint<int>[] points = new OneDPoint<int>[5];
                Position<OneDPoint<int>> position = new Position<OneDPoint<int>>(5);

                for (int i = 0; i < position.Length; i++)
                {
                    for (int j = 0; j < points.Length; j++)
                    {
                        points[j] = new OneDPoint<int>(x.Next());
                    }
                    position.AddPointsRange(points);
                }

                Matrix<Position<OneDPoint<int>>> matrix = new Matrix<Position<OneDPoint<int>>>(2);
                Matrix<Position<OneDPoint<int>>> matrix1 = new Matrix<Position<OneDPoint<int>>>(1);
                for (int i = 0; i < matrix1.Lenght; i++)
                {
                    matrix1.AddPositions(position);
                }

                MatrixContainer<Matrix<Position<OneDPoint<int>>>> matrixContainer =
                    new MatrixContainer<Matrix<Position<OneDPoint<int>>>>(3);

                foreach (var item in matrixContainer)
                {
                    matrixContainer.AddMatrix(matrix1);
                }

                ContainMatrixContainer<MatrixContainer<Matrix<Position<OneDPoint<int>>>>> containerContainers =
                    new ContainMatrixContainer<MatrixContainer<Matrix<Position<OneDPoint<int>>>>>(3);
                containerContainers.Insert(0, matrixContainer);

                foreach (var item in containerContainers)
                {
                    containerContainers.AddContainer(matrixContainer);
                }

                int counter = 0;
                for (int i = 0; i < containerContainers.Length; i++)
                {
                    Console.WriteLine("Container {0}", i+1);
                    for (int j = 0; j < matrixContainer.Length; j++)
                    {
                        Console.WriteLine("Matrix Container {0}", j + 1);
                        for(int k = 0; k < matrix1.Lenght; k++)
                        {
                            Console.WriteLine("Matrix {0}", k+1);
                            for (int n = 0; n < position.Length; n++)
                            {
                                foreach (var container in containerContainers[i].GetMatrixContainer()[j].GetMatrix()[k].GetPositions()[n])
                                {
                                    Console.WriteLine("Container № {0}, Matrix Contaner № {1}, Matrix № {2}, Position № {3}", i + 1, j + 1, k + 1, n + 1);
                                    Console.WriteLine("Number of point = {0} - {1}", counter, container.ShowPoint());
                                    Console.WriteLine();
                                    counter++;
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("Length of Container {0}", containerContainers.Length);
                Console.WriteLine("Matrix Container with index 1 is inserted");
                containerContainers.Insert(1, matrixContainer);
                Console.WriteLine("Container is cleared");
                containerContainers.Clear();
              
                Console.WriteLine("Length of Container {0}",containerContainers.Length);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        static void Main(string[] args)
        {
            Thread countingThread = new Thread(GenerateExample);
            countingThread.IsBackground = true;
            countingThread.Start();
            Console.ReadLine();
        }
    }
}
