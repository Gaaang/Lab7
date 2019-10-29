namespace AffineTransformationsIn3D
{
    partial class FormChangeModel
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePolyhedron = new System.Windows.Forms.TabPage();
            this.radioButtonCube = new System.Windows.Forms.RadioButton();
            this.radioButtonIcosahedron = new System.Windows.Forms.RadioButton();
            this.radioButtonTetrahedron = new System.Windows.Forms.RadioButton();
            this.tabPageRotationFigure = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonX = new System.Windows.Forms.RadioButton();
            this.radioButtonZ = new System.Windows.Forms.RadioButton();
            this.radioButtonY = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDensity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.tabPagePlot = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePolyhedron.SuspendLayout();
            this.tabPageRotationFigure.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.tabPagePlot.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 370);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 3);
            this.tabControl1.Controls.Add(this.tabPagePolyhedron);
            this.tabControl1.Controls.Add(this.tabPageRotationFigure);
            this.tabControl1.Controls.Add(this.tabPagePlot);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(448, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePolyhedron
            // 
            this.tabPagePolyhedron.Controls.Add(this.radioButtonCube);
            this.tabPagePolyhedron.Controls.Add(this.radioButtonIcosahedron);
            this.tabPagePolyhedron.Controls.Add(this.radioButtonTetrahedron);
            this.tabPagePolyhedron.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolyhedron.Name = "tabPagePolyhedron";
            this.tabPagePolyhedron.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePolyhedron.Size = new System.Drawing.Size(440, 309);
            this.tabPagePolyhedron.TabIndex = 0;
            this.tabPagePolyhedron.Text = "Многогранник";
            this.tabPagePolyhedron.UseVisualStyleBackColor = true;
            // 
            // radioButtonCube
            // 
            this.radioButtonCube.AutoSize = true;
            this.radioButtonCube.Location = new System.Drawing.Point(6, 53);
            this.radioButtonCube.Name = "radioButtonCube";
            this.radioButtonCube.Size = new System.Drawing.Size(43, 17);
            this.radioButtonCube.TabIndex = 2;
            this.radioButtonCube.TabStop = true;
            this.radioButtonCube.Text = "Куб";
            this.radioButtonCube.UseVisualStyleBackColor = true;
            // 
            // radioButtonIcosahedron
            // 
            this.radioButtonIcosahedron.AutoSize = true;
            this.radioButtonIcosahedron.Location = new System.Drawing.Point(6, 30);
            this.radioButtonIcosahedron.Name = "radioButtonIcosahedron";
            this.radioButtonIcosahedron.Size = new System.Drawing.Size(75, 17);
            this.radioButtonIcosahedron.TabIndex = 1;
            this.radioButtonIcosahedron.TabStop = true;
            this.radioButtonIcosahedron.Text = "Икосаэдр";
            this.radioButtonIcosahedron.UseVisualStyleBackColor = true;
            // 
            // radioButtonTetrahedron
            // 
            this.radioButtonTetrahedron.AutoSize = true;
            this.radioButtonTetrahedron.Checked = true;
            this.radioButtonTetrahedron.Location = new System.Drawing.Point(6, 6);
            this.radioButtonTetrahedron.Name = "radioButtonTetrahedron";
            this.radioButtonTetrahedron.Size = new System.Drawing.Size(73, 17);
            this.radioButtonTetrahedron.TabIndex = 0;
            this.radioButtonTetrahedron.TabStop = true;
            this.radioButtonTetrahedron.Text = "Тетраэдр";
            this.radioButtonTetrahedron.UseVisualStyleBackColor = true;
            // 
            // tabPageRotationFigure
            // 
            this.tabPageRotationFigure.Controls.Add(this.tableLayoutPanel2);
            this.tabPageRotationFigure.Location = new System.Drawing.Point(4, 22);
            this.tabPageRotationFigure.Name = "tabPageRotationFigure";
            this.tabPageRotationFigure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRotationFigure.Size = new System.Drawing.Size(440, 309);
            this.tabPageRotationFigure.TabIndex = 2;
            this.tabPageRotationFigure.Text = "Фигура вращения";
            this.tabPageRotationFigure.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 332F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownDensity, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.listBoxPoints, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 303);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ось:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.Controls.Add(this.radioButtonX, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonZ, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonY, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(105, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(154, 23);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // radioButtonX
            // 
            this.radioButtonX.AutoSize = true;
            this.radioButtonX.Location = new System.Drawing.Point(3, 3);
            this.radioButtonX.Name = "radioButtonX";
            this.radioButtonX.Size = new System.Drawing.Size(40, 17);
            this.radioButtonX.TabIndex = 1;
            this.radioButtonX.Text = "OX";
            this.radioButtonX.UseVisualStyleBackColor = true;
            // 
            // radioButtonZ
            // 
            this.radioButtonZ.AutoSize = true;
            this.radioButtonZ.Location = new System.Drawing.Point(95, 3);
            this.radioButtonZ.Name = "radioButtonZ";
            this.radioButtonZ.Size = new System.Drawing.Size(40, 17);
            this.radioButtonZ.TabIndex = 1;
            this.radioButtonZ.Text = "OZ";
            this.radioButtonZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonY
            // 
            this.radioButtonY.AutoSize = true;
            this.radioButtonY.Checked = true;
            this.radioButtonY.Location = new System.Drawing.Point(49, 3);
            this.radioButtonY.Name = "radioButtonY";
            this.radioButtonY.Size = new System.Drawing.Size(40, 17);
            this.radioButtonY.TabIndex = 1;
            this.radioButtonY.TabStop = true;
            this.radioButtonY.Text = "OY";
            this.radioButtonY.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число разбиений";
            // 
            // numericUpDownDensity
            // 
            this.numericUpDownDensity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownDensity.Location = new System.Drawing.Point(105, 32);
            this.numericUpDownDensity.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownDensity.Name = "numericUpDownDensity";
            this.numericUpDownDensity.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownDensity.TabIndex = 4;
            this.numericUpDownDensity.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Образующая:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownX, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownY, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.numericUpDownZ, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonAdd, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonRemove, 4, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(105, 271);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(312, 29);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownX.Location = new System.Drawing.Point(3, 3);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownX.TabIndex = 0;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownY.Location = new System.Drawing.Point(53, 3);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownY.TabIndex = 1;
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.DecimalPlaces = 2;
            this.numericUpDownZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownZ.Location = new System.Drawing.Point(103, 3);
            this.numericUpDownZ.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownZ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownZ.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(153, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.AddPoint);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(234, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Убрать";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.RemovePoint);
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.Location = new System.Drawing.Point(105, 58);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(326, 207);
            this.listBoxPoints.TabIndex = 7;
            this.listBoxPoints.SelectedIndexChanged += new System.EventHandler(this.SelectedPointChanged);
            // 
            // tabPagePlot
            // 
            this.tabPagePlot.Controls.Add(this.label8);
            this.tabPagePlot.Controls.Add(this.label7);
            this.tabPagePlot.Controls.Add(this.label6);
            this.tabPagePlot.Controls.Add(this.label5);
            this.tabPagePlot.Controls.Add(this.label4);
            this.tabPagePlot.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlot.Name = "tabPagePlot";
            this.tabPagePlot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlot.Size = new System.Drawing.Size(440, 309);
            this.tabPagePlot.TabIndex = 3;
            this.tabPagePlot.Text = "График";
            this.tabPagePlot.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "f(x, z) = x^2 * z / (x^4 + z^2);";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "z1 = 0.8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "x1 = 0.8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "z0 = -0.8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "x0 = -0.8";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(376, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(295, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ок";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Ok);
            // 
            // FormChangeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(470, 300);
            this.Name = "FormChangeModel";
            this.Text = "Выберите объект";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePolyhedron.ResumeLayout(false);
            this.tabPagePolyhedron.PerformLayout();
            this.tabPageRotationFigure.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.tabPagePlot.ResumeLayout(false);
            this.tabPagePlot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePolyhedron;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButtonIcosahedron;
        private System.Windows.Forms.RadioButton radioButtonTetrahedron;
        private System.Windows.Forms.TabPage tabPageRotationFigure;
        private System.Windows.Forms.TabPage tabPagePlot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButtonX;
        private System.Windows.Forms.RadioButton radioButtonZ;
        private System.Windows.Forms.RadioButton radioButtonY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownDensity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listBoxPoints;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonCube;
    }
}