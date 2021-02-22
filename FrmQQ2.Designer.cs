namespace MySchool
{
    partial class FrmQQ2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQQ2));
            this.lvQQS = new System.Windows.Forms.ListView();
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.ilBig = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvQQS
            // 
            this.lvQQS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvQQS.HideSelection = false;
            this.lvQQS.Location = new System.Drawing.Point(12, 12);
            this.lvQQS.Name = "lvQQS";
            this.lvQQS.Size = new System.Drawing.Size(484, 390);
            this.lvQQS.TabIndex = 0;
            this.lvQQS.UseCompatibleStateImageBehavior = false;
            this.lvQQS.View = System.Windows.Forms.View.Details;
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "图1.png");
            this.ilSmall.Images.SetKeyName(1, "图2.png");
            this.ilSmall.Images.SetKeyName(2, "图3.png");
            // 
            // ilBig
            // 
            this.ilBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBig.ImageStream")));
            this.ilBig.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBig.Images.SetKeyName(0, "大图1.png");
            this.ilBig.Images.SetKeyName(1, "大图2.png");
            this.ilBig.Images.SetKeyName(2, "大图3.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "大小";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "可用空间";
            // 
            // FrmQQ2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.lvQQS);
            this.Name = "FrmQQ2";
            this.Text = "FrmQQ2";
            this.Load += new System.EventHandler(this.FrmQQ2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvQQS;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ImageList ilBig;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}