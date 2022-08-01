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
    public partial class KurumsalRegister : Form
    {
        public KurumsalRegister()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void buttonKayit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPass.Text == textBoxPass2.Text)
                {
                    con = new SqlConnection("Data Source=DESKTOP-2Q43582;Initial Catalog=Career;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("INSERT INTO Table_KurumsalLogin (KurumAdi,KEmail,KPass) VALUES (@KurumAdi,@KEmail,@KPass)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@KurumAdi", TextBoxKurumAdi.Text);
                    cmd.Parameters.AddWithValue("@KEmail", textBoxEmail.Text);
                    cmd.Parameters.AddWithValue("@KPass", textBoxPass.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesabınız oluşturuldu. Giriş Yapınız.");
                }
                else
                {
                    MessageBox.Show("Girilen şifreler uyuşmuyor. Tekrar deneyiniz.");
                }
            }
            catch
            {
                MessageBox.Show("Email ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
    }
}
