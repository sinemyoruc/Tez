using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TezProje
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void kurumsal_Click_1(object sender, EventArgs e)
        {
            KurumsalLogin login = new KurumsalLogin();
            login.ShowDialog();
        }

        private void bireysel_Click_1(object sender, EventArgs e)
        {
            BireyselLogin login = new BireyselLogin();
            login.ShowDialog();
        }
    }
}
