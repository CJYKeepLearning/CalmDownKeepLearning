namespace Ex9_3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RbtnFemale = new System.Windows.Forms.RadioButton();
            this.RbtnMale = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStuID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllStu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(489, 471);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 34);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "刷新";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(298, 105);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(124, 25);
            this.txtCredit.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 25);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(99, 112);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(100, 25);
            this.txtMajor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "学分:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "专业:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "生日:";
            // 
            // RbtnFemale
            // 
            this.RbtnFemale.AutoSize = true;
            this.RbtnFemale.Location = new System.Drawing.Point(156, 71);
            this.RbtnFemale.Name = "RbtnFemale";
            this.RbtnFemale.Size = new System.Drawing.Size(43, 19);
            this.RbtnFemale.TabIndex = 6;
            this.RbtnFemale.TabStop = true;
            this.RbtnFemale.Text = "女";
            this.RbtnFemale.UseVisualStyleBackColor = true;
            // 
            // RbtnMale
            // 
            this.RbtnMale.AutoSize = true;
            this.RbtnMale.Location = new System.Drawing.Point(99, 71);
            this.RbtnMale.Name = "RbtnMale";
            this.RbtnMale.Size = new System.Drawing.Size(43, 19);
            this.RbtnMale.TabIndex = 5;
            this.RbtnMale.TabStop = true;
            this.RbtnMale.Text = "男";
            this.RbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(298, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 25);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名:";
            // 
            // txtStuID
            // 
            this.txtStuID.Location = new System.Drawing.Point(99, 28);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.Size = new System.Drawing.Size(100, 25);
            this.txtStuID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "学号:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(489, 156);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(109, 34);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "添加";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCredit);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtMajor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RbtnFemale);
            this.groupBox1.Controls.Add(this.RbtnMale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStuID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 178);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入学生信息";
            // 
            // dgvAllStu
            // 
            this.dgvAllStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStu.Location = new System.Drawing.Point(30, 253);
            this.dgvAllStu.Name = "dgvAllStu";
            this.dgvAllStu.RowHeadersWidth = 51;
            this.dgvAllStu.RowTemplate.Height = 27;
            this.dgvAllStu.Size = new System.Drawing.Size(436, 265);
            this.dgvAllStu.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "个人明细";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAllStu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "离线访问数据源";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RbtnFemale;
        private System.Windows.Forms.RadioButton RbtnMale;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStuID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllStu;
        private System.Windows.Forms.Button button1;
    }
}

