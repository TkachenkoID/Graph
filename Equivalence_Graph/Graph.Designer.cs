namespace Equivalence_Graph
{
    partial class Graph
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxMatrix = new System.Windows.Forms.ListBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Graph1 = new System.Windows.Forms.Label();
            this.Graph2 = new System.Windows.Forms.Label();
            this.change_graph_button = new System.Windows.Forms.Button();
            this.equivalence_button = new System.Windows.Forms.Button();
            this.read_file_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.search_cycles_button = new System.Windows.Forms.Button();
            this.search_chains_button = new System.Windows.Forms.Button();
            this.mouse_button = new System.Windows.Forms.Button();
            this.incident_matrix_button = new System.Windows.Forms.Button();
            this.adjacency_matrix_button = new System.Windows.Forms.Button();
            this.delete_graph_button = new System.Windows.Forms.Button();
            this.delete_vertex_button = new System.Windows.Forms.Button();
            this.add_edge_button = new System.Windows.Forms.Button();
            this.add_vertex_button = new System.Windows.Forms.Button();
            this.sheet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMatrix
            // 
            this.listBoxMatrix.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listBoxMatrix.FormattingEnabled = true;
            this.listBoxMatrix.ItemHeight = 16;
            this.listBoxMatrix.Location = new System.Drawing.Point(876, 89);
            this.listBoxMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxMatrix.Name = "listBoxMatrix";
            this.listBoxMatrix.Size = new System.Drawing.Size(438, 596);
            this.listBoxMatrix.TabIndex = 6;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.PaleGreen;
            this.Result.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(13, 604);
            this.Result.Margin = new System.Windows.Forms.Padding(4);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(845, 80);
            this.Result.TabIndex = 14;
            // 
            // Graph1
            // 
            this.Graph1.AutoSize = true;
            this.Graph1.BackColor = System.Drawing.Color.White;
            this.Graph1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Graph1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Graph1.Location = new System.Drawing.Point(24, 89);
            this.Graph1.Name = "Graph1";
            this.Graph1.Size = new System.Drawing.Size(128, 44);
            this.Graph1.TabIndex = 20;
            this.Graph1.Text = "Граф 1";
            // 
            // Graph2
            // 
            this.Graph2.AutoSize = true;
            this.Graph2.BackColor = System.Drawing.Color.White;
            this.Graph2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graph2.Location = new System.Drawing.Point(24, 89);
            this.Graph2.Name = "Graph2";
            this.Graph2.Size = new System.Drawing.Size(128, 44);
            this.Graph2.TabIndex = 21;
            this.Graph2.Text = "Граф 2";
            this.Graph2.Visible = false;
            // 
            // change_graph_button
            // 
            this.change_graph_button.BackColor = System.Drawing.Color.White;
            this.change_graph_button.Font = new System.Drawing.Font("Nexa Script Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_graph_button.Location = new System.Drawing.Point(337, 13);
            this.change_graph_button.Margin = new System.Windows.Forms.Padding(4);
            this.change_graph_button.Name = "change_graph_button";
            this.change_graph_button.Size = new System.Drawing.Size(73, 66);
            this.change_graph_button.TabIndex = 18;
            this.change_graph_button.Text = "2";
            this.change_graph_button.UseVisualStyleBackColor = false;
            this.change_graph_button.Click += new System.EventHandler(this.change_graph_button_Click);
            // 
            // equivalence_button
            // 
            this.equivalence_button.BackColor = System.Drawing.Color.White;
            this.equivalence_button.Image = global::Equivalence_Graph.Properties.Resources.ekv;
            this.equivalence_button.Location = new System.Drawing.Point(785, 13);
            this.equivalence_button.Margin = new System.Windows.Forms.Padding(4);
            this.equivalence_button.Name = "equivalence_button";
            this.equivalence_button.Size = new System.Drawing.Size(73, 66);
            this.equivalence_button.TabIndex = 19;
            this.equivalence_button.UseVisualStyleBackColor = false;
            this.equivalence_button.Click += new System.EventHandler(this.equivalence_button_Click);
            // 
            // read_file_button
            // 
            this.read_file_button.BackColor = System.Drawing.Color.White;
            this.read_file_button.Image = global::Equivalence_Graph.Properties.Resources.load;
            this.read_file_button.Location = new System.Drawing.Point(1016, 8);
            this.read_file_button.Margin = new System.Windows.Forms.Padding(4);
            this.read_file_button.Name = "read_file_button";
            this.read_file_button.Size = new System.Drawing.Size(158, 74);
            this.read_file_button.TabIndex = 15;
            this.read_file_button.UseVisualStyleBackColor = false;
            this.read_file_button.Click += new System.EventHandler(this.read_file_button_Click);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.White;
            this.save_button.Image = global::Equivalence_Graph.Properties.Resources.save1;
            this.save_button.Location = new System.Drawing.Point(499, 13);
            this.save_button.Margin = new System.Windows.Forms.Padding(4);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(73, 68);
            this.save_button.TabIndex = 13;
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // search_cycles_button
            // 
            this.search_cycles_button.BackColor = System.Drawing.Color.White;
            this.search_cycles_button.Image = global::Equivalence_Graph.Properties.Resources.cycle;
            this.search_cycles_button.Location = new System.Drawing.Point(684, 13);
            this.search_cycles_button.Margin = new System.Windows.Forms.Padding(4);
            this.search_cycles_button.Name = "search_cycles_button";
            this.search_cycles_button.Size = new System.Drawing.Size(96, 67);
            this.search_cycles_button.TabIndex = 11;
            this.search_cycles_button.UseVisualStyleBackColor = false;
            this.search_cycles_button.Click += new System.EventHandler(this.cycleButton_Click);
            // 
            // search_chains_button
            // 
            this.search_chains_button.BackColor = System.Drawing.Color.White;
            this.search_chains_button.Image = global::Equivalence_Graph.Properties.Resources.chain;
            this.search_chains_button.Location = new System.Drawing.Point(580, 13);
            this.search_chains_button.Margin = new System.Windows.Forms.Padding(4);
            this.search_chains_button.Name = "search_chains_button";
            this.search_chains_button.Size = new System.Drawing.Size(96, 68);
            this.search_chains_button.TabIndex = 10;
            this.search_chains_button.UseVisualStyleBackColor = false;
            this.search_chains_button.Click += new System.EventHandler(this.chainButton_Click);
            // 
            // mouse_button
            // 
            this.mouse_button.BackColor = System.Drawing.Color.White;
            this.mouse_button.Image = global::Equivalence_Graph.Properties.Resources.cursor;
            this.mouse_button.Location = new System.Drawing.Point(13, 13);
            this.mouse_button.Margin = new System.Windows.Forms.Padding(4);
            this.mouse_button.Name = "mouse_button";
            this.mouse_button.Size = new System.Drawing.Size(73, 65);
            this.mouse_button.TabIndex = 9;
            this.mouse_button.UseVisualStyleBackColor = false;
            this.mouse_button.Click += new System.EventHandler(this.selectVertexButton_Click);
            // 
            // incident_matrix_button
            // 
            this.incident_matrix_button.BackColor = System.Drawing.Color.White;
            this.incident_matrix_button.Image = global::Equivalence_Graph.Properties.Resources.inc;
            this.incident_matrix_button.Location = new System.Drawing.Point(1182, 9);
            this.incident_matrix_button.Margin = new System.Windows.Forms.Padding(4);
            this.incident_matrix_button.Name = "incident_matrix_button";
            this.incident_matrix_button.Size = new System.Drawing.Size(132, 73);
            this.incident_matrix_button.TabIndex = 8;
            this.incident_matrix_button.UseVisualStyleBackColor = false;
            this.incident_matrix_button.Click += new System.EventHandler(this.incidenceButton_Click);
            // 
            // adjacency_matrix_button
            // 
            this.adjacency_matrix_button.BackColor = System.Drawing.Color.White;
            this.adjacency_matrix_button.Image = global::Equivalence_Graph.Properties.Resources.smezh;
            this.adjacency_matrix_button.Location = new System.Drawing.Point(876, 8);
            this.adjacency_matrix_button.Margin = new System.Windows.Forms.Padding(4);
            this.adjacency_matrix_button.Name = "adjacency_matrix_button";
            this.adjacency_matrix_button.Size = new System.Drawing.Size(132, 73);
            this.adjacency_matrix_button.TabIndex = 7;
            this.adjacency_matrix_button.UseVisualStyleBackColor = false;
            this.adjacency_matrix_button.Click += new System.EventHandler(this.adjacencyButton_Click);
            // 
            // delete_graph_button
            // 
            this.delete_graph_button.BackColor = System.Drawing.Color.White;
            this.delete_graph_button.Image = global::Equivalence_Graph.Properties.Resources.delete2;
            this.delete_graph_button.Location = new System.Drawing.Point(418, 13);
            this.delete_graph_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_graph_button.Name = "delete_graph_button";
            this.delete_graph_button.Size = new System.Drawing.Size(73, 67);
            this.delete_graph_button.TabIndex = 5;
            this.delete_graph_button.UseVisualStyleBackColor = false;
            this.delete_graph_button.Click += new System.EventHandler(this.deleteGraphButton_Click);
            // 
            // delete_vertex_button
            // 
            this.delete_vertex_button.BackColor = System.Drawing.Color.White;
            this.delete_vertex_button.Image = global::Equivalence_Graph.Properties.Resources.delete1;
            this.delete_vertex_button.Location = new System.Drawing.Point(256, 13);
            this.delete_vertex_button.Margin = new System.Windows.Forms.Padding(4);
            this.delete_vertex_button.Name = "delete_vertex_button";
            this.delete_vertex_button.Size = new System.Drawing.Size(73, 66);
            this.delete_vertex_button.TabIndex = 3;
            this.delete_vertex_button.UseVisualStyleBackColor = false;
            this.delete_vertex_button.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // add_edge_button
            // 
            this.add_edge_button.BackColor = System.Drawing.Color.White;
            this.add_edge_button.Image = global::Equivalence_Graph.Properties.Resources.edge1;
            this.add_edge_button.Location = new System.Drawing.Point(175, 13);
            this.add_edge_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_edge_button.Name = "add_edge_button";
            this.add_edge_button.Size = new System.Drawing.Size(73, 66);
            this.add_edge_button.TabIndex = 2;
            this.add_edge_button.UseVisualStyleBackColor = false;
            this.add_edge_button.Click += new System.EventHandler(this.drawEdgeButton_Click);
            // 
            // add_vertex_button
            // 
            this.add_vertex_button.BackColor = System.Drawing.Color.White;
            this.add_vertex_button.Image = global::Equivalence_Graph.Properties.Resources.vertex1;
            this.add_vertex_button.Location = new System.Drawing.Point(94, 13);
            this.add_vertex_button.Margin = new System.Windows.Forms.Padding(4);
            this.add_vertex_button.Name = "add_vertex_button";
            this.add_vertex_button.Size = new System.Drawing.Size(73, 66);
            this.add_vertex_button.TabIndex = 1;
            this.add_vertex_button.UseVisualStyleBackColor = false;
            this.add_vertex_button.Click += new System.EventHandler(this.drawVertexButton_Click);
            // 
            // sheet
            // 
            this.sheet.BackColor = System.Drawing.Color.White;
            this.sheet.Location = new System.Drawing.Point(13, 85);
            this.sheet.Margin = new System.Windows.Forms.Padding(4);
            this.sheet.Name = "sheet";
            this.sheet.Size = new System.Drawing.Size(845, 511);
            this.sheet.TabIndex = 0;
            this.sheet.TabStop = false;
            this.sheet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sheet_MouseClick);
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1333, 697);
            this.Controls.Add(this.Graph2);
            this.Controls.Add(this.Graph1);
            this.Controls.Add(this.equivalence_button);
            this.Controls.Add(this.change_graph_button);
            this.Controls.Add(this.read_file_button);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.search_cycles_button);
            this.Controls.Add(this.search_chains_button);
            this.Controls.Add(this.mouse_button);
            this.Controls.Add(this.incident_matrix_button);
            this.Controls.Add(this.adjacency_matrix_button);
            this.Controls.Add(this.listBoxMatrix);
            this.Controls.Add(this.delete_graph_button);
            this.Controls.Add(this.delete_vertex_button);
            this.Controls.Add(this.add_edge_button);
            this.Controls.Add(this.add_vertex_button);
            this.Controls.Add(this.sheet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graph";
            this.Text = "Граф";
            ((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sheet;
        private System.Windows.Forms.Button add_vertex_button;
        private System.Windows.Forms.Button add_edge_button;
        private System.Windows.Forms.Button delete_vertex_button;
        private System.Windows.Forms.Button delete_graph_button;
        private System.Windows.Forms.ListBox listBoxMatrix;
        private System.Windows.Forms.Button adjacency_matrix_button;
        private System.Windows.Forms.Button incident_matrix_button;
        private System.Windows.Forms.Button mouse_button;
        private System.Windows.Forms.Button search_chains_button;
        private System.Windows.Forms.Button search_cycles_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button read_file_button;
        private System.Windows.Forms.Button change_graph_button;
        private System.Windows.Forms.Button equivalence_button;
        private System.Windows.Forms.Label Graph1;
        private System.Windows.Forms.Label Graph2;
    }
}

