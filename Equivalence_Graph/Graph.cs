using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Equivalence_Graph
{
    public partial class Graph : Form
    {
        public bool graph = true;
        public List<int> color_1;
        public DrawGraph rendering_1;
        public List<Vertex> vertexes_1;
        public List<Edge> edges_1;
        public List<int> color_2;
        public DrawGraph rendering_2;
        public List<Vertex> vertexes_2;
        public List<Edge> edges_2;
        public int[,] AdjacencyMatrix; 
        public int[,] IncidenceMatrix; 

        public int selected_1;
        public int selected_2;

        public Graph()
        {
            InitializeComponent();
            vertexes_1 = new List<Vertex>();
            rendering_1 = new DrawGraph(sheet.Width, sheet.Height);
            edges_1 = new List<Edge>();
            color_1 = new List<int>();
            color_2 = new List<int>();
            rendering_2 = new DrawGraph(sheet.Width, sheet.Height);
            vertexes_2 = new List<Vertex>();
            edges_2 = new List<Edge>();
            sheet.Image = rendering_1.GetBitmap();
        }
        
        public void selectVertexButton_Click(object sender, EventArgs e)
        {
            mouse_button.Enabled = false;
            add_vertex_button.Enabled = true;
            add_edge_button.Enabled = true;
            delete_vertex_button.Enabled = true;
            if (graph)
            {
                rendering_1.clearSheet();
                rendering_1.drawALLGraph(vertexes_1, edges_1);
                sheet.Image = rendering_1.GetBitmap();
            }
            else
            {
                rendering_2.clearSheet();
                rendering_2.drawALLGraph(vertexes_2, edges_2);
                sheet.Image = rendering_2.GetBitmap();
            }
            selected_1 = -1;
        }
        
        public void drawVertexButton_Click(object sender, EventArgs e)
        {
            add_vertex_button.Enabled = false;
            mouse_button.Enabled = true;
            add_edge_button.Enabled = true;
            delete_vertex_button.Enabled = true;
            if (graph)
            {
                rendering_1.clearSheet();
                rendering_1.drawALLGraph(vertexes_1, edges_1);
                sheet.Image = rendering_1.GetBitmap();
            }
            else
            {
                rendering_2.clearSheet();
                rendering_2.drawALLGraph(vertexes_2, edges_2);
                sheet.Image = rendering_2.GetBitmap();
            }
        }
        
        public void drawEdgeButton_Click(object sender, EventArgs e)
        {
            add_edge_button.Enabled = false;
            mouse_button.Enabled = true;
            add_vertex_button.Enabled = true;
            delete_vertex_button.Enabled = true;
            if (graph)
            {
                rendering_1.clearSheet();
                rendering_1.drawALLGraph(vertexes_1, edges_1);
                sheet.Image = rendering_1.GetBitmap();
            }
            else
            {
                rendering_2.clearSheet();
                rendering_2.drawALLGraph(vertexes_2, edges_2);
                sheet.Image = rendering_2.GetBitmap();
            }
            selected_1 = -1;
            selected_2 = -1;
        }
        
        public void deleteButton_Click(object sender, EventArgs e)
        {
            delete_vertex_button.Enabled = false;
            mouse_button.Enabled = true;
            add_vertex_button.Enabled = true;
            add_edge_button.Enabled = true;
            if (graph)
            {
                rendering_1.clearSheet();
                rendering_1.drawALLGraph(vertexes_1, edges_1);
                sheet.Image = rendering_1.GetBitmap();
            }
            else
            {
                rendering_2.clearSheet();
                rendering_2.drawALLGraph(vertexes_2, edges_2);
                sheet.Image = rendering_2.GetBitmap();
            }
        }
        
        public void deleteGraphButton_Click(object sender, EventArgs e)
        {
            mouse_button.Enabled = true;
            add_vertex_button.Enabled = true;
            add_edge_button.Enabled = true;
            delete_vertex_button.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                if (graph)
                {
                    color_1.Clear();
                    vertexes_1.Clear();
                    edges_1.Clear();
                    rendering_1.clearSheet();
                    sheet.Image = rendering_1.GetBitmap();
                }
                else
                {
                    color_2.Clear();
                    vertexes_2.Clear();
                    edges_2.Clear();
                    rendering_2.clearSheet();
                    sheet.Image = rendering_2.GetBitmap();
                }
            }
        }
        
        public void adjacencyButton_Click(object sender, EventArgs e)
        {
            outputsAdjacency(graph);
        }
        
        public void incidenceButton_Click(object sender, EventArgs e)
        {
            createIncAndOut(graph);
        }

        public void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (mouse_button.Enabled == false)
            {
                if (graph)
                {
                    for (int i = 0; i < vertexes_1.Count; i++)
                    {
                        if (Math.Pow((vertexes_1[i].x - e.X), 2) + Math.Pow((vertexes_1[i].y - e.Y), 2) <= rendering_1.R * rendering_1.R)
                        {
                            if (selected_1 != -1)
                            {
                                selected_1 = -1;
                                rendering_1.clearSheet();
                                rendering_1.drawALLGraph(vertexes_1, edges_1);
                                sheet.Image = rendering_1.GetBitmap();
                            }
                            if (selected_1 == -1)
                            {
                                rendering_1.drawSelectedVertex(vertexes_1[i].x, vertexes_1[i].y);
                                selected_1 = i;
                                sheet.Image = rendering_1.GetBitmap();
                                outputsAdjacency(graph);
                                listBoxMatrix.Items.Clear();
                                int degree = 0;
                                for (int j = 0; j < vertexes_1.Count; j++)
                                    degree += AdjacencyMatrix[selected_1, j];
                                listBoxMatrix.Items.Add("Степень вершины №" + (selected_1 + 1) + " равна " + degree);
                                break;
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < vertexes_2.Count; i++)
                    {
                        if (Math.Pow((vertexes_2[i].x - e.X), 2) + Math.Pow((vertexes_2[i].y - e.Y), 2) <= rendering_2.R * rendering_2.R)
                        {
                            if (selected_1 != -1)
                            {
                                selected_1 = -1;
                                rendering_2.clearSheet();
                                rendering_2.drawALLGraph(vertexes_2, edges_2);
                                sheet.Image = rendering_2.GetBitmap();
                            }
                            if (selected_1 == -1)
                            {
                                rendering_2.drawSelectedVertex(vertexes_2[i].x, vertexes_2[i].y);
                                selected_1 = i;
                                sheet.Image = rendering_2.GetBitmap();
                                outputsAdjacency(graph);
                                listBoxMatrix.Items.Clear();
                                int degree = 0;
                                for (int j = 0; j < vertexes_2.Count; j++)
                                    degree += AdjacencyMatrix[selected_1, j];
                                listBoxMatrix.Items.Add("Степень вершины №" + (selected_1 + 1) + " равна " + degree);
                                break;
                            }
                        }
                    }
                }
            }
            if (add_vertex_button.Enabled == false)
            {
                if (graph)
                {
                    if(vertexes_1.Count < 20)
                    {
                        color_1.Add(-1);
                        vertexes_1.Add(new Vertex(e.X, e.Y));
                        rendering_1.drawVertex(e.X, e.Y, vertexes_1.Count.ToString());
                        sheet.Image = rendering_1.GetBitmap();
                    }
                }
                else
                {
                    if (vertexes_2.Count < 20)
                    {
                        color_2.Add(-1);
                        vertexes_2.Add(new Vertex(e.X, e.Y));
                        rendering_2.drawVertex(e.X, e.Y, vertexes_1.Count.ToString());
                        sheet.Image = rendering_2.GetBitmap();
                    }
                }
            }
            if (add_edge_button.Enabled == false)
            {
                if (graph)
                {
                    if (edges_1.Count < 50)
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            for (int i = 0; i < vertexes_1.Count; i++)
                            {
                                if (Math.Pow((vertexes_1[i].x - e.X), 2) + Math.Pow((vertexes_1[i].y - e.Y), 2) <= rendering_1.R * rendering_1.R)
                                {
                                    if (selected_1 == -1)
                                    {
                                        rendering_1.drawSelectedVertex(vertexes_1[i].x, vertexes_1[i].y);
                                        selected_1 = i;
                                        sheet.Image = rendering_1.GetBitmap();
                                        break;
                                    }
                                    if (selected_2 == -1)
                                    {
                                        rendering_1.drawSelectedVertex(vertexes_1[i].x, vertexes_1[i].y);
                                        selected_2 = i;
                                        edges_1.Add(new Edge(selected_1, selected_2));
                                        rendering_1.drawEdge(vertexes_1[selected_1], vertexes_1[selected_2], edges_1[edges_1.Count - 1], edges_1.Count - 1);
                                        selected_1 = -1;
                                        selected_2 = -1;
                                        sheet.Image = rendering_1.GetBitmap();
                                        break;
                                    }
                                }
                            }
                        }
                        if (e.Button == MouseButtons.Right)
                        {
                            if ((selected_1 != -1) &&
                                (Math.Pow((vertexes_1[selected_1].x - e.X), 2) + Math.Pow((vertexes_1[selected_1].y - e.Y), 2) <= rendering_1.R * rendering_1.R))
                            {
                                rendering_1.drawVertex(vertexes_1[selected_1].x, vertexes_1[selected_1].y, (selected_1 + 1).ToString());
                                selected_1 = -1;
                                sheet.Image = rendering_1.GetBitmap();
                            }
                        }
                    }
                }
                else
                {
                    if (edges_2.Count < 50)
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            for (int i = 0; i < vertexes_2.Count; i++)
                            {
                                if (Math.Pow((vertexes_2[i].x - e.X), 2) + Math.Pow((vertexes_2[i].y - e.Y), 2) <= rendering_2.R * rendering_2.R)
                                {
                                    if (selected_1 == -1)
                                    {
                                        rendering_2.drawSelectedVertex(vertexes_2[i].x, vertexes_2[i].y);
                                        selected_1 = i;
                                        sheet.Image = rendering_2.GetBitmap();
                                        break;
                                    }
                                    if (selected_2 == -1)
                                    {
                                        rendering_2.drawSelectedVertex(vertexes_2[i].x, vertexes_2[i].y);
                                        selected_2 = i;
                                        edges_2.Add(new Edge(selected_1, selected_2));
                                        rendering_2.drawEdge(vertexes_2[selected_1], vertexes_2[selected_2], edges_2[edges_2.Count - 1], edges_2.Count - 1);
                                        selected_1 = -1;
                                        selected_2 = -1;
                                        sheet.Image = rendering_2.GetBitmap();
                                        break;
                                    }
                                }
                            }
                        }
                        if (e.Button == MouseButtons.Right)
                        {
                            if ((selected_1 != -1) &&
                                (Math.Pow((vertexes_2[selected_1].x - e.X), 2) + Math.Pow((vertexes_2[selected_1].y - e.Y), 2) <= rendering_2.R * rendering_2.R))
                            {
                                rendering_2.drawVertex(vertexes_2[selected_1].x, vertexes_2[selected_1].y, (selected_1 + 1).ToString());
                                selected_1 = -1;
                                sheet.Image = rendering_2.GetBitmap();
                            }
                        }
                    }
                }
            }
            if (delete_vertex_button.Enabled == false)
            {
                if (graph)
                {
                    bool flag = false; 
                    for (int i = 0; i < vertexes_1.Count; i++)
                    {
                        if (Math.Pow((vertexes_1[i].x - e.X), 2) + Math.Pow((vertexes_1[i].y - e.Y), 2) <= rendering_1.R * rendering_1.R)
                        {
                            for (int j = 0; j < edges_1.Count; j++)
                            {
                                if ((edges_1[j].v1 == i) || (edges_1[j].v2 == i))
                                {
                                    edges_1.RemoveAt(j);
                                    j--;
                                }
                                else
                                {
                                    if (edges_1[j].v1 > i) edges_1[j].v1--;
                                    if (edges_1[j].v2 > i) edges_1[j].v2--;
                                }
                            }
                            vertexes_1.RemoveAt(i);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        for (int i = 0; i < edges_1.Count; i++)
                        {
                            if (edges_1[i].v1 == edges_1[i].v2)
                            {
                                if ((Math.Pow((vertexes_1[edges_1[i].v1].x - rendering_1.R - e.X), 2) + Math.Pow((vertexes_1[edges_1[i].v1].y - rendering_1.R - e.Y), 2) <= ((rendering_1.R + 2) * (rendering_1.R + 2))) &&
                                    (Math.Pow((vertexes_1[edges_1[i].v1].x - rendering_1.R - e.X), 2) + Math.Pow((vertexes_1[edges_1[i].v1].y - rendering_1.R - e.Y), 2) >= ((rendering_1.R - 2) * (rendering_1.R - 2))))
                                {
                                    edges_1.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                            else
                            {
                                if (((e.X - vertexes_1[edges_1[i].v1].x) * (vertexes_1[edges_1[i].v2].y - vertexes_1[edges_1[i].v1].y) / (vertexes_1[edges_1[i].v2].x - vertexes_1[edges_1[i].v1].x) + vertexes_1[edges_1[i].v1].y) <= (e.Y + 4) &&
                                    ((e.X - vertexes_1[edges_1[i].v1].x) * (vertexes_1[edges_1[i].v2].y - vertexes_1[edges_1[i].v1].y) / (vertexes_1[edges_1[i].v2].x - vertexes_1[edges_1[i].v1].x) + vertexes_1[edges_1[i].v1].y) >= (e.Y - 4))
                                {
                                    if ((vertexes_1[edges_1[i].v1].x <= vertexes_1[edges_1[i].v2].x && vertexes_1[edges_1[i].v1].x <= e.X && e.X <= vertexes_1[edges_1[i].v2].x) ||
                                        (vertexes_1[edges_1[i].v1].x >= vertexes_1[edges_1[i].v2].x && vertexes_1[edges_1[i].v1].x >= e.X && e.X >= vertexes_1[edges_1[i].v2].x))
                                    {
                                        edges_1.RemoveAt(i);
                                        flag = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (flag)
                    {
                        rendering_1.clearSheet();
                        if (graph)
                        {
                            rendering_1.drawALLGraph(vertexes_1, edges_1);
                        }
                        else
                        {
                            rendering_1.drawALLGraph(vertexes_2, edges_2);
                        }
                        sheet.Image = rendering_1.GetBitmap();
                    }
                }
                else
                {
                    bool flag = false; 
                    for (int i = 0; i < vertexes_2.Count; i++)
                    {
                        if (Math.Pow((vertexes_2[i].x - e.X), 2) + Math.Pow((vertexes_2[i].y - e.Y), 2) <= rendering_2.R * rendering_2.R)
                        {
                            for (int j = 0; j < edges_2.Count; j++)
                            {
                                if ((edges_2[j].v1 == i) || (edges_2[j].v2 == i))
                                {
                                    edges_2.RemoveAt(j);
                                    j--;
                                }
                                else
                                {
                                    if (edges_2[j].v1 > i) edges_2[j].v1--;
                                    if (edges_2[j].v2 > i) edges_2[j].v2--;
                                }
                            }
                            vertexes_2.RemoveAt(i);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        for (int i = 0; i < edges_1.Count; i++)
                        {
                            if (edges_1[i].v1 == edges_1[i].v2)
                            {
                                if ((Math.Pow((vertexes_2[edges_1[i].v1].x - rendering_2.R - e.X), 2) + Math.Pow((vertexes_2[edges_1[i].v1].y - rendering_2.R - e.Y), 2) <= ((rendering_2.R + 2) * (rendering_2.R + 2))) &&
                                    (Math.Pow((vertexes_2[edges_1[i].v1].x - rendering_2.R - e.X), 2) + Math.Pow((vertexes_2[edges_1[i].v1].y - rendering_2.R - e.Y), 2) >= ((rendering_2.R - 2) * (rendering_2.R - 2))))
                                {
                                    edges_2.RemoveAt(i);
                                    flag = true;
                                    break;
                                }
                            }
                            else
                            {
                                if (((e.X - vertexes_2[edges_1[i].v1].x) * (vertexes_2[edges_1[i].v2].y - vertexes_2[edges_1[i].v1].y) / (vertexes_2[edges_1[i].v2].x - vertexes_2[edges_1[i].v1].x) + vertexes_2[edges_1[i].v1].y) <= (e.Y + 4) &&
                                    ((e.X - vertexes_2[edges_1[i].v1].x) * (vertexes_2[edges_1[i].v2].y - vertexes_2[edges_1[i].v1].y) / (vertexes_2[edges_1[i].v2].x - vertexes_2[edges_1[i].v1].x) + vertexes_2[edges_1[i].v1].y) >= (e.Y - 4))
                                {
                                    if ((vertexes_2[edges_1[i].v1].x <= vertexes_2[edges_1[i].v2].x && vertexes_2[edges_1[i].v1].x <= e.X && e.X <= vertexes_2[edges_1[i].v2].x) ||
                                        (vertexes_2[edges_1[i].v1].x >= vertexes_2[edges_1[i].v2].x && vertexes_2[edges_1[i].v1].x >= e.X && e.X >= vertexes_2[edges_1[i].v2].x))
                                    {
                                        edges_2.RemoveAt(i);
                                        flag = true;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    if (flag)
                    {
                        rendering_2.clearSheet();
                        if (graph)
                        {
                            rendering_2.drawALLGraph(vertexes_1, edges_1);
                        }
                        else
                        {
                            rendering_2.drawALLGraph(vertexes_2, edges_2);
                        }
                        sheet.Image = rendering_2.GetBitmap();
                    }
                }
            }
        }
        
        public void outputsAdjacency(bool m_graph)
        {
            if (m_graph)
            {
                AdjacencyMatrix = new int[vertexes_1.Count, vertexes_1.Count];
                rendering_1.fillAdjacencyMatrix(vertexes_1.Count, edges_1, AdjacencyMatrix);
                listBoxMatrix.Items.Clear();
                string sOut = "      ";
                for (int i = 0; i < vertexes_1.Count; i++)
                    sOut += (i + 1) + " ";
                listBoxMatrix.Items.Add(sOut);
                for (int i = 0; i < vertexes_1.Count; i++)
                {
                    if (i < 9) {
                        sOut = "  " + (i + 1) + " | ";
                    }
                    else
                    {
                        sOut = (i + 1) + " | ";
                    }
                    for (int j = 0; j < vertexes_1.Count; j++)
                    {
                        sOut += AdjacencyMatrix[i, j] + " ";
                        if (j >= 9) {
                            sOut += "  ";
                        }
                    }
                    listBoxMatrix.Items.Add(sOut);
                }
            }
            else
            {
                AdjacencyMatrix = new int[vertexes_2.Count, vertexes_2.Count];
                rendering_2.fillAdjacencyMatrix(vertexes_2.Count, edges_2, AdjacencyMatrix);
                listBoxMatrix.Items.Clear();
                string sOut = "    ";
                for (int i = 0; i < vertexes_2.Count; i++)
                    sOut += (i + 1) + " ";
                listBoxMatrix.Items.Add(sOut);
                for (int i = 0; i < vertexes_2.Count; i++)
                {
                    if (i < 9)
                    {
                        sOut = "  " + (i + 1) + " | ";
                    }
                    else
                    {
                        sOut = (i + 1) + " | ";
                    }
                    for (int j = 0; j < vertexes_2.Count; j++)
                    {
                        sOut += AdjacencyMatrix[i, j] + " ";
                        if (j >= 9)
                        {
                            sOut += "  ";
                        }
                    }
                    listBoxMatrix.Items.Add(sOut);
                }
            }
        }
        
        public void createIncAndOut(bool m_graph)
        {
            if (m_graph)
            {
                if (edges_1.Count > 0)
                {
                    IncidenceMatrix = new int[vertexes_1.Count, edges_1.Count];
                    rendering_1.fillIncidenceMatrix(vertexes_1.Count, edges_1, IncidenceMatrix);
                    listBoxMatrix.Items.Clear();
                    string sOut = "    ";
                    for (int i = 0; i < edges_1.Count; i++)
                        sOut += (char)('a' + i) + " ";
                    listBoxMatrix.Items.Add(sOut);
                    for (int i = 0; i < vertexes_1.Count; i++)
                    {
                        sOut = (i + 1) + " | ";
                        for (int j = 0; j < edges_1.Count; j++)
                            sOut += IncidenceMatrix[i, j] + " ";
                        listBoxMatrix.Items.Add(sOut);
                    }
                }
                else
                    listBoxMatrix.Items.Clear();
            }
            else
            {
                if (edges_2.Count > 0)
                {
                    IncidenceMatrix = new int[vertexes_2.Count, edges_2.Count];
                    rendering_2.fillIncidenceMatrix(vertexes_2.Count, edges_2, IncidenceMatrix);
                    listBoxMatrix.Items.Clear();
                    string sOut = "    ";
                    for (int i = 0; i < edges_2.Count; i++)
                        sOut += (char)('a' + i) + " ";
                    listBoxMatrix.Items.Add(sOut);
                    for (int i = 0; i < vertexes_2.Count; i++)
                    {
                        sOut = (i + 1) + " | ";
                        for (int j = 0; j < edges_2.Count; j++)
                            sOut += IncidenceMatrix[i, j] + " ";
                        listBoxMatrix.Items.Add(sOut);
                    }
                }
                else
                    listBoxMatrix.Items.Clear();
            }
        }
        
        public void chainButton_Click(object sender, EventArgs e)
        {

            if (graph)
            {
                listBoxMatrix.Items.Clear();
                int[] color = new int[vertexes_1.Count];
                for (int i = 0; i < vertexes_1.Count - 1; i++)
                    for (int j = i + 1; j < vertexes_1.Count; j++)
                    {
                        for (int k = 0; k < vertexes_1.Count; k++)
                            color[k] = 1;
                        DFSchain(i, j, edges_1, color, (i + 1).ToString());
                    }
            }
            else
            {
                listBoxMatrix.Items.Clear();
                int[] color = new int[vertexes_2.Count];
                for (int i = 0; i < vertexes_2.Count - 1; i++)
                    for (int j = i + 1; j < vertexes_2.Count; j++)
                    {
                        for (int k = 0; k < vertexes_2.Count; k++)
                            color[k] = 1;
                        DFSchain(i, j, edges_2, color, (i + 1).ToString());
                    }
            }
        }
        
        public void DFSchain(int u, int endV, List<Edge> E, int[] color, string s)
        {
            if (u != endV)
                color[u] = 2;
            else
            {
                listBoxMatrix.Items.Add(s);
                return;
            }
            for (int w = 0; w < E.Count; w++)
            {
                if (color[E[w].v2] == 1 && E[w].v1 == u)
                {
                    DFSchain(E[w].v2, endV, E, color, s + "-" + (E[w].v2 + 1).ToString());
                    color[E[w].v2] = 1;
                }
                else if (color[E[w].v1] == 1 && E[w].v2 == u)
                {
                    DFSchain(E[w].v1, endV, E, color, s + "-" + (E[w].v1 + 1).ToString());
                    color[E[w].v1] = 1;
                }
            }
        }
        
        public void cycleButton_Click(object sender, EventArgs e)
        {
            if (graph)
            {
                listBoxMatrix.Items.Clear();
                int[] color = new int[vertexes_1.Count];
                for (int i = 0; i < vertexes_1.Count; i++)
                {
                    for (int k = 0; k < vertexes_1.Count; k++)
                        color[k] = 1;
                    List<int> cycle = new List<int>();
                    cycle.Add(i + 1);
                    DFScycle(i, i, edges_1, color, -1, cycle);
                }
            }
            else
            {
                listBoxMatrix.Items.Clear();
                int[] color = new int[vertexes_2.Count];
                for (int i = 0; i < vertexes_2.Count; i++)
                {
                    for (int k = 0; k < vertexes_2.Count; k++)
                        color[k] = 1;
                    List<int> cycle = new List<int>();
                    cycle.Add(i + 1);
                    DFScycle(i, i, edges_2, color, -1, cycle);
                }
            }
        }
        
        public void DFScycle(int u, int endV, List<Edge> E, int[] color, int unavailableEdge, List<int> cycle)
        {
            if (u != endV)
                color[u] = 2;
            else
            {
                if (cycle.Count >= 2)
                {
                    cycle.Reverse();
                    string s = cycle[0].ToString();
                    for (int i = 1; i < cycle.Count; i++)
                        s += "-" + cycle[i].ToString();
                    bool flag = false;
                    for (int i = 0; i < listBoxMatrix.Items.Count; i++)
                        if (listBoxMatrix.Items[i].ToString() == s)
                        {
                            flag = true;
                            break;
                        }
                    if (!flag)
                    {
                        cycle.Reverse();
                        s = cycle[0].ToString();
                        for (int i = 1; i < cycle.Count; i++)
                            s += "-" + cycle[i].ToString();
                        listBoxMatrix.Items.Add(s);
                    }
                    return;
                }
            }
            for (int w = 0; w < E.Count; w++)
            {
                if (w == unavailableEdge)
                    continue;
                if (color[E[w].v2] == 1 && E[w].v1 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(E[w].v2 + 1);
                    DFScycle(E[w].v2, endV, E, color, w, cycleNEW);
                    color[E[w].v2] = 1;
                }
                else if (color[E[w].v1] == 1 && E[w].v2 == u)
                {
                    List<int> cycleNEW = new List<int>(cycle);
                    cycleNEW.Add(E[w].v1 + 1);
                    DFScycle(E[w].v1, endV, E, color, w, cycleNEW);
                    color[E[w].v1] = 1;
                }
            }
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            if (sheet.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        sheet.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void change_graph_button_Click(object sender, EventArgs e)
        {
            graph = !graph;
            rendering_1.clearSheet();
            if (graph)
            {
                change_graph_button.Text = "2";
                rendering_1.drawALLGraph(vertexes_1, edges_1);
                Graph1.Visible = true;
                Graph2.Visible = false;
            }
            else
            {
                change_graph_button.Text = "1";
                rendering_1.drawALLGraph(vertexes_2, edges_2);
                Graph2.Visible = true;
                Graph1.Visible = false;
            }

            sheet.Image = rendering_1.GetBitmap();
        }
        public void addEdge(List<List<int>> adj, Edge i)
        {
            adj[i.v1].Add(i.v2);
            adj[i.v2].Add(i.v1);
        }

        public void equivalence_button_Click(object sender, EventArgs e)
        {
            List<List<int>> adj = new List<List<int>>(vertexes_1.Count + 1);
            List<List<int>> adj_1 = new List<List<int>>(vertexes_1.Count + 1);
            for (int i = 0; i <= vertexes_1.Count; i++)
            {
                adj.Add(new List<int>());
            }
            for (int i = 0; i <= vertexes_2.Count; i++)
            {
                adj_1.Add(new List<int>());
            }

            for (int i = 0; i < color_1.Count; i++)
            {
                color_1[i] = -1;
            }

            for (int i = 0; i < color_2.Count; i++)
            {
                color_2[i] = -1;
            }
                
            color_1[1] = 0;
            color_2[1] = 0;
            bool[] visited = new bool[vertexes_1.Count + 1];
            bool[] visited_1 = new bool[vertexes_2.Count + 1];
            visited[1] = true;
            visited_1[1] = true;

            foreach (Edge i in edges_1)
            {
                addEdge(adj, i);
            }

            foreach (Edge i in edges_2)
            {
                addEdge(adj_1, i);
            }
            bool graph_1 = isBipartite(adj, 1, visited, color_1);
            bool graph_2 = isBipartite(adj_1, 1, visited_1, color_2);
            if (graph_1 && graph_2)
            {
                Result.Text = "Граф 1: Двудольный;\r\nГраф 2: Двудольный;\r\n";
            }
            else if (graph_1 && !graph_2)
            {
                Result.Text = "Граф 1: Двудольный;\r\nГраф 2: Не двудольный;\r\n";
            }
            else if (!graph_1 && graph_2)
            {
                Result.Text = "Граф 1: Не двудольный;\r\nГраф 2: Двудольный;\r\n";
            }
            else if (!graph_1 && !graph_2)
            {
                Result.Text = "Граф 1: Не двудольный;\r\nГраф 2: Не двудольный;\r\n";
            }
            if (isBipartite(adj, 1, visited, color_1) == isBipartite(adj_1, 1, visited_1, color_2))
            {
                Result.Text += "Графы еквивалентны.";
            }
            else
            {
                Result.Text += "Графы не еквивалентны.";
            }
        }
        public string get_result()
        {
            return Result.Text;
        }
        public bool isBipartite(List<List<int>> adj, int v, bool[] visited, List<int> color)
        {
            foreach (int u in adj[v])
            {
                if (visited[u] == false)
                {
                    visited[u] = true;
                    color[u] = 1 - color[v];
                    if (!isBipartite(adj, u, visited, color))
                        return false;
                }
                else if (color[u] == color[v])
                    return false;
            }
            return true;
        }

        public void read_file_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Чтение графa...";
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text Files(*.TXT)|*.txt|All files (*.*)|*.*";
            openFileDialog.ShowHelp = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    List<List<int>> position1 = new List<List<int>>();
                    List<List<int>> position2 = new List<List<int>>();
                    List<int> mass_g1 = new List<int>();
                    List<int> mass_p1 = new List<int>();
                    List<int> mass_g2 = new List<int>();
                    List<int> mass_p2 = new List<int>();
                    while ((line = reader.ReadLine()) != null)
                    {
                        List<int> temp = new List<int>();
                        List<string> s_temp = new List<string>(line.Split(' '));
                        switch (s_temp[0])
                        {
                            case "G1":
                                s_temp.RemoveAt(0);
                                foreach (string s in s_temp)
                                {
                                    mass_g1.Add(int.Parse(s));
                                }
                                break;
                            case "G2":
                                s_temp.RemoveAt(0);
                                foreach (string s in s_temp)
                                {
                                    mass_g2.Add(int.Parse(s));
                                }

                                break;
                            case "P1":
                                s_temp.RemoveAt(0);
                                foreach (string s in s_temp)
                                {
                                    mass_p1.Add(int.Parse(s));
                                }

                                break;
                            case "P2":
                                s_temp.RemoveAt(0);
                                foreach (string s in s_temp)
                                {
                                    mass_p2.Add(int.Parse(s));
                                }

                                break;
                            case "POS1":
                                s_temp.RemoveAt(0);
                                foreach (string s in s_temp)
                                {
                                    temp.Add(int.Parse(s));
                                }
                                position1.Add(temp);
                                break;
                            case "POS2":
                                s_temp.RemoveAt(0);
                                foreach (string s in s_temp)
                                {
                                    temp.Add(int.Parse(s));
                                }
                                position2.Add(temp);
                                break;
                        }
                    }
                    vertexes_1.Clear();
                    edges_1.Clear();
                    color_1.Clear();
                    rendering_1.clearSheet();
                    vertexes_2.Clear();
                    edges_2.Clear();
                    color_2.Clear();
                    rendering_2.clearSheet();
                    foreach (List<int> p1 in position1)
                    {
                        color_1.Add(-1);
                        vertexes_1.Add(new Vertex(p1[0], p1[1]));
                    }
                    foreach (List<int> p2 in position2)
                    {
                        color_2.Add(-1);
                        vertexes_2.Add(new Vertex(p2[0], p2[1]));
                    }
                    int i = 0;
                    int index = 0;
                    foreach (int p in mass_p1)
                    {
                        for (; i < p; i++)
                        {
                            edges_1.Add(new Edge(index, mass_g1[i] - 1));
                        }
                        index++;
                    }
                    i = 0;
                    index = 0;
                    foreach (int p in mass_p2)
                    {
                        for (; i < p; i++)
                        {
                            edges_2.Add(new Edge(index, mass_g2[i] - 1));
                        }
                        index++;
                    }

                    if (graph)
                    {
                        rendering_1.drawALLGraph(vertexes_1, edges_1);
                        sheet.Image = rendering_1.GetBitmap();
                    }
                    else
                    {
                        rendering_2.drawALLGraph(vertexes_2, edges_2);
                        sheet.Image = rendering_2.GetBitmap();
                    }
                }
            }
        }
    }
}