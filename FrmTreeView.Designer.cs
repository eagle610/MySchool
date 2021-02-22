namespace MySchool
{
    partial class FrmTreeView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("S1", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("S2", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Y2", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("全部", 0, 1, new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeView));
            this.tvGrades = new System.Windows.Forms.TreeView();
            this.ilList = new System.Windows.Forms.ImageList(this.components);
            this.dgvStus = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStus)).BeginInit();
            this.SuspendLayout();
            // 
            // tvGrades
            // 
            this.tvGrades.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvGrades.ImageIndex = 0;
            this.tvGrades.ImageList = this.ilList;
            this.tvGrades.Location = new System.Drawing.Point(0, 0);
            this.tvGrades.Name = "tvGrades";
            treeNode1.Name = "节点5";
            treeNode1.Text = "男";
            treeNode2.Name = "节点6";
            treeNode2.Text = "女";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "节点2";
            treeNode3.SelectedImageIndex = 1;
            treeNode3.Text = "S1";
            treeNode4.Name = "节点7";
            treeNode4.Text = "男";
            treeNode5.Name = "节点8";
            treeNode5.Text = "女";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "节点3";
            treeNode6.SelectedImageIndex = 1;
            treeNode6.Text = "S2";
            treeNode7.Name = "节点9";
            treeNode7.Text = "男";
            treeNode8.Name = "节点10";
            treeNode8.Text = "女";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "节点4";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Y2";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "节点0";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "全部";
            this.tvGrades.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.tvGrades.SelectedImageIndex = 1;
            this.tvGrades.ShowLines = false;
            this.tvGrades.Size = new System.Drawing.Size(152, 450);
            this.tvGrades.TabIndex = 0;
            this.tvGrades.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvGrades_AfterSelect);
            // 
            // ilList
            // 
            this.ilList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilList.ImageStream")));
            this.ilList.TransparentColor = System.Drawing.Color.Transparent;
            this.ilList.Images.SetKeyName(0, "tsbtn3.png");
            this.ilList.Images.SetKeyName(1, "tsbtn4.png");
            // 
            // dgvStus
            // 
            this.dgvStus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStus.Location = new System.Drawing.Point(152, 0);
            this.dgvStus.Name = "dgvStus";
            this.dgvStus.RowTemplate.Height = 23;
            this.dgvStus.Size = new System.Drawing.Size(648, 450);
            this.dgvStus.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StudentNo";
            this.Column1.HeaderText = "学号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StudentName";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gender";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GradeName";
            this.Column4.HeaderText = "年级";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Phone";
            this.Column5.HeaderText = "电话";
            this.Column5.Name = "Column5";
            // 
            // FrmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStus);
            this.Controls.Add(this.tvGrades);
            this.Name = "FrmTreeView";
            this.Text = "树形菜单 ";
            this.Load += new System.EventHandler(this.FrmTreeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvGrades;
        private System.Windows.Forms.ImageList ilList;
        private System.Windows.Forms.DataGridView dgvStus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}