namespace Ex8_6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细资料DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPath = new System.Windows.Forms.ToolStripTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvDir = new System.Windows.Forms.TreeView();
            this.lvFiles = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.目录ToolStripMenuItem,
            this.视图VToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "maiMenu";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开OToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出XToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            // 
            // 目录ToolStripMenuItem
            // 
            this.目录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem1,
            this.删除DToolStripMenuItem});
            this.目录ToolStripMenuItem.Name = "目录ToolStripMenuItem";
            this.目录ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.目录ToolStripMenuItem.Text = "目录(&D)";
            // 
            // 新建NToolStripMenuItem1
            // 
            this.新建NToolStripMenuItem1.Name = "新建NToolStripMenuItem1";
            this.新建NToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.新建NToolStripMenuItem1.Text = "新建(&N)";
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            // 
            // 视图VToolStripMenuItem
            // 
            this.视图VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标LToolStripMenuItem,
            this.小图标SToolStripMenuItem,
            this.列表LToolStripMenuItem,
            this.详细资料DToolStripMenuItem});
            this.视图VToolStripMenuItem.Name = "视图VToolStripMenuItem";
            this.视图VToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.视图VToolStripMenuItem.Text = "视图(&V)";
            // 
            // 大图标LToolStripMenuItem
            // 
            this.大图标LToolStripMenuItem.Name = "大图标LToolStripMenuItem";
            this.大图标LToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.大图标LToolStripMenuItem.Text = "大图标(&L)";
            // 
            // 小图标SToolStripMenuItem
            // 
            this.小图标SToolStripMenuItem.Name = "小图标SToolStripMenuItem";
            this.小图标SToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.小图标SToolStripMenuItem.Text = "小图标(&S)";
            // 
            // 列表LToolStripMenuItem
            // 
            this.列表LToolStripMenuItem.Name = "列表LToolStripMenuItem";
            this.列表LToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.列表LToolStripMenuItem.Text = "列表(&L)";
            // 
            // 详细资料DToolStripMenuItem
            // 
            this.详细资料DToolStripMenuItem.Name = "详细资料DToolStripMenuItem";
            this.详细资料DToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.详细资料DToolStripMenuItem.Text = "详细资料(&D)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPath});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel1.Text = "路径：";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(100, 27);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "drive.ico");
            this.imageList1.Images.SetKeyName(1, "Folder_closed.ico");
            this.imageList1.Images.SetKeyName(2, "folder_open.ico");
            this.imageList1.Images.SetKeyName(3, "doc.ico");
            this.imageList1.Images.SetKeyName(4, "docx.ico");
            this.imageList1.Images.SetKeyName(5, "txt.ico");
            this.imageList1.Images.SetKeyName(6, "rar.ico");
            this.imageList1.Images.SetKeyName(7, "htm.ico");
            this.imageList1.Images.SetKeyName(8, "ini.ico");
            this.imageList1.Images.SetKeyName(9, "dll.ico");
            this.imageList1.Images.SetKeyName(10, "bat.ico");
            this.imageList1.Images.SetKeyName(11, "exe.ico");
            this.imageList1.Images.SetKeyName(12, "jpg.ico");
            this.imageList1.Images.SetKeyName(13, "gif.ico");
            this.imageList1.Images.SetKeyName(14, "unknow.jpg");
            // 
            // tvDir
            // 
            this.tvDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvDir.Location = new System.Drawing.Point(0, 55);
            this.tvDir.Name = "tvDir";
            this.tvDir.Size = new System.Drawing.Size(188, 447);
            this.tvDir.TabIndex = 2;
            this.tvDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDir_AfterSelect);
            this.tvDir.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDir_NodeMouseDoubleClick);
            // 
            // lvFiles
            // 
            this.lvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chSize,
            this.chType,
            this.chTime});
            this.lvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFiles.HideSelection = false;
            this.lvFiles.LargeImageList = this.imageList1;
            this.lvFiles.Location = new System.Drawing.Point(188, 55);
            this.lvFiles.Name = "lvFiles";
            this.lvFiles.Size = new System.Drawing.Size(450, 447);
            this.lvFiles.TabIndex = 3;
            this.lvFiles.UseCompatibleStateImageBehavior = false;
            this.lvFiles.DoubleClick += new System.EventHandler(this.lvFiles_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 502);
            this.Controls.Add(this.lvFiles);
            this.Controls.Add(this.tvDir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "资源管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细资料DToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPath;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvDir;
        private System.Windows.Forms.ListView lvFiles;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chSize;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chTime;
    }
}

