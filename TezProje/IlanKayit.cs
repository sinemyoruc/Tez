using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class IlanKayit : Form
    {
        public IlanKayit()
        {
            InitializeComponent();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("KurumsalIlanlar");
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
            {
                BsonDocument IsIlani = new BsonDocument()
                      .Add("_id", System.Guid.NewGuid().ToString())
                      .Add("CompanyName", textBox1.Text)
                      .Add("Job", textBox2.Text)
                      .Add("Experience", textBox3.Text)
                      .Add("Education", textBox4.Text)
                      .Add("Description", textBox5.Text)
                      .Add("FLanguage", textBox6.Text)
                      .Add("Link", richTextBox1.Text);
                collection.InsertOne(IsIlani);
                MessageBox.Show("İş İlanınız Kaydedildi!", "Bilgilendirme Penceresi");
                Ilanlar ilan = new Ilanlar();
                ilan.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı Penceresi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ilanlar ilan = new Ilanlar();
            ilan.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
