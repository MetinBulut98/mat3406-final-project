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
using System.Xml.Linq;

namespace otoparkotomasyon
{
    public partial class Ekran2 : Form
    {
        public Ekran2()
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
            xmlFile.Close();
        }
     
        private void Ekran2_Load(object sender, EventArgs e)
        {
            Yukle();
            XDocument x = XDocument.Load(@"veri.xml");
            XElement rootElement = x.Root;

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P1")
                {
                    button1.BackColor = Color.Red;
                    button1.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button1.BackColor = Color.Green;
                    button1.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P2")
                {
                    button2.BackColor = Color.Red;
                    button2.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button2.BackColor = Color.Green;
                    button2.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P3")
                {
                    button3.BackColor = Color.Red;
                    button3.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button3.BackColor = Color.Green;
                    button3.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P4")
                {
                    button4.BackColor = Color.Red;
                    button4.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button4.BackColor = Color.Green;
                    button4.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P5")
                {
                    button5.BackColor = Color.Red;
                    button5.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button5.BackColor = Color.Green;
                    button5.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P6")
                {
                    button6.BackColor = Color.Red;
                    button6.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button6.BackColor = Color.Green;
                    button6.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P7")
                {
                    button7.BackColor = Color.Red;
                    button7.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button7.BackColor = Color.Green;
                    button7.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P8")
                {
                    button8.BackColor = Color.Red;
                    button8.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button8.BackColor = Color.Green;
                    button8.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P9")
                {
                    button9.BackColor = Color.Red;
                    button9.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button9.BackColor = Color.Green;
                    button9.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P10")
                {
                    button10.BackColor = Color.Red;
                    button10.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button10.BackColor = Color.Green;
                    button10.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P11")
                {
                    button11.BackColor = Color.Red;
                    button11.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button11.BackColor = Color.Green;
                    button11.Text = "BOŞ";
                }
            }

            foreach (XElement Araclar in rootElement.Elements())
            {
                if (Araclar.Element("parkyeri").Value.Trim() == "P12")
                {
                    button12.BackColor = Color.Red;
                    button12.Text = Araclar.Element("aracplaka").Value.ToString();
                    break;
                }
                else
                {
                    button12.BackColor = Color.Green;
                    button12.Text = "BOŞ";
                }
            }



        }
    }
}
