
namespace EX7_12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLine5 = new System.Windows.Forms.Button();
            this.btnLine4 = new System.Windows.Forms.Button();
            this.btnLine3 = new System.Windows.Forms.Button();
            this.btnLine2 = new System.Windows.Forms.Button();
            this.btnLine1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnFillRec = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.btnFillEllipse = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.btnpencil = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(536, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 570);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(309, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 20);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnColorDialog);
            this.groupBox3.Controls.Add(this.btnBlue);
            this.groupBox3.Controls.Add(this.btnBlack);
            this.groupBox3.Controls.Add(this.btnGreen);
            this.groupBox3.Controls.Add(this.btnYellow);
            this.groupBox3.Controls.Add(this.btnRed);
            this.groupBox3.Controls.Add(this.btnControl);
            this.groupBox3.Location = new System.Drawing.Point(20, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "颜色";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorDialog.Location = new System.Drawing.Point(206, 114);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(44, 29);
            this.btnColorDialog.TabIndex = 6;
            this.btnColorDialog.Text = "C";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(120, 114);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(45, 29);
            this.btnBlue.TabIndex = 5;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Location = new System.Drawing.Point(41, 114);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(46, 29);
            this.btnBlack.TabIndex = 4;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(206, 62);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(44, 29);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(120, 62);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(45, 30);
            this.btnYellow.TabIndex = 2;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(41, 62);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(46, 29);
            this.btnRed.TabIndex = 1;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnControl
            // 
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Location = new System.Drawing.Point(120, 14);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(44, 29);
            this.btnControl.TabIndex = 0;
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLine5);
            this.groupBox2.Controls.Add(this.btnLine4);
            this.groupBox2.Controls.Add(this.btnLine3);
            this.groupBox2.Controls.Add(this.btnLine2);
            this.groupBox2.Controls.Add(this.btnLine1);
            this.groupBox2.Location = new System.Drawing.Point(20, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "宽度";
            // 
            // btnLine5
            // 
            this.btnLine5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine5.Image = global::EX7_12.Properties.Resources._5号直线;
            this.btnLine5.Location = new System.Drawing.Point(41, 167);
            this.btnLine5.Name = "btnLine5";
            this.btnLine5.Size = new System.Drawing.Size(176, 29);
            this.btnLine5.TabIndex = 4;
            this.btnLine5.Tag = "5";
            this.btnLine5.UseVisualStyleBackColor = true;
            this.btnLine5.Click += new System.EventHandler(this.btnLine5_Click);
            // 
            // btnLine4
            // 
            this.btnLine4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine4.Image = global::EX7_12.Properties.Resources._4号直线;
            this.btnLine4.Location = new System.Drawing.Point(41, 132);
            this.btnLine4.Name = "btnLine4";
            this.btnLine4.Size = new System.Drawing.Size(177, 29);
            this.btnLine4.TabIndex = 3;
            this.btnLine4.Tag = "4";
            this.btnLine4.UseVisualStyleBackColor = true;
            this.btnLine4.Click += new System.EventHandler(this.btnLine4_Click);
            // 
            // btnLine3
            // 
            this.btnLine3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine3.Image = global::EX7_12.Properties.Resources._3号直线;
            this.btnLine3.Location = new System.Drawing.Point(41, 97);
            this.btnLine3.Name = "btnLine3";
            this.btnLine3.Size = new System.Drawing.Size(176, 29);
            this.btnLine3.TabIndex = 2;
            this.btnLine3.Tag = "3";
            this.btnLine3.UseVisualStyleBackColor = true;
            this.btnLine3.Click += new System.EventHandler(this.btnLine3_Click);
            // 
            // btnLine2
            // 
            this.btnLine2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine2.Image = global::EX7_12.Properties.Resources._2号直线;
            this.btnLine2.Location = new System.Drawing.Point(41, 61);
            this.btnLine2.Name = "btnLine2";
            this.btnLine2.Size = new System.Drawing.Size(177, 29);
            this.btnLine2.TabIndex = 1;
            this.btnLine2.Tag = "2";
            this.btnLine2.UseVisualStyleBackColor = true;
            this.btnLine2.Click += new System.EventHandler(this.btnLine2_Click);
            // 
            // btnLine1
            // 
            this.btnLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine1.Image = global::EX7_12.Properties.Resources._1号直线;
            this.btnLine1.Location = new System.Drawing.Point(41, 26);
            this.btnLine1.Name = "btnLine1";
            this.btnLine1.Size = new System.Drawing.Size(176, 29);
            this.btnLine1.TabIndex = 0;
            this.btnLine1.Tag = "1";
            this.btnLine1.UseVisualStyleBackColor = true;
            this.btnLine1.Click += new System.EventHandler(this.btnLine1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnEraser);
            this.groupBox1.Controls.Add(this.btnFillRec);
            this.groupBox1.Controls.Add(this.btnRec);
            this.groupBox1.Controls.Add(this.btnFillEllipse);
            this.groupBox1.Controls.Add(this.btnEllipse);
            this.groupBox1.Controls.Add(this.btnline);
            this.groupBox1.Controls.Add(this.btnpencil);
            this.groupBox1.Location = new System.Drawing.Point(20, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工具";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::EX7_12.Properties.Resources.退出;
            this.btnExit.Location = new System.Drawing.Point(196, 107);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Tag = "";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EX7_12.Properties.Resources.新建;
            this.btnNew.Location = new System.Drawing.Point(120, 108);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(34, 28);
            this.btnNew.TabIndex = 7;
            this.btnNew.Tag = "";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Image = global::EX7_12.Properties.Resources.橡皮擦;
            this.btnEraser.Location = new System.Drawing.Point(41, 108);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(35, 28);
            this.btnEraser.TabIndex = 6;
            this.btnEraser.Tag = "6";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnFillRec
            // 
            this.btnFillRec.Image = global::EX7_12.Properties.Resources.填充矩形;
            this.btnFillRec.Location = new System.Drawing.Point(196, 61);
            this.btnFillRec.Name = "btnFillRec";
            this.btnFillRec.Size = new System.Drawing.Size(33, 29);
            this.btnFillRec.TabIndex = 5;
            this.btnFillRec.Tag = "5";
            this.btnFillRec.UseVisualStyleBackColor = true;
            this.btnFillRec.Click += new System.EventHandler(this.btnFillRec_Click);
            // 
            // btnRec
            // 
            this.btnRec.Image = global::EX7_12.Properties.Resources.空心矩形;
            this.btnRec.Location = new System.Drawing.Point(120, 64);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(34, 32);
            this.btnRec.TabIndex = 4;
            this.btnRec.Tag = "4";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnFillEllipse
            // 
            this.btnFillEllipse.Image = global::EX7_12.Properties.Resources.填充椭圆;
            this.btnFillEllipse.Location = new System.Drawing.Point(41, 66);
            this.btnFillEllipse.Name = "btnFillEllipse";
            this.btnFillEllipse.Size = new System.Drawing.Size(35, 29);
            this.btnFillEllipse.TabIndex = 3;
            this.btnFillEllipse.Tag = "3";
            this.btnFillEllipse.UseVisualStyleBackColor = true;
            this.btnFillEllipse.Click += new System.EventHandler(this.btnFillEllipse_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Image = global::EX7_12.Properties.Resources.空心椭圆;
            this.btnEllipse.Location = new System.Drawing.Point(196, 21);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(33, 33);
            this.btnEllipse.TabIndex = 2;
            this.btnEllipse.Tag = "2";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnline
            // 
            this.btnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnline.Image = global::EX7_12.Properties.Resources.直线;
            this.btnline.Location = new System.Drawing.Point(120, 23);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(34, 32);
            this.btnline.TabIndex = 1;
            this.btnline.Tag = "1";
            this.btnline.UseVisualStyleBackColor = true;
            this.btnline.Click += new System.EventHandler(this.btnline_Click);
            // 
            // btnpencil
            // 
            this.btnpencil.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpencil.Image = global::EX7_12.Properties.Resources.铅笔;
            this.btnpencil.Location = new System.Drawing.Point(41, 22);
            this.btnpencil.Name = "btnpencil";
            this.btnpencil.Size = new System.Drawing.Size(35, 32);
            this.btnpencil.TabIndex = 0;
            this.btnpencil.Tag = "0";
            this.btnpencil.UseVisualStyleBackColor = false;
            this.btnpencil.Click += new System.EventHandler(this.btnpencil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 570);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "画板工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.Button btnpencil;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnLine5;
        private System.Windows.Forms.Button btnLine4;
        private System.Windows.Forms.Button btnLine3;
        private System.Windows.Forms.Button btnLine2;
        private System.Windows.Forms.Button btnLine1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnFillRec;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Button btnFillEllipse;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

