namespace ScoreManagement
{
    partial class SearchForm
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
            this.stuXH = new System.Windows.Forms.TextBox();
            this.stuXM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StuDGV = new System.Windows.Forms.DataGridView();
            this.stuZY = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(232, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生信息查询";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学号：";
            // 
            // stuXH
            // 
            this.stuXH.Location = new System.Drawing.Point(59, 34);
            this.stuXH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuXH.Name = "stuXH";
            this.stuXH.Size = new System.Drawing.Size(109, 25);
            this.stuXH.TabIndex = 3;
            // 
            // stuXM
            // 
            this.stuXM.Location = new System.Drawing.Point(251, 34);
            this.stuXM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuXM.Name = "stuXM";
            this.stuXM.Size = new System.Drawing.Size(124, 25);
            this.stuXM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "专业：";
            // 
            // StuDGV
            // 
            this.StuDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuDGV.Location = new System.Drawing.Point(27, 157);
            this.StuDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StuDGV.Name = "StuDGV";
            this.StuDGV.RowHeadersWidth = 51;
            this.StuDGV.RowTemplate.Height = 30;
            this.StuDGV.Size = new System.Drawing.Size(721, 280);
            this.StuDGV.TabIndex = 7;
            this.StuDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StuDGV_CellContentClick);
            this.StuDGV.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StuDGV_RowHeaderMouseDoubleClick);
            // 
            // stuZY
            // 
            this.stuZY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stuZY.FormattingEnabled = true;
            this.stuZY.Items.AddRange(new object[] {
            "所有专业",
            "计算机",
            "通信工程"});
            this.stuZY.Location = new System.Drawing.Point(460, 34);
            this.stuZY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuZY.Name = "stuZY";
            this.stuZY.Size = new System.Drawing.Size(155, 23);
            this.stuZY.TabIndex = 8;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(635, 26);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(86, 33);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "查询";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stuZY);
            this.groupBox1.Controls.Add(this.search_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.stuXH);
            this.groupBox1.Controls.Add(this.stuXM);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入查询条件";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StuDGV);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchForm";
            this.Text = "学生信息查询";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StuDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stuXH;
        private System.Windows.Forms.TextBox stuXM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView StuDGV;
        private System.Windows.Forms.ComboBox stuZY;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}