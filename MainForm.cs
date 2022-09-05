using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseExercise
{
    public partial class frmMain : Form
    {
        private List<Jarmu> jarmuLista;
        public frmMain()
        {
            InitializeComponent();
            DBManager.ConnectToDatabase();
            jarmuLista = DBManager.JarmuvekKiolvasasa();
            Listazas();
        }

        public void Listazas()
        {
            lstJarmuvek.DataSource = null;
            lstJarmuvek.DataSource = jarmuLista;
        }

        private void btnUjJarmu_Click(object sender, EventArgs e)
        {
            JarmuUrlap frm = new JarmuUrlap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (frm.Jarmu is Auto a)
                    {
                        DBManager.AutoFelvitele(a);
                    }
                    else if (frm.Jarmu is Motor m)
                    {
                        DBManager.MotorFelvitele(m);
                    }
                    jarmuLista = DBManager.JarmuvekKiolvasasa();
                    Listazas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModositas_Click(object sender, EventArgs e)
        {
            if (lstJarmuvek.SelectedIndex < 0)
            {
                MessageBox.Show("Hiba", "Módosításhoz jelöljön ki egy adatot!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = lstJarmuvek.SelectedIndex;
                Jarmu jarmu = jarmuLista[index];

                JarmuUrlap frm = new JarmuUrlap(jarmu);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (jarmu is Auto a)
                        {
                            DBManager.AutoModositas(a);
                        }
                        else if (jarmu is Motor m)
                        {
                            DBManager.MotorModositas(m);
                        }
                        jarmuLista = DBManager.JarmuvekKiolvasasa();
                        Listazas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DBManager.DisconnectFromDataBase();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (lstJarmuvek.SelectedIndex < 0)
            {
                MessageBox.Show("Törléshez jelöljön ki egy elemet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Biztos, hogy törli az elemet?", "Elem törlése", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        Jarmu torlendo = (Jarmu)lstJarmuvek.SelectedItem;
                        if (torlendo is Auto a)
                        {
                            DBManager.AutoTorles(a);
                        }
                        else if (torlendo is Motor m)
                        {
                            DBManager.MotorTorles(m);
                        }
                        jarmuLista = DBManager.JarmuvekKiolvasasa();
                        Listazas();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnJarmuToXML_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    await XMLManager.DataToXML(jarmuLista, saveFileDialog1.FileName);
                    MessageBox.Show("Sikeres exportálás XML-be!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Sikertelen exportálás XML-be!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DBManager.ABUrites();
                    jarmuLista.Clear();
                    jarmuLista = XMLManager.XMLToData(openFileDialog1.FileName);

                    foreach (Jarmu j in jarmuLista)
                    {
                        if (j is Auto a)
                        {
                            DBManager.AutoFelvitele(a);
                        }
                        else if (j is Motor m)
                        {
                            DBManager.MotorFelvitele(m);
                        }
                    }

                    Listazas();
                }
            }
            catch
            {
                MessageBox.Show("Sikertelen XML importalas!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
