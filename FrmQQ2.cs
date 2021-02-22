using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySchool
{
    public partial class FrmQQ2 : Form
    {
        public FrmQQ2()
        {
            InitializeComponent();
        }

        private void FrmQQ2_Load(object sender, EventArgs e)
        {
            lvQQS.LargeImageList = ilBig;//关联大图标
            lvQQS.SmallImageList = ilSmall;//关联小图标 

            lvQQS.Items.Add("C盘", 0);
            lvQQS.Items[0].SubItems.Add("本地磁盘");
            lvQQS.Items[0].SubItems.AddRange(new string[] { "20G", "15G" });

            /* //创建主项
             ListViewItem item = new ListViewItem();
             item.Text = "D盘";
             item.ImageIndex = 1;

             item.SubItems.AddRange(new string[] { "本地磁盘", "30G", "10G" });

             lvQQS.Items.Add(item);//添加主项*/

            ListViewItem item = new ListViewItem("D盘",1);
            item.SubItems.AddRange(new string[] { "本地磁盘", "30G", "10G" });
            lvQQS.Items.Add(item);


            lvQQS.Items.Add(new ListViewItem() { Text = "E盘", ImageIndex = 2 });

            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem();
            subItem.Text = "本地磁盘";
            ListViewItem.ListViewSubItem subItem2 = new ListViewItem.ListViewSubItem();
            subItem2.Text = "100g";
            ListViewItem.ListViewSubItem subItem3 = new ListViewItem.ListViewSubItem();
            subItem3.Text = "30g";

            lvQQS.Items[2].SubItems.AddRange(new ListViewItem.ListViewSubItem[] { subItem, subItem2, subItem3 });

        }
    }
}
