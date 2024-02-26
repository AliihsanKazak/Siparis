using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Siparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_sonuc.Visible = false;
            lbl_ozet.Visible = false;
            lbl_icecek.Visible = false;
            lbl_tatli.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ozet.Text= cmb_yemek.Text;
            lbl_icecek.Text= cmb_icecek.Text;
            lbl_tatli.Text = cmb_tatli.Text;
            lbl_sonuc.Visible = true;
            lbl_ozet.Visible = true;
            lbl_icecek.Visible = true;
            lbl_tatli.Visible = true;

        }
    }
}
