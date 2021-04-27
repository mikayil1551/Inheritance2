using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtEt_Click(object sender, EventArgs e)
        {
            EtYemekleri ey = new EtYemekleri();
            MessageBox.Show(ey.SunumSekli());
        }

        private void txtSy_Click(object sender, EventArgs e)
        {
            SebzeYemekleri sb = new SebzeYemekleri();
            MessageBox.Show(sb.SunumSekli());
        }

        private void btnAs_Click(object sender, EventArgs e)
        {
            AraSicaklar ay = new AraSicaklar();
            MessageBox.Show(ay.SunumSekli());
        }
    }
}
