using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace otoparkotomasyon
{
    public partial class Aracekle : Form
    {
        public Aracekle()
        {
            InitializeComponent();
        }

        void Yukle()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();
        }

       

        private void Aracekle_Load(object sender, EventArgs e)
        {
            Yukle();
            timer1.Start();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("Araclar").Elements("arac").FirstOrDefault(a => a.Element("aracplaka").Value.Trim() == txtPlaka.Text);
            XElement node2 = x.Element("Araclar").Elements("arac").FirstOrDefault(a => a.Element("parkyeri").Value.Trim() == cmbPark.Text);


            if ((node == null) && (node2 == null))
            {
                x.Element("Araclar").Add(
       new XElement("arac",
       new XElement("musteriadsoyad", txtAdSoyad.Text),
       new XElement("aracplaka", txtPlaka.Text),
       new XElement("aracmarka", txtMarka.Text),
       new XElement("aracmodel", txtModel.Text),
       new XElement("aracrenk", txtRenk.Text),
       new XElement("saat", txtSaat.Text),
       new XElement("parkyeri", cmbPark.Text)


       ));
                x.Save(@"veri.xml");
                Yukle();
            }

            else
             {
                MessageBox.Show("Araç Park Yeri Dolu Veya Araç Zaten İçeride");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("Araclar").Elements("arac").FirstOrDefault(a => a.Element("aracplaka").Value.Trim() == txtPlaka.Text);
            

            if (node != null)
            {
                node.SetElementValue("musteriadsoyad", txtAdSoyad.Text);
                node.SetElementValue("aracmarka", txtMarka.Text);
                node.SetElementValue("aracmodel", txtModel.Text);
                node.SetElementValue("aracrenk", txtRenk.Text);
                node.SetElementValue("saat", txtSaat.Text);
                node.SetElementValue("parkyeri", cmbPark.Text);

                x.Save(@"veri.xml");
                Yukle();
            }
            else 
            {
                MessageBox.Show("Plaka Bulunamadı!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtSaat.Text = DateTime.Now.ToString();
        }

        private void txtSaat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbPark_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdSoyad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
