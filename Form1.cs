using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai_15formattext
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formatTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormatText formatText = new FormatText();
            formatText.MdiParent = this;
            formatText.Show();

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            string ten = "Lương Hoàng Huy:";
            lblInfo.Text = "Họ và tên thí sinh:" + ten + Environment.NewLine;
            lblInfo.Text += "ngày viết:" + System.DateTime.Now;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.MdiParent = this;
            AboutBox1.Show();
            
        }
    }
}
