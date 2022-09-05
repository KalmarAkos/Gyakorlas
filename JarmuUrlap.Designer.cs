namespace DataBaseExercise
{
    partial class JarmuUrlap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRogzit = new System.Windows.Forms.Button();
            this.btnMegsem = new System.Windows.Forms.Button();
            this.grbJarmu = new System.Windows.Forms.GroupBox();
            this.rbMotor = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.numHengerurtartalom = new System.Windows.Forms.NumericUpDown();
            this.txtTipus = new System.Windows.Forms.TextBox();
            this.txtGyarto = new System.Windows.Forms.TextBox();
            this.txtRendszam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAuto = new System.Windows.Forms.GroupBox();
            this.txtCsomagter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comAutoTipus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbMotor = new System.Windows.Forms.GroupBox();
            this.cmbMotorTipus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grbJarmu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHengerurtartalom)).BeginInit();
            this.grbAuto.SuspendLayout();
            this.grbMotor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRogzit
            // 
            this.btnRogzit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRogzit.Location = new System.Drawing.Point(13, 443);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(171, 48);
            this.btnRogzit.TabIndex = 0;
            this.btnRogzit.Text = "Rögzít";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // btnMegsem
            // 
            this.btnMegsem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMegsem.Location = new System.Drawing.Point(190, 443);
            this.btnMegsem.Name = "btnMegsem";
            this.btnMegsem.Size = new System.Drawing.Size(178, 48);
            this.btnMegsem.TabIndex = 1;
            this.btnMegsem.Text = "Mégsem";
            this.btnMegsem.UseVisualStyleBackColor = true;
            // 
            // grbJarmu
            // 
            this.grbJarmu.Controls.Add(this.rbMotor);
            this.grbJarmu.Controls.Add(this.rbAuto);
            this.grbJarmu.Controls.Add(this.numHengerurtartalom);
            this.grbJarmu.Controls.Add(this.txtTipus);
            this.grbJarmu.Controls.Add(this.txtGyarto);
            this.grbJarmu.Controls.Add(this.txtRendszam);
            this.grbJarmu.Controls.Add(this.label4);
            this.grbJarmu.Controls.Add(this.label3);
            this.grbJarmu.Controls.Add(this.label2);
            this.grbJarmu.Controls.Add(this.label1);
            this.grbJarmu.Location = new System.Drawing.Point(13, 13);
            this.grbJarmu.Name = "grbJarmu";
            this.grbJarmu.Size = new System.Drawing.Size(355, 222);
            this.grbJarmu.TabIndex = 2;
            this.grbJarmu.TabStop = false;
            this.grbJarmu.Text = "Jármű";
            // 
            // rbMotor
            // 
            this.rbMotor.AutoSize = true;
            this.rbMotor.Location = new System.Drawing.Point(92, 196);
            this.rbMotor.Name = "rbMotor";
            this.rbMotor.Size = new System.Drawing.Size(62, 20);
            this.rbMotor.TabIndex = 9;
            this.rbMotor.Text = "Motor";
            this.rbMotor.UseVisualStyleBackColor = true;
            this.rbMotor.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Checked = true;
            this.rbAuto.Location = new System.Drawing.Point(92, 170);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(55, 20);
            this.rbAuto.TabIndex = 8;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Autó";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // numHengerurtartalom
            // 
            this.numHengerurtartalom.Location = new System.Drawing.Point(92, 114);
            this.numHengerurtartalom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numHengerurtartalom.Name = "numHengerurtartalom";
            this.numHengerurtartalom.Size = new System.Drawing.Size(120, 22);
            this.numHengerurtartalom.TabIndex = 7;
            // 
            // txtTipus
            // 
            this.txtTipus.Location = new System.Drawing.Point(92, 84);
            this.txtTipus.Name = "txtTipus";
            this.txtTipus.Size = new System.Drawing.Size(257, 22);
            this.txtTipus.TabIndex = 6;
            // 
            // txtGyarto
            // 
            this.txtGyarto.Location = new System.Drawing.Point(92, 53);
            this.txtGyarto.Name = "txtGyarto";
            this.txtGyarto.Size = new System.Drawing.Size(257, 22);
            this.txtGyarto.TabIndex = 5;
            // 
            // txtRendszam
            // 
            this.txtRendszam.Location = new System.Drawing.Point(92, 22);
            this.txtRendszam.Name = "txtRendszam";
            this.txtRendszam.Size = new System.Drawing.Size(257, 22);
            this.txtRendszam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ccm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Típus :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gyártó :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám :";
            // 
            // grbAuto
            // 
            this.grbAuto.Controls.Add(this.txtCsomagter);
            this.grbAuto.Controls.Add(this.label6);
            this.grbAuto.Controls.Add(this.comAutoTipus);
            this.grbAuto.Controls.Add(this.label5);
            this.grbAuto.Location = new System.Drawing.Point(13, 242);
            this.grbAuto.Name = "grbAuto";
            this.grbAuto.Size = new System.Drawing.Size(355, 114);
            this.grbAuto.TabIndex = 3;
            this.grbAuto.TabStop = false;
            this.grbAuto.Text = "Autó adatok";
            // 
            // txtCsomagter
            // 
            this.txtCsomagter.Location = new System.Drawing.Point(92, 69);
            this.txtCsomagter.Name = "txtCsomagter";
            this.txtCsomagter.Size = new System.Drawing.Size(257, 22);
            this.txtCsomagter.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Csomagtér :";
            // 
            // comAutoTipus
            // 
            this.comAutoTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAutoTipus.FormattingEnabled = true;
            this.comAutoTipus.Location = new System.Drawing.Point(92, 29);
            this.comAutoTipus.Name = "comAutoTipus";
            this.comAutoTipus.Size = new System.Drawing.Size(257, 24);
            this.comAutoTipus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Típus :";
            // 
            // grbMotor
            // 
            this.grbMotor.Controls.Add(this.cmbMotorTipus);
            this.grbMotor.Controls.Add(this.label8);
            this.grbMotor.Location = new System.Drawing.Point(13, 362);
            this.grbMotor.Name = "grbMotor";
            this.grbMotor.Size = new System.Drawing.Size(355, 75);
            this.grbMotor.TabIndex = 13;
            this.grbMotor.TabStop = false;
            this.grbMotor.Text = "Motor adatok";
            // 
            // cmbMotorTipus
            // 
            this.cmbMotorTipus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotorTipus.FormattingEnabled = true;
            this.cmbMotorTipus.Location = new System.Drawing.Point(92, 29);
            this.cmbMotorTipus.Name = "cmbMotorTipus";
            this.cmbMotorTipus.Size = new System.Drawing.Size(257, 24);
            this.cmbMotorTipus.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Típus :";
            // 
            // JarmuUrlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 510);
            this.Controls.Add(this.grbMotor);
            this.Controls.Add(this.grbAuto);
            this.Controls.Add(this.grbJarmu);
            this.Controls.Add(this.btnMegsem);
            this.Controls.Add(this.btnRogzit);
            this.Name = "JarmuUrlap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Járművek felvitele";
            this.grbJarmu.ResumeLayout(false);
            this.grbJarmu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHengerurtartalom)).EndInit();
            this.grbAuto.ResumeLayout(false);
            this.grbAuto.PerformLayout();
            this.grbMotor.ResumeLayout(false);
            this.grbMotor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Button btnMegsem;
        private System.Windows.Forms.GroupBox grbJarmu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMotor;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.NumericUpDown numHengerurtartalom;
        private System.Windows.Forms.TextBox txtTipus;
        private System.Windows.Forms.TextBox txtGyarto;
        private System.Windows.Forms.TextBox txtRendszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbAuto;
        private System.Windows.Forms.TextBox txtCsomagter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comAutoTipus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbMotor;
        private System.Windows.Forms.ComboBox cmbMotorTipus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}