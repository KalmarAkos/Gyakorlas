using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBaseExercise
{
    public static class XMLManager
    {
        private static XDocument xml;

        public static Task DataToXML(List<Jarmu> jarmuvek, string fNev)
        {
            return Task.Run(() =>
            {
                xml = new XDocument(new XElement("jarmuvek"));

                foreach (Jarmu jarmu in jarmuvek)
                {
                    if (jarmu is Auto a)
                    {
                        xml.Root.Add(new XElement("jarmu",
                            new XAttribute("fajta", "auto"),
                            new XElement("Rendszám", a.Rendszam),
                            new XElement("Gyártó", a.Gyarto),
                            new XElement("Tipus", a.Tipus),
                            new XElement("Hengerűrtartalom", a.Hengerurtartalom.ToString().Replace(".", ",")),
                            new XElement("AutóTípus", (int)a.AutoTipus),
                            new XElement("Csomagtér_mérete", a.CsomagterTerfogat.ToString().Replace(".", ","))
                            ));
                    }
                    else if (jarmu is Motor motor)
                    {
                        xml.Root.Add(new XElement("jarmu",
                            new XAttribute("fajta", "motor"),
                            new XElement("Rendszám", motor.Rendszam),
                            new XElement("Gyártó", motor.Gyarto),
                            new XElement("Tipus", motor.Tipus),
                            new XElement("Hengerűrtartalom", motor.Hengerurtartalom),
                            new XElement("MotorTípus", (int)motor.MotorTipus)
                            ));
                    }
                }

                if (!fNev.EndsWith(".xml"))
                {
                    fNev += ".xml";
                }
                xml.Save(fNev);
            });
        }

        //XML beolvasása SQL-be
        public static List<Jarmu> XMLToData(string path)
        {
            if (File.Exists(path))
            {
                xml = XDocument.Load(path);
                List<Jarmu> jarmuvek = new List<Jarmu>();
                List<XElement> jarmuTagek = (from j in xml.Root.Elements("jarmu") select j).ToList();

                foreach (XElement node in jarmuTagek)
                {
                    if (node.Attribute("fajta").Value == "auto")
                    {
                        MessageBox.Show("Autó beolvasása!", "Autó", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        jarmuvek.Add(new Auto(
                            (AutoTipus)Convert.ToInt32(node.Element("AutóTípus").Value),
                            Convert.ToInt32(node.Element("Csomagtér_mérete").Value),
                            node.Element("Rendszám").Value,
                            node.Element("Gyártó").Value,
                            node.Element("Tipus").Value,
                            Convert.ToInt32(node.Element("Hengerűrtartalom").Value)
                            ));
                    }
                    else if (node.Attribute("fajta").Value == "motor")
                    {
                        MessageBox.Show("Moci beolvasása!", "Motor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        jarmuvek.Add(new Motor(
                            (MotorTipus)Convert.ToInt32(node.Element("MotorTípus").Value),
                            node.Element("Rendszám").Value,
                            node.Element("Gyártó").Value,
                            node.Element("Tipus").Value,
                            Convert.ToInt32(node.Element("Hengerűrtartalom").Value)
                            ));
                    }
                }
                return jarmuvek;
            }
            else
            {
                return new List<Jarmu>();
            }
        }
    }
}
