using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace Equivalence_Graph.Tests
{
    [TestClass()]
    public class DrawGraphTests
    {
        DrawGraph drawgraph;
        Graphics gr;
        [TestMethod()]
        public void fillAdjacencyMatrixTest()
        {
            drawgraph = new DrawGraph(500, 500);

            int numberV2 = 6; List<Edge> E2 = new List<Edge>(); int[,] matrix2 = new int[6,6];

            Edge e = new Edge(1, 1);
            for (int i = 1; i <= 5; i++)
                for (int x = 1; x <= 5; x++)
                    E2.Add(new Edge(i, x));
        
            //
            for (int i = 0; i < numberV2; i++)
                for (int j = 0; j < numberV2; j++)
                    matrix2[i, j] = 0;
            for (int i = 0; i < E2.Count; i++)
            {
                matrix2[E2[i].v1, E2[i].v2] = 1;
            }
            int[,] matrix = new int[6, 6];
            drawgraph.fillAdjacencyMatrix(6, E2, matrix);
            for(int i = 0; i < 6; i++)
                for(int j = 0; j < 6; j++)
                    Assert.AreEqual(matrix[j,i] , matrix2[j, i]);
        }

        [TestMethod()]
        public void GetBitmapTest()
        {
            drawgraph = new DrawGraph(500, 500);
            
            drawgraph.drawVertex(150, 150, "a");
            Bitmap asd = drawgraph.GetBitmap();

            MemoryStream wew = new MemoryStream();
            asd.Save(wew, System.Drawing.Imaging.ImageFormat.Png);
            
            
            Assert.AreEqual(2564, wew.Length);
        }
    }
}