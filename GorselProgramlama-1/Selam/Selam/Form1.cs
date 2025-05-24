using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selam
{
    public partial class bSelam : Form
    {
        public bSelam()
        {
            InitializeComponent();
        }

        private void bKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSelam_Load(object sender, EventArgs e)
        {
            if (tbAd.Text == "")
            tbAd.Text = "Yunus";
            MessageBox.Show("Merhaba, " + tbAd.Text + "!");
        }

        private void bSelamla_Click(object sender, EventArgs e)
        {
            bSelamla.Left -= 10;
            bSelamla.Width += 20;
        }
    }
}
