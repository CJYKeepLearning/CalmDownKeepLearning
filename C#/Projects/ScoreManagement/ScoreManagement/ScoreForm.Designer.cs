namespace ScoreManagement
{
    partial class ScoreForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.stuXH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stuKCM = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stuCJ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stuXF = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.scoreDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "学生成绩录入";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "专业：";
            // 
            // stuZY
            // 
            this.stuZY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Location = new System.Drawing.Point(89, 32);
            this.stuZY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(145, 23);
            this.stuZY.TabIndex = 5;
            this.stuZY.SelectedIndexChanged += new System.EventHandler(this.stuZY_SelectedIndexChanged);
            // 
            // stuXH
            // 
            this.stuXH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuXH.FormattingEnabled = true;
            this.stuXH.Location = new System.Drawing.Point(291, 33);
            this.stuXH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(154, 23);
            this.stuXH.TabIndex = 7;
            this.stuXH.SelectedIndexChanged += new System.EventHandler(this.stuXH_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "学号：";
            // 
            // stuKCM
            // 
            this.stuKCM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuKCM.FormattingEnabled = true;
            this.stuKCM.Location = new System.Drawing.Point(553, 33);
            this.stuKCM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuKCM.Name = "stuKCM";
            this.stuKCM.Size = new System.Drawing.Size(147, 23);
            this.stuKCM.TabIndex = 9;
            this.stuKCM.SelectedIndexChanged += new System.EventHandler(this.stuKCM_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "课程名：";
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(89, 71);
            this.stuXM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(145, 25);
            this.stuXM.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "姓名：";
            // 
            // stuCJ
            // 
            this.stuCJ.Location = new System.Drawing.Point(291, 71);
            this.stuCJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuCJ.Name = "stuCJ";
            this.stuCJ.Size = new System.Drawing.Size(154, 25);
            this.stuCJ.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "成绩：";
            // 
            // stuXF
            // 
            this.stuXF.Location = new System.Drawing.Point(553, 71);
            this.stuXF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuXF.Name = "stuXF";
            this.stuXF.Size = new System.Drawing.Size(147, 25);
            this.stuXF.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "学  分：";
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(573, 112);
            this.cancel_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(89, 28);
            this.cancel_btn.TabIndex = 24;
            this.cancel_btn.Text = "取消";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(314, 112);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(95, 28);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "删除";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(103, 107);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(88, 28);
            this.update_btn.TabIndex = 22;
            this.update_btn.Text = "更新";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // scoreDGV
            // 
            this.scoreDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreDGV.Location = new System.Drawing.Point(11, 198);
            this.scoreDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scoreDGV.Name = "scoreDGV";
            this.scoreDGV.RowHeadersWidth = 51;
            this.scoreDGV.RowTemplate.Height = 30;
            this.scoreDGV.Size = new System.Drawing.Size(747, 262);
            this.scoreDGV.TabIndex = 25;
            this.scoreDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.scoreDGV_RowHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cancel_btn);
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.stuXF);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuCJ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.stuKCM);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 142);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生成绩录入";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scoreDGV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ScoreForm";
            this.Text = "学生成绩录入";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.ComboBox stuXH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox stuKCM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stuCJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox stuXF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.DataGridView scoreDGV;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}