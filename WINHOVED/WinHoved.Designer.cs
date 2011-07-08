namespace WINHOVED
{
    partial class WinHoved
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinHoved));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.simpleOpenGlControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.panelPlanets = new System.Windows.Forms.Panel();
            this.simpleOpenGlControlMini = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.btn_pause = new System.Windows.Forms.Button();
            this.propertyGridPlanet = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.comboBoxPlanet = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ctr = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_zoomin = new System.Windows.Forms.Button();
            this.btn_zoomreset = new System.Windows.Forms.Button();
            this.btn_zoomout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAxis = new System.Windows.Forms.CheckBox();
            this.checkBoxPlane = new System.Windows.Forms.CheckBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelPlanets.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.simpleOpenGlControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelPlanets);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(1272, 773);
            this.splitContainer1.SplitterDistance = 1000;
            this.splitContainer1.TabIndex = 2;
            // 
            // simpleOpenGlControl
            // 
            this.simpleOpenGlControl.AccumBits = ((byte)(0));
            this.simpleOpenGlControl.AutoCheckErrors = false;
            this.simpleOpenGlControl.AutoFinish = false;
            this.simpleOpenGlControl.AutoMakeCurrent = true;
            this.simpleOpenGlControl.AutoSwapBuffers = true;
            this.simpleOpenGlControl.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControl.ColorBits = ((byte)(32));
            this.simpleOpenGlControl.DepthBits = ((byte)(16));
            this.simpleOpenGlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleOpenGlControl.Location = new System.Drawing.Point(0, 0);
            this.simpleOpenGlControl.Name = "simpleOpenGlControl";
            this.simpleOpenGlControl.Size = new System.Drawing.Size(1000, 773);
            this.simpleOpenGlControl.StencilBits = ((byte)(0));
            this.simpleOpenGlControl.TabIndex = 2;
            this.simpleOpenGlControl.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl_Paint);
            // 
            // panelPlanets
            // 
            this.panelPlanets.Controls.Add(this.simpleOpenGlControlMini);
            this.panelPlanets.Controls.Add(this.btn_pause);
            this.panelPlanets.Controls.Add(this.propertyGridPlanet);
            this.panelPlanets.Controls.Add(this.tableLayoutPanel2);
            this.panelPlanets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlanets.Location = new System.Drawing.Point(0, 175);
            this.panelPlanets.Name = "panelPlanets";
            this.panelPlanets.Size = new System.Drawing.Size(268, 598);
            this.panelPlanets.TabIndex = 3;
            // 
            // simpleOpenGlControlMini
            // 
            this.simpleOpenGlControlMini.AccumBits = ((byte)(0));
            this.simpleOpenGlControlMini.AutoCheckErrors = false;
            this.simpleOpenGlControlMini.AutoFinish = false;
            this.simpleOpenGlControlMini.AutoMakeCurrent = true;
            this.simpleOpenGlControlMini.AutoSwapBuffers = true;
            this.simpleOpenGlControlMini.BackColor = System.Drawing.Color.Black;
            this.simpleOpenGlControlMini.ColorBits = ((byte)(32));
            this.simpleOpenGlControlMini.DepthBits = ((byte)(16));
            this.simpleOpenGlControlMini.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleOpenGlControlMini.Location = new System.Drawing.Point(0, 343);
            this.simpleOpenGlControlMini.Name = "simpleOpenGlControlMini";
            this.simpleOpenGlControlMini.Size = new System.Drawing.Size(268, 232);
            this.simpleOpenGlControlMini.StencilBits = ((byte)(0));
            this.simpleOpenGlControlMini.TabIndex = 4;
            this.simpleOpenGlControlMini.Paint += new System.Windows.Forms.PaintEventHandler(this.simpleOpenGlControl1_Paint);
            // 
            // btn_pause
            // 
            this.btn_pause.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_pause.Location = new System.Drawing.Point(0, 575);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(268, 23);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause Animation";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // propertyGridPlanet
            // 
            this.propertyGridPlanet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridPlanet.Location = new System.Drawing.Point(0, 171);
            this.propertyGridPlanet.Name = "propertyGridPlanet";
            this.propertyGridPlanet.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.propertyGridPlanet.Size = new System.Drawing.Size(268, 427);
            this.propertyGridPlanet.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.comboBoxView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPlanet, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.trackBar1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxAxis, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxPlane, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 171);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // comboBoxView
            // 
            this.comboBoxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "2D - Side",
            "2D - Top",
            "3D - Perspective"});
            this.comboBoxView.Location = new System.Drawing.Point(3, 3);
            this.comboBoxView.MaxDropDownItems = 3;
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(262, 21);
            this.comboBoxView.TabIndex = 0;
            this.comboBoxView.SelectedIndexChanged += new System.EventHandler(this.comboBoxView_SelectedIndexChanged);
            // 
            // comboBoxPlanet
            // 
            this.comboBoxPlanet.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxPlanet.FormattingEnabled = true;
            this.comboBoxPlanet.Location = new System.Drawing.Point(3, 30);
            this.comboBoxPlanet.Name = "comboBoxPlanet";
            this.comboBoxPlanet.Size = new System.Drawing.Size(262, 21);
            this.comboBoxPlanet.TabIndex = 1;
            this.comboBoxPlanet.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlanet_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(3, 57);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(262, 42);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 50;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(3, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Enable Lighting";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_ctr, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_left, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_up, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_right, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_down, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_zoomin, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_zoomreset, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_zoomout, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 175);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_ctr
            // 
            this.btn_ctr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ctr.Location = new System.Drawing.Point(70, 61);
            this.btn_ctr.Name = "btn_ctr";
            this.btn_ctr.Size = new System.Drawing.Size(61, 52);
            this.btn_ctr.TabIndex = 0;
            this.btn_ctr.Text = "Reset Pan";
            this.btn_ctr.UseVisualStyleBackColor = true;
            this.btn_ctr.Click += new System.EventHandler(this.btn_ctr_Click);
            // 
            // btn_left
            // 
            this.btn_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_left.FlatAppearance.BorderSize = 0;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_left.Image")));
            this.btn_left.Location = new System.Drawing.Point(3, 61);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(61, 52);
            this.btn_left.TabIndex = 1;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_up
            // 
            this.btn_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_up.FlatAppearance.BorderSize = 0;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_up.Image")));
            this.btn_up.Location = new System.Drawing.Point(70, 3);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(61, 52);
            this.btn_up.TabIndex = 2;
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_right
            // 
            this.btn_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_right.FlatAppearance.BorderSize = 0;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_right.Image")));
            this.btn_right.Location = new System.Drawing.Point(137, 61);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(61, 52);
            this.btn_right.TabIndex = 3;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_down
            // 
            this.btn_down.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_down.FlatAppearance.BorderSize = 0;
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
            this.btn_down.Location = new System.Drawing.Point(70, 119);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(61, 53);
            this.btn_down.TabIndex = 4;
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_zoomin
            // 
            this.btn_zoomin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zoomin.Location = new System.Drawing.Point(204, 3);
            this.btn_zoomin.Name = "btn_zoomin";
            this.btn_zoomin.Size = new System.Drawing.Size(61, 52);
            this.btn_zoomin.TabIndex = 5;
            this.btn_zoomin.Text = "Zoom In";
            this.btn_zoomin.UseVisualStyleBackColor = true;
            this.btn_zoomin.Click += new System.EventHandler(this.btn_zoomin_Click);
            // 
            // btn_zoomreset
            // 
            this.btn_zoomreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zoomreset.Location = new System.Drawing.Point(204, 61);
            this.btn_zoomreset.Name = "btn_zoomreset";
            this.btn_zoomreset.Size = new System.Drawing.Size(61, 52);
            this.btn_zoomreset.TabIndex = 6;
            this.btn_zoomreset.Text = "Zoom Reset";
            this.btn_zoomreset.UseVisualStyleBackColor = true;
            this.btn_zoomreset.Click += new System.EventHandler(this.btn_zoomreset_Click);
            // 
            // btn_zoomout
            // 
            this.btn_zoomout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_zoomout.Location = new System.Drawing.Point(204, 119);
            this.btn_zoomout.Name = "btn_zoomout";
            this.btn_zoomout.Size = new System.Drawing.Size(61, 53);
            this.btn_zoomout.TabIndex = 7;
            this.btn_zoomout.Text = "Zoom Out";
            this.btn_zoomout.UseVisualStyleBackColor = true;
            this.btn_zoomout.Click += new System.EventHandler(this.btn_zoomout_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAxis
            // 
            this.checkBoxAxis.AutoSize = true;
            this.checkBoxAxis.Location = new System.Drawing.Point(3, 128);
            this.checkBoxAxis.Name = "checkBoxAxis";
            this.checkBoxAxis.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAxis.TabIndex = 4;
            this.checkBoxAxis.Text = "Draw Axis";
            this.checkBoxAxis.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlane
            // 
            this.checkBoxPlane.AutoSize = true;
            this.checkBoxPlane.Location = new System.Drawing.Point(3, 151);
            this.checkBoxPlane.Name = "checkBoxPlane";
            this.checkBoxPlane.Size = new System.Drawing.Size(134, 17);
            this.checkBoxPlane.TabIndex = 5;
            this.checkBoxPlane.Text = "Draw Reference Plane";
            this.checkBoxPlane.UseVisualStyleBackColor = true;
            // 
            // WinHoved
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1272, 773);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WinHoved";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solar System";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panelPlanets.ResumeLayout(false);
            this.panelPlanets.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_ctr;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_zoomin;
        private System.Windows.Forms.Button btn_zoomreset;
        private System.Windows.Forms.Button btn_zoomout;
        private System.Windows.Forms.Panel panelPlanets;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PropertyGrid propertyGridPlanet;
        private System.Windows.Forms.ComboBox comboBoxPlanet;
        private System.Windows.Forms.Button btn_pause;
        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControl;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Tao.Platform.Windows.SimpleOpenGlControl simpleOpenGlControlMini;
        private System.Windows.Forms.CheckBox checkBoxAxis;
        private System.Windows.Forms.CheckBox checkBoxPlane;
    }
}

