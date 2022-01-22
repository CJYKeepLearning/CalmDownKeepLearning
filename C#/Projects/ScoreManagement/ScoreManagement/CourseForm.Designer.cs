namespace ScoreManagement
{
    partial class CourseForm
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
            this.stuKCDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.stuKCDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // stuKCDGV
            // 
            this.stuKCDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuKCDGV.Location = new System.Drawing.Point(11, 10);
            this.stuKCDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stuKCDGV.Name = "stuKCDGV";
            this.stuKCDGV.RowHeadersWidth = 51;
            this.stuKCDGV.RowTemplate.Height = 30;
            this.stuKCDGV.Size = new System.Drawing.Size(635, 218);
            this.stuKCDGV.TabIndex = 0;
            this.stuKCDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stuKCDGV_CellContentClick);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 239);
            this.Controls.Add(this.stuKCDGV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseForm";
            this.Text = "学生选课信息";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuKCDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView stuKCDGV;
    }
}