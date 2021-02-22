namespace MySchool
{
    partial class FrmQQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQQ));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "C盘",
            "本地磁盘",
            "30G",
            "21G"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "D盘",
            "本地磁盘",
            "200G",
            "150G"}, 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "E盘",
            "本地磁盘",
            "150G",
            "100G"}, 2);
            this.ilBig = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.lvList = new System.Windows.Forms.ListView();
            this.btnBig = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXx = new System.Windows.Forms.Button();
            this.cmsOper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiXx = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilBig
            // 
            this.ilBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBig.ImageStream")));
            this.ilBig.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBig.Images.SetKeyName(0, "大图1.png");
            this.ilBig.Images.SetKeyName(1, "大图2.png");
            this.ilBig.Images.SetKeyName(2, "大图3.png");
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "图1.png");
            this.ilSmall.Images.SetKeyName(1, "图2.png");
            this.ilSmall.Images.SetKeyName(2, "图3.png");
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvList.ContextMenuStrip = this.cmsOper;
            this.lvList.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.lvList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvList.LargeImageList = this.ilBig;
            this.lvList.Location = new System.Drawing.Point(0, 0);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(555, 353);
            this.lvList.SmallImageList = this.ilSmall;
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // btnBig
            // 
            this.btnBig.Location = new System.Drawing.Point(372, 379);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(75, 23);
            this.btnBig.TabIndex = 1;
            this.btnBig.Text = "大图标";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.BtnBig_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(468, 379);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "小图标";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.BtnSmall_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "大小";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "可用空间";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 118;
            // 
            // btnXx
            // 
            this.btnXx.Location = new System.Drawing.Point(276, 379);
            this.btnXx.Name = "btnXx";
            this.btnXx.Size = new System.Drawing.Size(75, 23);
            this.btnXx.TabIndex = 2;
            this.btnXx.Text = "详细视图";
            this.btnXx.UseVisualStyleBackColor = true;
            this.btnXx.Click += new System.EventHandler(this.BtnXx_Click);
            // 
            // cmsOper
            // 
            this.cmsOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBig,
            this.tsmiSmall,
            this.tsmiXx});
            this.cmsOper.Name = "cmsOper";
            this.cmsOper.Size = new System.Drawing.Size(181, 92);
            // 
            // tsmiBig
            // 
            this.tsmiBig.Name = "tsmiBig";
            this.tsmiBig.Size = new System.Drawing.Size(180, 22);
            this.tsmiBig.Text = "大图标";
            this.tsmiBig.Click += new System.EventHandler(this.BtnBig_Click);
            // 
            // tsmiSmall
            // 
            this.tsmiSmall.Name = "tsmiSmall";
            this.tsmiSmall.Size = new System.Drawing.Size(180, 22);
            this.tsmiSmall.Text = "小图标";
            this.tsmiSmall.Click += new System.EventHandler(this.BtnSmall_Click);
            // 
            // tsmiXx
            // 
            this.tsmiXx.Name = "tsmiXx";
            this.tsmiXx.Size = new System.Drawing.Size(180, 22);
            this.tsmiXx.Text = "详细视图";
            this.tsmiXx.Click += new System.EventHandler(this.BtnXx_Click);
            // 
            // FrmQQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 414);
            this.Controls.Add(this.btnXx);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnBig);
            this.Controls.Add(this.lvList);
            this.Name = "FrmQQ";
            this.Text = "我的电脑";
            this.cmsOper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilBig;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnXx;
        private System.Windows.Forms.ContextMenuStrip cmsOper;
        private System.Windows.Forms.ToolStripMenuItem tsmiBig;
        private System.Windows.Forms.ToolStripMenuItem tsmiSmall;
        private System.Windows.Forms.ToolStripMenuItem tsmiXx;
    }
}