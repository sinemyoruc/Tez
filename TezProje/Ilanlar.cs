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
    public partial class Ilanlar : Form
    {
        public Ilanlar()
        {
            InitializeComponent();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("KurumsalIlanlar");

            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Job", label8.Text),
                            Builders<BsonDocument>.Update.Set("Job", textBox2.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Experience", label9.Text),
                            Builders<BsonDocument>.Update.Set("Experience", textBox3.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Education", label10.Text),
                            Builders<BsonDocument>.Update.Set("Education", textBox4.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("FLanguage", label11.Text),
                            Builders<BsonDocument>.Update.Set("FLanguage", textBox6.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Description", label12.Text),
                            Builders<BsonDocument>.Update.Set("Description", textBox5.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Link", linkLabel1.Text),
                            Builders<BsonDocument>.Update.Set("Link", richTextBox1.Text));
            MessageBox.Show("İlanınız Güncellendi");
        }

        private void Ilanlar_Load(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("KurumsalIlanlar");
            foreach (BsonDocument item in collection.AsQueryable())
            {
                BsonElement CompanyName = item.GetElement("CompanyName");
                BsonElement Job = item.GetElement("Job");
                BsonElement Experience = item.GetElement("Experience");
                BsonElement Education = item.GetElement("Education");
                BsonElement FLanguage = item.GetElement("FLanguage");
                BsonElement Description = item.GetElement("Description");
                BsonElement Link = item.GetElement("Link");
                label7.Text = string.Format("{0}", CompanyName.Value.ToString());
                label8.Text = string.Format("{0}", Job.Value.ToString());
                label9.Text = string.Format("{0}", Experience.Value.ToString());
                label10.Text = string.Format("{0}", Education.Value.ToString());
                label11.Text = string.Format("{0}", FLanguage.Value.ToString());
                label12.Text = string.Format("{0}", Description.Value.ToString());
                linkLabel1.Text = string.Format("{0}", Link.Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("KurumsalIlanlar");

            collection.FindOneAndDelete(
                          Builders<BsonDocument>.Filter.Eq("CompanyName", label7.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Job", label8.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Experience", label9.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Education", label10.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("FLanguage", label11.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Description", label12.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Link", linkLabel1.Text));
            MessageBox.Show("İlanınız Silindi");
        }
    }
}
