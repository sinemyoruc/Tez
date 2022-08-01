using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.GridFS;

namespace TezProje
{
    public partial class CVKayit : Form
    {
        public CVKayit()
        {
            InitializeComponent();
        }

        private void CVKayit_Load(object sender, EventArgs e)
        {
            
        }
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("BireyselCV");
            BsonDocument BireyselCVKayit = new BsonDocument()
                       .Add("_id", System.Guid.NewGuid().ToString())
                       .Add("NameSurname", textBox1.Text)
                       .Add("Birth", textBox3.Text)
                       .Add("Experience", textBox4.Text)
                       .Add("Education", textBox5.Text)
                       .Add("Skill", textBox6.Text)
                       .Add("Sertificate", textBox7.Text)
                       .Add("Referances", textBox8.Text)
                       .Add("Hobbies", textBox9.Text);
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" 
                && textBox6.Text != "" && textBox7.Text != "") {
                collection.InsertOne(BireyselCVKayit);
                MessageBox.Show("CV Kaydınız Tamamlandı!", "Bilgilendirme Penceresi");
                CVlerim cv = new CVlerim();
                cv.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!", "Uyarı Penceresi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CVlerim CV = new CVlerim();
            CV.ShowDialog();
        }
    }
}
