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
    public partial class CVlerim : Form
    {
        public CVlerim()
        {
            InitializeComponent();
        }

        private void CVlerim_Load(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("BireyselCV");
            foreach (BsonDocument item in collection.AsQueryable())
            {
                BsonElement Name = item.GetElement("NameSurname");
                BsonElement Birth = item.GetElement("Birth");
                BsonElement Experience = item.GetElement("Experience");
                BsonElement Education = item.GetElement("Education");
                BsonElement Skill = item.GetElement("Skill");
                BsonElement Sertificate = item.GetElement("Sertificate");
                BsonElement Referances = item.GetElement("Referances");
                BsonElement Hobbies = item.GetElement("Hobbies");
                label15.Text = string.Format("{0}", Name.Value.ToString());
                label16.Text = string.Format("{0}", Birth.Value.ToString());
                label9.Text = string.Format("{0}", Experience.Value.ToString());
                label10.Text = string.Format("{0}", Education.Value.ToString());
                label11.Text = string.Format("{0}", Skill.Value.ToString());
                label12.Text = string.Format("{0}", Sertificate.Value.ToString());
                label13.Text = string.Format("{0}", Referances.Value.ToString());
                label14.Text = string.Format("{0}", Hobbies.Value.ToString());
            }

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("BireyselCV");

            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Experience", label9.Text),
                            Builders<BsonDocument>.Update.Set("Experience", textBox4.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Education", label10.Text),
                            Builders<BsonDocument>.Update.Set("Education", textBox5.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Skill", label11.Text),
                            Builders<BsonDocument>.Update.Set("Skill", textBox6.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Sertificate", label12.Text),
                            Builders<BsonDocument>.Update.Set("Sertificate", textBox7.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Referances", label13.Text),
                            Builders<BsonDocument>.Update.Set("Referances", textBox8.Text));
            collection.FindOneAndUpdate(
                           Builders<BsonDocument>.Filter.Eq("Hobbies", label14.Text),
                            Builders<BsonDocument>.Update.Set("Hobbies", textBox9.Text));
            MessageBox.Show("CV'niz Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017");
            var database = dbClient.GetDatabase("Tez");
            var collection = database.GetCollection<BsonDocument>("BireyselCV");

            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("NameSurname", label15.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Birth", label16.Text));
            collection.FindOneAndDelete(
                           Builders<BsonDocument>.Filter.Eq("Experience", label9.Text));
            collection.FindOneAndDelete(
                          Builders<BsonDocument>.Filter.Eq("Education", label10.Text));
            collection.FindOneAndDelete(
                          Builders<BsonDocument>.Filter.Eq("Skill", label11.Text));
            collection.FindOneAndDelete(
                          Builders<BsonDocument>.Filter.Eq("Sertificate", label12.Text));
            collection.FindOneAndDelete(
                          Builders<BsonDocument>.Filter.Eq("Referances", label13.Text));
            collection.FindOneAndDelete(
                          Builders<BsonDocument>.Filter.Eq("Hobbies", label14.Text));
            MessageBox.Show("CV Silindi");
        }
    }
}
