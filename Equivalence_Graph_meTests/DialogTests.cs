using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Equivalence_Graph.Tests {

    [TestClass()]
    public class DialogTests
    {
        Graph form = new Graph();

        [TestMethod()]
        public void isBipartiteTest()
        {
            List<Edge> E = new List<Edge>();
            for (int i = 1; i <= 5; i++)
                for (int x = 1; x <= 5; x++)
                    E.Add(new Edge(i, x));

            int Count = 6;
            
            List<List<int>> adj = new List<List<int>>(Count + 1);
            for (int i = 0; i <= Count; i++)
            {
                adj.Add(new List<int>());
            }
            List<int> color_1 = new List<int>();

            for (int i = 0; i < Count; i++)
            {
                color_1.Add(-1);
            }

            color_1[1] = 0;
            bool[] visited = new bool[Count + 1];
            visited[1] = true;
            foreach (Edge i in E)
            {
                form.addEdge(adj, i);
            }

            bool graph_1 = form.isBipartite(adj, 1, visited, color_1);
            

            Assert.AreEqual(false, graph_1);
        }

        [TestMethod()]
        public void change_graph_button_ClickTest()
        {
            form.change_graph_button_Click(null, null);
            Assert.AreEqual(form.graph, false);
            form.change_graph_button_Click(null, null);
            Assert.AreEqual(form.graph, true);
            form.change_graph_button_Click(null, null);
            Assert.AreEqual(form.graph, false);
            form.change_graph_button_Click(null, null);
            Assert.AreEqual(form.graph, true);
        }
        
        [TestMethod()]
        public void equivalence_button_ClickTest()
        {
            List<Edge> E = new List<Edge>();
            for (int i = 1; i <= 5; i++)
                for (int x = 1; x <= 5; x++)
                    E.Add(new Edge(i, x));
            List<Edge> E1 = new List<Edge>();
            for (int i = 1; i <= 5; i++)
                for (int x = 1; x <= 5; x++)
                    E1.Add(new Edge(i, x));
            form.edges_1 = E;
            form.edges_2 = E1;

            //List<int> color_1 = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                form.color_1.Add(-1);
                form.vertexes_1.Add(new Vertex(15, 15));
                form.color_2.Add(-1);
                form.vertexes_2.Add(new Vertex(15, 15));
            }

            form.equivalence_button_Click(null,null);
            string str = "Граф 1: Не двудольный;\r\nГраф 2: Не двудольный;\r\nГрафы еквивалентны.";
            string str2 = form.get_result();
            Assert.AreEqual(str, str2);
        }

        [TestMethod()]
        public void DialogTest()
        {
            form.drawVertexButton_Click(null, null);
            form.sheet_MouseClick(null, new MouseEventArgs(new MouseButtons(), 0, 100, 100, 0));
            form.sheet_MouseClick(null, new MouseEventArgs(new MouseButtons(), 0, 150, 150, 0));

            List<Vertex> V = new List<Vertex>();
            V.Add(new Vertex(100, 100));
            V.Add(new Vertex(150, 150));
            for(int i = 0; i < V.Count; i++) {
                Assert.AreEqual(form.vertexes_1[i].x, V[i].x);
                Assert.AreEqual(form.vertexes_1[i].y, V[i].y);
            }

            form.drawEdgeButton_Click(null, null);
            form.sheet_MouseClick(null, new MouseEventArgs(new MouseButtons(), 0, 100, 100, 0));
            form.sheet_MouseClick(null, new MouseEventArgs(new MouseButtons(), 0, 150, 150, 0));

            List<Edge> edges_1;
            edges_1 = form.edges_1;
            for (int i = 0; i < edges_1.Count; i++)
            {
                Assert.AreEqual(edges_1[i].v1, 1);
                Assert.AreEqual(edges_1[i].v1, 2);
            }

            form.deleteButton_Click(null, null);
            form.sheet_MouseClick(null, new MouseEventArgs(new MouseButtons(), 0, 100, 100, 0));
            form.sheet_MouseClick(null, new MouseEventArgs(new MouseButtons(), 0, 150, 150, 0));
            V.Clear();
            for (int i = 0; i < V.Count; i++) {
                Assert.AreEqual(form.vertexes_1[i].x, V[i].x);
                Assert.AreEqual(form.vertexes_1[i].y, V[i].y);
            }
        }
    }
}
