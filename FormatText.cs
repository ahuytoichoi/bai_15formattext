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
    public partial class FormatText: Form
    {
        public FormatText()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapten.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLapTrinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Red;
            txtNhapten.ForeColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Green;
            txtNhapten.ForeColor = Color.Green;
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size,lblLapTrinh.Font.Style ^ FontStyle.Bold);
            txtNhapten.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size,txtNhapten.Font.Style ^ FontStyle.Bold);
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Blue;
            txtNhapten.ForeColor = Color.Blue;
        }

        private void rabBlack_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.ForeColor = Color.Black;
            txtNhapten.ForeColor = Color.Black;
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
            txtNhapten.Font = new Font(txtNhapten.Font.Name, txtNhapten.Font.Size, txtNhapten.Font.Style ^ FontStyle.Italic);
        }

        private void chkChan_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
            
        }
    }
}
