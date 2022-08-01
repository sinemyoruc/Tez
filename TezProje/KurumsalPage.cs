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
    public partial class KurumsalPage : Form
    {
        public KurumsalPage()
        {
            InitializeComponent();
        }

        private void buttonIlan_Click(object sender, EventArgs e)
        {
            IlanKayit ilan = new IlanKayit();
            ilan.ShowDialog();
        }
        private void buttonAra_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("BireyselCV");
            string temp = "";
            var filter = Builders<BsonDocument>.Filter.Eq("Education", textBoxArama.Text);
            foreach (var item in collection.Find(filter).ToList())
            {
                BsonElement NameSurname = item.GetElement("NameSurname");
                BsonElement Birth = item.GetElement("Birth");
                BsonElement Experience = item.GetElement("Experience");
                BsonElement Education = item.GetElement("Education");
                BsonElement Skill = item.GetElement("Skill");
                BsonElement Sertificate = item.GetElement("Sertificate");
                BsonElement Referances = item.GetElement("Referances");
                BsonElement Hobbies = item.GetElement("Hobbies");
                temp += string.Format("Ad Soyad: {0}" + System.Environment.NewLine +
                    "Doğum Tarihi: {1}" + System.Environment.NewLine +
                    "Deneyim: {2}" + System.Environment.NewLine +
                    "Eğitim: {3}" + System.Environment.NewLine +
                    "Yetenekler: {4}" + System.Environment.NewLine +
                    "Sertifikalar: {5}" + System.Environment.NewLine +
                    "Referanslar: {6}" + System.Environment.NewLine +
                    "İlgi Alanları: {7}" + System.Environment.NewLine + "-------------------------------------------------------------" + System.Environment.NewLine,
                    NameSurname.Value.ToString(), Birth.Value.ToString(), Experience.Value.ToString(),
                    Education.Value.ToString(), Skill.Value.ToString(), Sertificate.Value.ToString(), Referances.Value.ToString(), Hobbies.Value.ToString());
            }
            label2.Text = temp;
        }

        private void KurumsalPage_Load(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("BireyselCV");
            string temp = "";
            foreach (var item in collection.AsQueryable())
            {
                BsonElement NameSurname = item.GetElement("NameSurname");
                BsonElement Birth = item.GetElement("Birth");
                BsonElement Experience = item.GetElement("Experience");
                BsonElement Education = item.GetElement("Education");
                BsonElement Skill = item.GetElement("Skill");
                BsonElement Sertificate = item.GetElement("Sertificate");
                BsonElement Referances = item.GetElement("Referances");
                BsonElement Hobbies = item.GetElement("Hobbies");
                temp += string.Format("Ad Soyad: {0}" + System.Environment.NewLine +
                    "Doğum Tarihi: {1}" + System.Environment.NewLine +
                    "Deneyim: {2}" + System.Environment.NewLine +
                    "Eğitim: {3}" + System.Environment.NewLine +
                    "Yetenekler: {4}" + System.Environment.NewLine +
                    "Sertifikalar: {5}" + System.Environment.NewLine +
                    "Referanslar: {6}" + System.Environment.NewLine +
                    "İlgi Alanları: {7}" + System.Environment.NewLine + "-------------------------------------------------------------" + System.Environment.NewLine,
                    NameSurname.Value.ToString(), Birth.Value.ToString(), Experience.Value.ToString(),
                    Education.Value.ToString(), Skill.Value.ToString(), Sertificate.Value.ToString(), Referances.Value.ToString(), Hobbies.Value.ToString());
            }
            label2.Text = temp;
        }
    }
}
