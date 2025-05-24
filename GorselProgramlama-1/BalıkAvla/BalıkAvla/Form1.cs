using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalıkAvla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKapat_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            btnKapat.Left = r.Next(0, this.Width - btnKapat.Width);
            btnKapat.Top = r.Next(0, this.Height - btnKapat.Height);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 700;
        }

        
    }
}
