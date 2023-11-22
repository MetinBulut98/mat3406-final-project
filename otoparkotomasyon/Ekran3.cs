using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace otoparkotomasyon
{
    public partial class Ekran3 : Form
    {
        public Ekran3()
        {
            InitializeComponent();
        }

        void Yukle()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"hasılat.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            double adetsayisi = 0;
            double kayitsayisi = ds.Tables[0].Rows.Count;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                adetsayisi += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }

            label1.Text = adetsayisi.ToString();
            label2.Text = kayitsayisi.ToString();
            xmlFile.Close();
        }

        private void Ekran3_Load(object sender, EventArgs e)
        {
            Yukle();    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
