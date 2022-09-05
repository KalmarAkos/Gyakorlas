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
    public partial class JarmuUrlap : Form
    {
        Jarmu jarmu;
        public JarmuUrlap()
        {
            InitializeComponent();
            comAutoTipus.DataSource = Enum.GetValues(typeof(AutoTipus));
            cmbMotorTipus.DataSource = Enum.GetValues(typeof(MotorTipus));
            rb_CheckedChanged(null, null);
        }

        public JarmuUrlap(Jarmu jarmu) : this()
        {
            this.jarmu = jarmu;

            txtRendszam.Text = jarmu.Rendszam.ToString();
            txtGyarto.Text = jarmu.Gyarto.ToString();
            txtTipus.Text = jarmu.Tipus.ToString();
            numHengerurtartalom.Value = (int)jarmu.Hengerurtartalom;

            txtRendszam.Enabled = false;
            rbAuto.Enabled = false;
            rbMotor.Enabled = false;



            if (jarmu is Auto a)
            {
                comAutoTipus.SelectedItem = (AutoTipus)a.AutoTipus;
                txtCsomagter.Text=a.CsomagterTerfogat.ToString();

                rbAuto.Enabled = true;
                rbMotor.Enabled = false;
                rbAuto.Checked = true;
                rbMotor.Checked = false;

                grbAuto.Enabled = true;
                grbMotor.Enabled = false;

                comAutoTipus.Enabled = false;
            }
            else if(jarmu is Motor m)
            {
                cmbMotorTipus.SelectedItem=(MotorTipus)m.MotorTipus;

                rbAuto.Enabled = false;
                rbMotor.Enabled = true;
                rbAuto.Checked = false;
                rbMotor.Checked = true;

                grbAuto.Enabled = false;
                grbMotor.Enabled = true;

                cmbMotorTipus.Enabled = false;
            }

        }

        private void btnRogzit_Click(object sender, EventArgs e)
        {
            try
            {
                if (jarmu == null)
                {
                    if (grbAuto.Enabled)
                    {
                        jarmu = new Auto((AutoTipus)comAutoTipus.SelectedItem, Convert.ToInt32(txtCsomagter.Text), txtRendszam.Text, txtGyarto.Text, txtTipus.Text, (int)numHengerurtartalom.Value);
                    }
                    else
                    {
                        jarmu = new Motor((MotorTipus)cmbMotorTipus.SelectedItem, txtRendszam.Text, txtGyarto.Text, txtTipus.Text, (int)numHengerurtartalom.Value);
                    }
                }
                else
                {
                    jarmu.Gyarto=txtGyarto.Text;
                    jarmu.Tipus=txtTipus.Text;
                    jarmu.Hengerurtartalom = (int)numHengerurtartalom.Value;

                    if(jarmu is Auto a)
                    {
                        a.CsomagterTerfogat = Convert.ToInt32(txtCsomagter.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DialogResult = DialogResult.None;
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAuto.Checked)
            {
                grbAuto.Enabled = true;
                grbMotor.Enabled = false;
                btnRogzit.Enabled = true;
            }
            else
            {
                grbAuto.Enabled = false;
                grbMotor.Enabled = true;
                btnRogzit.Enabled = true;
            }
        }

        public Jarmu Jarmu { get => jarmu; }
    }
}
