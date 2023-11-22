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
    public partial class Form1 : Form
    {
        public Form1()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aracekle form2 = new Aracekle();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekran1 form3 = new Ekran1();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekran2 form4 = new Ekran2();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ekran3 form5 = new Ekran3();
            form5.Show();
        }
    }
}
