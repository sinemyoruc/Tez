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
    public partial class BireyselLogin : Form
    {
        public BireyselLogin()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Table_BireyselLogin WHERE BEmail=@BEmail AND BPass=@BPass";
            con = new SqlConnection("Data Source=DESKTOP-2Q43582;Initial Catalog=Career;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@BEmail", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@BPass", textBoxPass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                BireyselPage bireyselPage = new BireyselPage();
                bireyselPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BireyselRegisterForm register = new BireyselRegisterForm();
            register.ShowDialog();
        }
    }
}
