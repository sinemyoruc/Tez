using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TezProje
{
    public partial class KurumsalLogin : Form
    {
        public KurumsalLogin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KurumsalRegister register = new KurumsalRegister();
            register.ShowDialog();
        }

        private void buttonGiris_Click_1(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Table_KurumsalLogin WHERE KEmail=@KEmail AND KPass=@KPass";
            con = new SqlConnection("Data Source=DESKTOP-2Q43582;Initial Catalog=Career;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@KEmail", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@KPass", textBoxPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                KurumsalPage kurumsalPage = new KurumsalPage();
                kurumsalPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
    }
}
