namespace DataBaseExercise
{
    partial class frmMain
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
            this.lstJarmuvek = new System.Windows.Forms.ListBox();
            this.btnUjJarmu = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnJarmuToXML = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstJarmuvek
            // 
            this.lstJarmuvek.FormattingEnabled = true;
            this.lstJarmuvek.ItemHeight = 16;
            this.lstJarmuvek.Location = new System.Drawing.Point(13, 13);
            this.lstJarmuvek.Name = "lstJarmuvek";
            this.lstJarmuvek.Size = new System.Drawing.Size(576, 388);
            this.lstJarmuvek.TabIndex = 0;
            // 
            // btnUjJarmu
            // 
            this.btnUjJarmu.Location = new System.Drawing.Point(596, 13);
            this.btnUjJarmu.Name = "btnUjJarmu";
            this.btnUjJarmu.Size = new System.Drawing.Size(192, 56);
            this.btnUjJarmu.TabIndex = 1;
            this.btnUjJarmu.Text = "Új jármű";
            this.btnUjJarmu.UseVisualStyleBackColor = true;
            this.btnUjJarmu.Click += new System.EventHandler(this.btnUjJarmu_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(596, 75);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(192, 56);
            this.btnModositas.TabIndex = 2;
            this.btnModositas.Text = "Jármű módosítása";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(595, 137);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(192, 56);
            this.btnTorles.TabIndex = 3;
            this.btnTorles.Text = "Jármű törlése";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnJarmuToXML
            // 
            this.btnJarmuToXML.Location = new System.Drawing.Point(595, 345);
            this.btnJarmuToXML.Name = "btnJarmuToXML";
            this.btnJarmuToXML.Size = new System.Drawing.Size(192, 56);
            this.btnJarmuToXML.TabIndex = 4;
            this.btnJarmuToXML.Text = "Jármű mentése XML dokumentumba";
            this.btnJarmuToXML.UseVisualStyleBackColor = true;
            this.btnJarmuToXML.Click += new System.EventHandler(this.btnJarmuToXML_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "XML file beolvasása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnJarmuToXML);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.btnUjJarmu);
            this.Controls.Add(this.lstJarmuvek);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jarmuvek";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstJarmuvek;
        private System.Windows.Forms.Button btnUjJarmu;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnJarmuToXML;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

