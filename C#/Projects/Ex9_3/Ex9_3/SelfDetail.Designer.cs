namespace Ex9_3
{
    partial class SelfDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBirthday = new System.Windows.Forms.TextBox();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblStudentNo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(160, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(163, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "生日：";
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(141, 302);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(53, 51);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(236, 302);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(58, 51);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(379, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 51);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(513, 302);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(62, 51);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(293, 391);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // tbBirthday
            // 
            this.tbBirthday.Location = new System.Drawing.Point(270, 148);
            this.tbBirthday.Name = "tbBirthday";
            this.tbBirthday.Size = new System.Drawing.Size(135, 25);
            this.tbBirthday.TabIndex = 8;
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(255, 78);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(0, 15);
            this.lblStudentNo.TabIndex = 9;
            // 
            // lblStudentNo1
            // 
            this.lblStudentNo1.AutoSize = true;
            this.lblStudentNo1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStudentNo1.Location = new System.Drawing.Point(273, 78);
            this.lblStudentNo1.Name = "lblStudentNo1";
            this.lblStudentNo1.Size = new System.Drawing.Size(0, 25);
            this.lblStudentNo1.TabIndex = 10;
            // 
            // SelfDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 466);
            this.Controls.Add(this.lblStudentNo1);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.tbBirthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SelfDetail";
            this.Text = "SelfDetail";
            this.Load += new System.EventHandler(this.SelfDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox tbBirthday;
        public System.Windows.Forms.Label lblStudentNo;
        public System.Windows.Forms.Label lblStudentNo1;
    }
}