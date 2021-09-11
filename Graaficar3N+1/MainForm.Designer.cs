
namespace Graaficar3N_1
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InsertNum_Button = new Guna.UI2.WinForms.Guna2Button();
            this.TopPannel = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WaitingLabel = new System.Windows.Forms.Label();
            this.Waiting_Panel = new System.Windows.Forms.Panel();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            ((System.ComponentModel.ISupportInitialize)(this.TopPannel)).BeginInit();
            this.TopPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.Waiting_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertNum_Button
            // 
            this.InsertNum_Button.Animated = true;
            this.InsertNum_Button.CheckedState.Parent = this.InsertNum_Button;
            this.InsertNum_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertNum_Button.CustomImages.Parent = this.InsertNum_Button;
            this.InsertNum_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InsertNum_Button.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNum_Button.ForeColor = System.Drawing.Color.White;
            this.InsertNum_Button.HoverState.Parent = this.InsertNum_Button;
            this.InsertNum_Button.Location = new System.Drawing.Point(0, 414);
            this.InsertNum_Button.Name = "InsertNum_Button";
            this.InsertNum_Button.ShadowDecoration.Parent = this.InsertNum_Button;
            this.InsertNum_Button.Size = new System.Drawing.Size(800, 36);
            this.InsertNum_Button.TabIndex = 0;
            this.InsertNum_Button.Text = "Insertar número para graficar.";
            this.InsertNum_Button.Click += new System.EventHandler(this.InsertNum_Button_Click);
            // 
            // TopPannel
            // 
            this.TopPannel.AddNewItem = null;
            this.TopPannel.CountItem = null;
            this.TopPannel.DeleteItem = null;
            this.TopPannel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.TopPannel.Location = new System.Drawing.Point(0, 0);
            this.TopPannel.MoveFirstItem = null;
            this.TopPannel.MoveLastItem = null;
            this.TopPannel.MoveNextItem = null;
            this.TopPannel.MovePreviousItem = null;
            this.TopPannel.Name = "TopPannel";
            this.TopPannel.PositionItem = null;
            this.TopPannel.Size = new System.Drawing.Size(800, 25);
            this.TopPannel.TabIndex = 1;
            this.TopPannel.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "X";
            this.toolStripButton1.ToolTipText = "Salir de la aplicación";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this.TopPannel;
            // 
            // chart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(0, 25);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(800, 389);
            this.chart.TabIndex = 2;
            this.chart.Visible = false;
            // 
            // WaitingLabel
            // 
            this.WaitingLabel.AutoSize = true;
            this.WaitingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.WaitingLabel.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingLabel.Location = new System.Drawing.Point(10, 35);
            this.WaitingLabel.Name = "WaitingLabel";
            this.WaitingLabel.Size = new System.Drawing.Size(444, 27);
            this.WaitingLabel.TabIndex = 3;
            this.WaitingLabel.Text = "Esperando alguna interacción con el gráfico.";
            // 
            // Waiting_Panel
            // 
            this.Waiting_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Waiting_Panel.Controls.Add(this.guna2ProgressIndicator1);
            this.Waiting_Panel.Controls.Add(this.WaitingLabel);
            this.Waiting_Panel.Location = new System.Drawing.Point(174, 127);
            this.Waiting_Panel.Name = "Waiting_Panel";
            this.Waiting_Panel.Size = new System.Drawing.Size(463, 183);
            this.Waiting_Panel.TabIndex = 4;
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.AutoStart = true;
            this.guna2ProgressIndicator1.CircleSize = 1F;
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(189, 79);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2ProgressIndicator1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Waiting_Panel);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.TopPannel);
            this.Controls.Add(this.InsertNum_Button);
            this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3N + 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopPannel)).EndInit();
            this.TopPannel.ResumeLayout(false);
            this.TopPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.Waiting_Panel.ResumeLayout(false);
            this.Waiting_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button InsertNum_Button;
        private System.Windows.Forms.BindingNavigator TopPannel;
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label WaitingLabel;
        private System.Windows.Forms.Panel Waiting_Panel;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
    }
}

