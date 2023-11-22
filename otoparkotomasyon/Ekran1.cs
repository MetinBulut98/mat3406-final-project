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
    public partial class Ekran1 : Form
    {
        public Ekran1()
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
        private void Ekran1_Load(object sender, EventArgs e)
        {
            Yukle();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");

            x.Root.Elements().Where(a => a.Element("aracplaka").Value == txtPlaka.Text).Remove();
            x.Root.Elements().Where(a => a.Element("parkyeri").Value == cmbPark.Text).Remove();

            x.Save(@"veri.xml");
            Yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            TimeSpan fark;
            XElement rootElement = x.Root;
            XElement node = x.Element("Araclar").Elements("arac").FirstOrDefault(a => a.Element("aracplaka").Value.Trim() == txtPlaka.Text);

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("aracplaka").Value.Trim() == txtPlaka.Text)
                {

                    label8.Text = Araclar.Element("aracplaka").Value.Trim();
                    label9.Text = Araclar.Element("saat").Value.Trim();
                    label10.Text = DateTime.Now.ToString();
                    fark = DateTime.Parse(label10.Text) - DateTime.Parse(label9.Text);
                    
                    label11.Text = Convert.ToInt32(fark.Days) + "Gün / " + Convert.ToInt32(fark.Hours) + "Saat / " + Convert.ToInt32(fark.Minutes);
                    String saathesap = (Convert.ToInt32((fark.Days * 24) + fark.Hours)).ToString();
                    int ucretHesap = Convert.ToInt32(saathesap) * 10;
                    label12.Text = ucretHesap.ToString();
                    label14.Text = saathesap.ToString();
                    if (ucretHesap == 0)
                    {
                        MessageBox.Show("1 Saat Altı 10 TL ");
                        label12.Text = "10";
                    }

                }


            }

            while (node == null)
            {
                MessageBox.Show("Girilin Plaka ile bir araç bulunamamıştır");
                break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XDocument b = XDocument.Load(@"hasılat.xml");

            XElement node = x.Element("Araclar").Elements("arac").FirstOrDefault(a => a.Element("aracplaka").Value.Trim() == txtPlaka.Text);

            if (node != null)
            {
                b.Element("Araclar").Add(
                    new XElement("arac",
                    new XElement("aracplaka", label8.Text),
                    new XElement("ücret", label12.Text)
                ));
                b.Save(@"hasılat.xml");
                Yukle();
                MessageBox.Show("Ücret Alındı Araç ÇIKABİLİR!");
            }
            
        }

       
    }
}
