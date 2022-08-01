using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;



namespace TezProje
{
    public partial class BireyselPage : Form
    {
        public BireyselPage()
        {
            InitializeComponent();
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("KurumsalIlanlar");
            string temp = "";
            var filter = Builders<BsonDocument>.Filter.Eq("Job", textBoxArama.Text);
            foreach (BsonDocument item in collection.Find(filter).ToList())
            {
                BsonElement CompanyName = item.GetElement("CompanyName");
                BsonElement Job = item.GetElement("Job");
                BsonElement Experience = item.GetElement("Experience");
                BsonElement Education = item.GetElement("Education");
                BsonElement Description = item.GetElement("Description");
                BsonElement FLanguage = item.GetElement("FLanguage");
                BsonElement Link = item.GetElement("Link");
                temp += string.Format("Kurum Adı: {0}" + System.Environment.NewLine +
                    "Aranan Meslek: {1}" + System.Environment.NewLine +
                    "Deneyim: {2}" + System.Environment.NewLine +
                    "Eğitim Seviyesi: {3}" + System.Environment.NewLine +
                    "İş Tanımı: {4}" + System.Environment.NewLine +
                    "Yabancı Dil: {5}" + System.Environment.NewLine +
                    "Başvuru Linki: {6}" + System.Environment.NewLine + "-------------------------------------------------------------" + System.Environment.NewLine,
                    CompanyName.Value.ToString(), Job.Value.ToString(), Experience.Value.ToString(),
                    Education.Value.ToString(), Description.Value.ToString(), FLanguage.Value.ToString(), Link.Value.ToString());
            }
            label2.Text = temp;
        }

        private void buttonCV_Click(object sender, EventArgs e)
        {
            CVKayit kayit = new CVKayit();
            kayit.ShowDialog();
        }

        private void BireyselPage_Load(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("KurumsalIlanlar");
            string temp = "";
            foreach (BsonDocument item in collection.Find(new BsonDocument()).ToList())
            {
                BsonElement CompanyName = item.GetElement("CompanyName");
                BsonElement Job = item.GetElement("Job");
                BsonElement Experience = item.GetElement("Experience");
                BsonElement Education = item.GetElement("Education");
                BsonElement Description = item.GetElement("Description");
                BsonElement FLanguage = item.GetElement("FLanguage");
                BsonElement Link = item.GetElement("Link");
                temp += string.Format("Kurum Adı: {0}" + System.Environment.NewLine +
                    "Aranan Meslek: {1}" + System.Environment.NewLine +
                    "Deneyim: {2}" + System.Environment.NewLine +
                    "Eğitim Seviyesi: {3}" + System.Environment.NewLine +
                    "İş Tanımı: {4}" + System.Environment.NewLine +
                    "Yabancı Dil: {5}" + System.Environment.NewLine +
                    "Başvuru Linki: {6}" + System.Environment.NewLine + "-------------------------------------------------------------" + System.Environment.NewLine,
                    CompanyName.Value.ToString(), Job.Value.ToString(), Experience.Value.ToString(),
                    Education.Value.ToString(), Description.Value.ToString(), FLanguage.Value.ToString(), Link.Value.ToString());
            }
            label2.Text = temp;
        }
    }
}
