namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtDisp2 = new System.Windows.Forms.TextBox();
            this.txtDisp1 = new System.Windows.Forms.TextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.RtDisplayHistory = new System.Windows.Forms.RichTextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btndeci = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmp = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnage = new System.Windows.Forms.Button();
            this.btnmul = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 31);
            this.panel1.TabIndex = 0;
            // 
            // pnlHistory
            // 
            this.pnlHistory.AutoSize = true;
            this.pnlHistory.Controls.Add(this.RtDisplayHistory);
            this.pnlHistory.Controls.Add(this.btnClearHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistory.Location = new System.Drawing.Point(0, 334);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(299, 27);
            this.pnlHistory.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(249, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(199, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 31);
            this.btnMax.TabIndex = 1;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(149, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 31);
            this.btnMin.TabIndex = 2;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnopen);
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.Location = new System.Drawing.Point(249, 0);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(50, 40);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnopen
            // 
            this.btnopen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnopen.FlatAppearance.BorderSize = 0;
            this.btnopen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopen.Image = ((System.Drawing.Image)(resources.GetObject("btnopen.Image")));
            this.btnopen.Location = new System.Drawing.Point(0, 0);
            this.btnopen.Margin = new System.Windows.Forms.Padding(0);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(50, 40);
            this.btnopen.TabIndex = 1;
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // txtDisp2
            // 
            this.txtDisp2.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtDisp2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisp2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisp2.Font = new System.Drawing.Font("Gadugi", 14F);
            this.txtDisp2.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDisp2.Location = new System.Drawing.Point(0, 71);
            this.txtDisp2.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisp2.Multiline = true;
            this.txtDisp2.Name = "txtDisp2";
            this.txtDisp2.Size = new System.Drawing.Size(299, 25);
            this.txtDisp2.TabIndex = 3;
            this.txtDisp2.Text = "0";
            this.txtDisp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisp1
            // 
            this.txtDisp1.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtDisp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisp1.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisp1.ForeColor = System.Drawing.Color.Snow;
            this.txtDisp1.Location = new System.Drawing.Point(0, 96);
            this.txtDisp1.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisp1.Multiline = true;
            this.txtDisp1.Name = "txtDisp1";
            this.txtDisp1.ReadOnly = true;
            this.txtDisp1.Size = new System.Drawing.Size(299, 46);
            this.txtDisp1.TabIndex = 4;
            this.txtDisp1.Text = "68979";
            this.txtDisp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClearHistory.FlatAppearance.BorderSize = 0;
            this.btnClearHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnClearHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHistory.Image")));
            this.btnClearHistory.Location = new System.Drawing.Point(0, 0);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(299, 27);
            this.btnClearHistory.TabIndex = 2;
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // RtDisplayHistory
            // 
            this.RtDisplayHistory.BackColor = System.Drawing.SystemColors.ControlText;
            this.RtDisplayHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtDisplayHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtDisplayHistory.ForeColor = System.Drawing.Color.Silver;
            this.RtDisplayHistory.Location = new System.Drawing.Point(0, 0);
            this.RtDisplayHistory.Margin = new System.Windows.Forms.Padding(0);
            this.RtDisplayHistory.Name = "RtDisplayHistory";
            this.RtDisplayHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.RtDisplayHistory.Size = new System.Drawing.Size(299, 0);
            this.RtDisplayHistory.TabIndex = 3;
            this.RtDisplayHistory.Text = "";
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.Color.Black;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn7.Location = new System.Drawing.Point(0, 153);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 55);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.Color.Black;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn0.Location = new System.Drawing.Point(0, 301);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 55);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(0, 249);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 55);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.Color.Black;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn4.Location = new System.Drawing.Point(0, 202);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 55);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.Color.Black;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(52, 249);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 55);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.Color.Black;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn5.Location = new System.Drawing.Point(52, 202);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 55);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.Color.Black;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn8.Location = new System.Drawing.Point(52, 153);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 55);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btndeci
            // 
            this.btndeci.AutoSize = true;
            this.btndeci.BackColor = System.Drawing.Color.Black;
            this.btndeci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndeci.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btndeci.Location = new System.Drawing.Point(52, 301);
            this.btndeci.Name = "btndeci";
            this.btndeci.Size = new System.Drawing.Size(56, 55);
            this.btndeci.TabIndex = 12;
            this.btndeci.Text = ".";
            this.btndeci.UseVisualStyleBackColor = false;
            this.btndeci.Click += new System.EventHandler(this.btndeci_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(183, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 55);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnsub
            // 
            this.btnsub.AutoSize = true;
            this.btnsub.BackColor = System.Drawing.Color.Black;
            this.btnsub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsub.Location = new System.Drawing.Point(183, 202);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(56, 55);
            this.btnsub.TabIndex = 14;
            this.btnsub.Text = "-";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmp
            // 
            this.btnmp.AutoSize = true;
            this.btnmp.BackColor = System.Drawing.Color.Black;
            this.btnmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnmp.Location = new System.Drawing.Point(183, 301);
            this.btnmp.Name = "btnmp";
            this.btnmp.Size = new System.Drawing.Size(56, 55);
            this.btnmp.TabIndex = 15;
            this.btnmp.Text = "-/+";
            this.btnmp.UseVisualStyleBackColor = false;
            this.btnmp.Click += new System.EventHandler(this.btnmp_Click);
            // 
            // btndiv
            // 
            this.btndiv.AutoSize = true;
            this.btndiv.BackColor = System.Drawing.Color.Black;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndiv.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btndiv.Location = new System.Drawing.Point(183, 249);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(56, 55);
            this.btndiv.TabIndex = 16;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnage
            // 
            this.btnage.AutoSize = true;
            this.btnage.BackColor = System.Drawing.Color.Black;
            this.btnage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnage.Location = new System.Drawing.Point(240, 301);
            this.btnage.Name = "btnage";
            this.btnage.Size = new System.Drawing.Size(56, 55);
            this.btnage.TabIndex = 17;
            this.btnage.Text = "%";
            this.btnage.UseVisualStyleBackColor = false;
            this.btnage.Click += new System.EventHandler(this.btnage_Click);
            // 
            // btnmul
            // 
            this.btnmul.AutoSize = true;
            this.btnmul.BackColor = System.Drawing.Color.Black;
            this.btnmul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmul.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnmul.Location = new System.Drawing.Point(240, 249);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(56, 55);
            this.btnmul.TabIndex = 18;
            this.btnmul.Text = "*";
            this.btnmul.UseVisualStyleBackColor = false;
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnsum
            // 
            this.btnsum.AutoSize = true;
            this.btnsum.BackColor = System.Drawing.Color.Black;
            this.btnsum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsum.Location = new System.Drawing.Point(240, 202);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(56, 55);
            this.btnsum.TabIndex = 19;
            this.btnsum.Text = "+";
            this.btnsum.UseVisualStyleBackColor = false;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.Color.Black;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn9.Location = new System.Drawing.Point(105, 153);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 55);
            this.btn9.TabIndex = 20;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.Color.Black;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn6.Location = new System.Drawing.Point(105, 202);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 55);
            this.btn6.TabIndex = 21;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.Black;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn3.Location = new System.Drawing.Point(105, 246);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 55);
            this.btn3.TabIndex = 22;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnequal
            // 
            this.btnequal.AutoSize = true;
            this.btnequal.BackColor = System.Drawing.Color.Black;
            this.btnequal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnequal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnequal.Location = new System.Drawing.Point(105, 301);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(56, 55);
            this.btnequal.TabIndex = 23;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = false;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 25);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(299, 361);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btnage);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btnmp);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btndeci);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtDisp1);
            this.Controls.Add(this.txtDisp2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlHistory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox txtDisp2;
        private System.Windows.Forms.TextBox txtDisp1;
        private System.Windows.Forms.RichTextBox RtDisplayHistory;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btndeci;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmp;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnage;
        private System.Windows.Forms.Button btnmul;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

