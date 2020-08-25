namespace test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plMain = new System.Windows.Forms.Panel();
            this.plControl = new System.Windows.Forms.Panel();
            this.btnUngroup = new System.Windows.Forms.Button();
            this.bntGroup = new System.Windows.Forms.Button();
            this.bntEaser = new System.Windows.Forms.Button();
            this.ckbSelected = new System.Windows.Forms.CheckBox();
            this.pnlTeal = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlSalmon = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlBlue = new System.Windows.Forms.Panel();
            this.pnlWhite = new System.Windows.Forms.Panel();
            this.pnlBlack = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlCurrentColor = new System.Windows.Forms.Panel();
            this.cmbStytePen = new System.Windows.Forms.ComboBox();
            this.cmbFill = new System.Windows.Forms.ComboBox();
            this.bntPolygon = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbWidth = new System.Windows.Forms.Label();
            this.trbWidth = new System.Windows.Forms.TrackBar();
            this.bntColor = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntRandowLine = new System.Windows.Forms.Button();
            this.bntCircle = new System.Windows.Forms.Button();
            this.bntEllipse = new System.Windows.Forms.Button();
            this.bntCurve = new System.Windows.Forms.Button();
            this.bntRectangle = new System.Windows.Forms.Button();
            this.bntSquare = new System.Windows.Forms.Button();
            this.bntLine = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.White;
            this.plMain.Location = new System.Drawing.Point(6, 104);
            this.plMain.MaximumSize = new System.Drawing.Size(1156, 577);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1156, 577);
            this.plMain.TabIndex = 0;
            this.plMain.Paint += new System.Windows.Forms.PaintEventHandler(this.plMain_Paint);
            this.plMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseClick);
            this.plMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDoubleClick);
            this.plMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseDown);
            this.plMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseMove);
            this.plMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.plMain_MouseUp);
            // 
            // plControl
            // 
            this.plControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.plControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plControl.Controls.Add(this.label2);
            this.plControl.Controls.Add(this.label1);
            this.plControl.Controls.Add(this.btnUngroup);
            this.plControl.Controls.Add(this.bntGroup);
            this.plControl.Controls.Add(this.bntEaser);
            this.plControl.Controls.Add(this.ckbSelected);
            this.plControl.Controls.Add(this.pnlTeal);
            this.plControl.Controls.Add(this.pnlGreen);
            this.plControl.Controls.Add(this.pnlSalmon);
            this.plControl.Controls.Add(this.pnlYellow);
            this.plControl.Controls.Add(this.pnlBlue);
            this.plControl.Controls.Add(this.pnlWhite);
            this.plControl.Controls.Add(this.pnlBlack);
            this.plControl.Controls.Add(this.pnlRed);
            this.plControl.Controls.Add(this.pnlCurrentColor);
            this.plControl.Controls.Add(this.cmbStytePen);
            this.plControl.Controls.Add(this.cmbFill);
            this.plControl.Controls.Add(this.bntPolygon);
            this.plControl.Controls.Add(this.textBox3);
            this.plControl.Controls.Add(this.lbWidth);
            this.plControl.Controls.Add(this.trbWidth);
            this.plControl.Controls.Add(this.bntColor);
            this.plControl.Controls.Add(this.textBox2);
            this.plControl.Controls.Add(this.textBox1);
            this.plControl.Controls.Add(this.bntRandowLine);
            this.plControl.Controls.Add(this.bntCircle);
            this.plControl.Controls.Add(this.bntEllipse);
            this.plControl.Controls.Add(this.bntCurve);
            this.plControl.Controls.Add(this.bntRectangle);
            this.plControl.Controls.Add(this.bntSquare);
            this.plControl.Controls.Add(this.bntLine);
            this.plControl.Location = new System.Drawing.Point(11, 9);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(1143, 89);
            this.plControl.TabIndex = 1;
            // 
            // btnUngroup
            // 
            this.btnUngroup.BackColor = System.Drawing.Color.White;
            this.btnUngroup.BackgroundImage = global::test.Properties.Resources.Un_Group;
            this.btnUngroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUngroup.Location = new System.Drawing.Point(584, 7);
            this.btnUngroup.Name = "btnUngroup";
            this.btnUngroup.Size = new System.Drawing.Size(59, 75);
            this.btnUngroup.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnUngroup, "Ungroup (Ctrl+ Shitf + G)");
            this.btnUngroup.UseVisualStyleBackColor = false;
            this.btnUngroup.Click += new System.EventHandler(this.btnUngroup_Click);
            // 
            // bntGroup
            // 
            this.bntGroup.BackColor = System.Drawing.Color.White;
            this.bntGroup.BackgroundImage = global::test.Properties.Resources.Group;
            this.bntGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntGroup.Location = new System.Drawing.Point(519, 7);
            this.bntGroup.Name = "bntGroup";
            this.bntGroup.Size = new System.Drawing.Size(59, 75);
            this.bntGroup.TabIndex = 30;
            this.toolTip1.SetToolTip(this.bntGroup, "Group( Ctrl + G)");
            this.bntGroup.UseVisualStyleBackColor = false;
            this.bntGroup.Click += new System.EventHandler(this.bntGroup_Click);
            // 
            // bntEaser
            // 
            this.bntEaser.BackColor = System.Drawing.Color.Gray;
            this.bntEaser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntEaser.Location = new System.Drawing.Point(1052, 4);
            this.bntEaser.Name = "bntEaser";
            this.bntEaser.Size = new System.Drawing.Size(76, 25);
            this.bntEaser.TabIndex = 29;
            this.bntEaser.Text = "Xóa";
            this.toolTip1.SetToolTip(this.bntEaser, "(Deleted or Backspace)");
            this.bntEaser.UseVisualStyleBackColor = false;
            this.bntEaser.Click += new System.EventHandler(this.bntEaser_Click);
            // 
            // ckbSelected
            // 
            this.ckbSelected.AutoSize = true;
            this.ckbSelected.BackColor = System.Drawing.Color.Gray;
            this.ckbSelected.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ckbSelected.Location = new System.Drawing.Point(391, 62);
            this.ckbSelected.Name = "ckbSelected";
            this.ckbSelected.Size = new System.Drawing.Size(58, 19);
            this.ckbSelected.TabIndex = 28;
            this.ckbSelected.Text = "Select";
            this.ckbSelected.UseVisualStyleBackColor = false;
            this.ckbSelected.CheckedChanged += new System.EventHandler(this.ckbSelected_CheckedChanged);
            // 
            // pnlTeal
            // 
            this.pnlTeal.BackColor = System.Drawing.Color.Teal;
            this.pnlTeal.Location = new System.Drawing.Point(1059, 58);
            this.pnlTeal.Name = "pnlTeal";
            this.pnlTeal.Size = new System.Drawing.Size(40, 22);
            this.pnlTeal.TabIndex = 25;
            this.pnlTeal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTeal_MouseClick);
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.Green;
            this.pnlGreen.Location = new System.Drawing.Point(1058, 33);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(40, 22);
            this.pnlGreen.TabIndex = 23;
            this.pnlGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlGreen_MouseClick);
            // 
            // pnlSalmon
            // 
            this.pnlSalmon.BackColor = System.Drawing.Color.Salmon;
            this.pnlSalmon.Location = new System.Drawing.Point(1017, 58);
            this.pnlSalmon.Name = "pnlSalmon";
            this.pnlSalmon.Size = new System.Drawing.Size(40, 22);
            this.pnlSalmon.TabIndex = 26;
            this.pnlSalmon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlSalmon_MouseClick);
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnlYellow.Location = new System.Drawing.Point(1016, 33);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(40, 22);
            this.pnlYellow.TabIndex = 23;
            this.pnlYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlYellow_MouseClick);
            // 
            // pnlBlue
            // 
            this.pnlBlue.BackColor = System.Drawing.Color.Navy;
            this.pnlBlue.Location = new System.Drawing.Point(975, 58);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(40, 22);
            this.pnlBlue.TabIndex = 27;
            this.pnlBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBlue_MouseClick);
            // 
            // pnlWhite
            // 
            this.pnlWhite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlWhite.Location = new System.Drawing.Point(974, 33);
            this.pnlWhite.Name = "pnlWhite";
            this.pnlWhite.Size = new System.Drawing.Size(40, 22);
            this.pnlWhite.TabIndex = 23;
            this.pnlWhite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlWhite_MouseClick);
            // 
            // pnlBlack
            // 
            this.pnlBlack.BackColor = System.Drawing.Color.Black;
            this.pnlBlack.Location = new System.Drawing.Point(934, 58);
            this.pnlBlack.Name = "pnlBlack";
            this.pnlBlack.Size = new System.Drawing.Size(40, 22);
            this.pnlBlack.TabIndex = 24;
            this.pnlBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBlack_MouseClick);
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.Location = new System.Drawing.Point(933, 33);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(40, 22);
            this.pnlRed.TabIndex = 22;
            this.pnlRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlRed_MouseClick);
            // 
            // pnlCurrentColor
            // 
            this.pnlCurrentColor.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnlCurrentColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCurrentColor.Location = new System.Drawing.Point(879, 38);
            this.pnlCurrentColor.Name = "pnlCurrentColor";
            this.pnlCurrentColor.Size = new System.Drawing.Size(48, 41);
            this.pnlCurrentColor.TabIndex = 21;
            this.toolTip1.SetToolTip(this.pnlCurrentColor, "Occured Color");
            // 
            // cmbStytePen
            // 
            this.cmbStytePen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStytePen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStytePen.FormattingEnabled = true;
            this.cmbStytePen.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "DashDotDot",
            "DashDot",
            "Dot"});
            this.cmbStytePen.Location = new System.Drawing.Point(733, 47);
            this.cmbStytePen.Name = "cmbStytePen";
            this.cmbStytePen.Size = new System.Drawing.Size(78, 23);
            this.cmbStytePen.TabIndex = 16;
            this.cmbStytePen.SelectedIndexChanged += new System.EventHandler(this.cmbStytePen_SelectedIndexChanged);
            // 
            // cmbFill
            // 
            this.cmbFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFill.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFill.FormattingEnabled = true;
            this.cmbFill.Items.AddRange(new object[] {
            "No Fill",
            "Fill"});
            this.cmbFill.Location = new System.Drawing.Point(732, 13);
            this.cmbFill.Name = "cmbFill";
            this.cmbFill.Size = new System.Drawing.Size(79, 25);
            this.cmbFill.TabIndex = 15;
            this.cmbFill.SelectedIndexChanged += new System.EventHandler(this.cmbFill_SelectedIndexChanged);
            // 
            // bntPolygon
            // 
            this.bntPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntPolygon.BackgroundImage")));
            this.bntPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntPolygon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntPolygon.Location = new System.Drawing.Point(117, 7);
            this.bntPolygon.Name = "bntPolygon";
            this.bntPolygon.Size = new System.Drawing.Size(52, 68);
            this.bntPolygon.TabIndex = 13;
            this.toolTip1.SetToolTip(this.bntPolygon, "Polygon");
            this.bntPolygon.UseVisualStyleBackColor = true;
            this.bntPolygon.Click += new System.EventHandler(this.bntPolygon_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(667, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 86);
            this.textBox3.TabIndex = 12;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWidth.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbWidth.Location = new System.Drawing.Point(971, 3);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(15, 16);
            this.lbWidth.TabIndex = 11;
            this.lbWidth.Text = "1";
            // 
            // trbWidth
            // 
            this.trbWidth.Location = new System.Drawing.Point(870, 2);
            this.trbWidth.Name = "trbWidth";
            this.trbWidth.Size = new System.Drawing.Size(104, 45);
            this.trbWidth.TabIndex = 0;
            this.trbWidth.Scroll += new System.EventHandler(this.trbWidth_Scroll);
            // 
            // bntColor
            // 
            this.bntColor.BackgroundImage = global::test.Properties.Resources.Color;
            this.bntColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntColor.Location = new System.Drawing.Point(1103, 42);
            this.bntColor.Name = "bntColor";
            this.bntColor.Size = new System.Drawing.Size(26, 28);
            this.bntColor.TabIndex = 10;
            this.bntColor.UseVisualStyleBackColor = true;
            this.bntColor.Click += new System.EventHandler(this.bntColor_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(828, 1);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1, 85);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1, 85);
            this.textBox1.TabIndex = 7;
            // 
            // bntRandowLine
            // 
            this.bntRandowLine.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bntRandowLine.BackgroundImage = global::test.Properties.Resources.Pen;
            this.bntRandowLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntRandowLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntRandowLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bntRandowLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bntRandowLine.Location = new System.Drawing.Point(391, 7);
            this.bntRandowLine.Name = "bntRandowLine";
            this.bntRandowLine.Size = new System.Drawing.Size(53, 42);
            this.bntRandowLine.TabIndex = 6;
            this.toolTip1.SetToolTip(this.bntRandowLine, "Pen");
            this.bntRandowLine.UseVisualStyleBackColor = false;
            this.bntRandowLine.Click += new System.EventHandler(this.bntRamdow);
            // 
            // bntCircle
            // 
            this.bntCircle.BackgroundImage = global::test.Properties.Resources.Circle;
            this.bntCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCircle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntCircle.Location = new System.Drawing.Point(229, 7);
            this.bntCircle.Name = "bntCircle";
            this.bntCircle.Size = new System.Drawing.Size(50, 68);
            this.bntCircle.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bntCircle, "Circle");
            this.bntCircle.UseVisualStyleBackColor = true;
            this.bntCircle.Click += new System.EventHandler(this.bntCircle_Click);
            // 
            // bntEllipse
            // 
            this.bntEllipse.BackgroundImage = global::test.Properties.Resources.Ellipse;
            this.bntEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntEllipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntEllipse.Location = new System.Drawing.Point(285, 43);
            this.bntEllipse.Name = "bntEllipse";
            this.bntEllipse.Size = new System.Drawing.Size(63, 38);
            this.bntEllipse.TabIndex = 4;
            this.toolTip1.SetToolTip(this.bntEllipse, "Ellipse");
            this.bntEllipse.UseVisualStyleBackColor = true;
            this.bntEllipse.Click += new System.EventHandler(this.bntEllipse_Click);
            // 
            // bntCurve
            // 
            this.bntCurve.BackgroundImage = global::test.Properties.Resources.Curve;
            this.bntCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntCurve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntCurve.Location = new System.Drawing.Point(175, 7);
            this.bntCurve.Name = "bntCurve";
            this.bntCurve.Size = new System.Drawing.Size(48, 68);
            this.bntCurve.TabIndex = 3;
            this.toolTip1.SetToolTip(this.bntCurve, "Curve");
            this.bntCurve.UseVisualStyleBackColor = true;
            this.bntCurve.Click += new System.EventHandler(this.bntCurve_Click);
            // 
            // bntRectangle
            // 
            this.bntRectangle.BackgroundImage = global::test.Properties.Resources.Square;
            this.bntRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntRectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntRectangle.Location = new System.Drawing.Point(285, 6);
            this.bntRectangle.Name = "bntRectangle";
            this.bntRectangle.Size = new System.Drawing.Size(63, 36);
            this.bntRectangle.TabIndex = 2;
            this.toolTip1.SetToolTip(this.bntRectangle, "Rectangle");
            this.bntRectangle.UseVisualStyleBackColor = true;
            this.bntRectangle.Click += new System.EventHandler(this.bntRectangle_Click);
            // 
            // bntSquare
            // 
            this.bntSquare.BackgroundImage = global::test.Properties.Resources.Square;
            this.bntSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntSquare.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntSquare.Location = new System.Drawing.Point(60, 7);
            this.bntSquare.Name = "bntSquare";
            this.bntSquare.Size = new System.Drawing.Size(51, 68);
            this.bntSquare.TabIndex = 1;
            this.toolTip1.SetToolTip(this.bntSquare, "Square");
            this.bntSquare.UseVisualStyleBackColor = true;
            this.bntSquare.Click += new System.EventHandler(this.bntSquare_Click);
            // 
            // bntLine
            // 
            this.bntLine.BackgroundImage = global::test.Properties.Resources.Line;
            this.bntLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntLine.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntLine.Location = new System.Drawing.Point(3, 7);
            this.bntLine.Name = "bntLine";
            this.bntLine.Size = new System.Drawing.Size(51, 68);
            this.bntLine.TabIndex = 0;
            this.toolTip1.SetToolTip(this.bntLine, "Line");
            this.bntLine.UseVisualStyleBackColor = true;
            this.bntLine.Click += new System.EventHandler(this.bntLine_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(674, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Brush";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(674, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Outline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 682);
            this.Controls.Add(this.plControl);
            this.Controls.Add(this.plMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1177, 721);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.plControl.ResumeLayout(false);
            this.plControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Button bntRandowLine;
        private System.Windows.Forms.Button bntCircle;
        private System.Windows.Forms.Button bntEllipse;
        private System.Windows.Forms.Button bntCurve;
        private System.Windows.Forms.Button bntRectangle;
        private System.Windows.Forms.Button bntSquare;
        private System.Windows.Forms.Button bntLine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bntColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbWidth;
        private System.Windows.Forms.TrackBar trbWidth;
        private System.Windows.Forms.Button bntPolygon;
        private System.Windows.Forms.ComboBox cmbFill;
        private System.Windows.Forms.ComboBox cmbStytePen;
        private System.Windows.Forms.Panel pnlCurrentColor;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlWhite;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Panel pnlTeal;
        private System.Windows.Forms.Panel pnlSalmon;
        private System.Windows.Forms.Panel pnlBlue;
        private System.Windows.Forms.Panel pnlBlack;
        private System.Windows.Forms.CheckBox ckbSelected;
        private System.Windows.Forms.Button bntEaser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnUngroup;
        private System.Windows.Forms.Button bntGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

