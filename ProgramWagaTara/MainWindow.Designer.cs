namespace ProgramWagaTara
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Body = new System.Windows.Forms.Panel();
            this.UsunTareButton = new System.Windows.Forms.Button();
            this.TarujButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.taraTextBox = new System.Windows.Forms.TextBox();
            this.Brutto = new System.Windows.Forms.Panel();
            this.BruttoLabel = new System.Windows.Forms.Label();
            this.BruttoCheckbox = new System.Windows.Forms.Panel();
            this.Netto = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.NettoCheckbox = new System.Windows.Forms.Panel();
            this.Jednostka = new System.Windows.Forms.Label();
            this.Masa = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UstawieniaKomunikacji = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.COMPortsComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.stabilne = new System.Windows.Forms.Panel();
            this.zero = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Body.SuspendLayout();
            this.Brutto.SuspendLayout();
            this.Netto.SuspendLayout();
            this.Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UstawieniaKomunikacji.SuspendLayout();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.Controls.Add(this.zero);
            this.Body.Controls.Add(this.label11);
            this.Body.Controls.Add(this.stabilne);
            this.Body.Controls.Add(this.label10);
            this.Body.Controls.Add(this.UsunTareButton);
            this.Body.Controls.Add(this.TarujButton);
            this.Body.Controls.Add(this.label3);
            this.Body.Controls.Add(this.label2);
            this.Body.Controls.Add(this.taraTextBox);
            this.Body.Controls.Add(this.Brutto);
            this.Body.Controls.Add(this.Netto);
            this.Body.Controls.Add(this.Jednostka);
            this.Body.Controls.Add(this.Masa);
            this.Body.Dock = System.Windows.Forms.DockStyle.Top;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(304, 199);
            this.Body.TabIndex = 0;
            // 
            // UsunTareButton
            // 
            this.UsunTareButton.Enabled = false;
            this.UsunTareButton.Location = new System.Drawing.Point(225, 140);
            this.UsunTareButton.Name = "UsunTareButton";
            this.UsunTareButton.Size = new System.Drawing.Size(67, 43);
            this.UsunTareButton.TabIndex = 8;
            this.UsunTareButton.Text = "USUŃ TARĘ";
            this.UsunTareButton.UseVisualStyleBackColor = true;
            this.UsunTareButton.Click += new System.EventHandler(this.UsunTareButton_Click);
            // 
            // TarujButton
            // 
            this.TarujButton.Enabled = false;
            this.TarujButton.Location = new System.Drawing.Point(156, 140);
            this.TarujButton.Name = "TarujButton";
            this.TarujButton.Size = new System.Drawing.Size(67, 43);
            this.TarujButton.TabIndex = 7;
            this.TarujButton.Text = "TARUJ";
            this.TarujButton.UseVisualStyleBackColor = true;
            this.TarujButton.Click += new System.EventHandler(this.TarujButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tara:";
            // 
            // taraTextBox
            // 
            this.taraTextBox.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.taraTextBox.Location = new System.Drawing.Point(12, 140);
            this.taraTextBox.MaxLength = 4;
            this.taraTextBox.Name = "taraTextBox";
            this.taraTextBox.Size = new System.Drawing.Size(106, 44);
            this.taraTextBox.TabIndex = 9;
            this.taraTextBox.TextChanged += new System.EventHandler(this.taraTextBox_TextChanged);
            // 
            // Brutto
            // 
            this.Brutto.BackColor = System.Drawing.Color.LimeGreen;
            this.Brutto.Controls.Add(this.BruttoLabel);
            this.Brutto.Controls.Add(this.BruttoCheckbox);
            this.Brutto.Location = new System.Drawing.Point(223, 88);
            this.Brutto.Name = "Brutto";
            this.Brutto.Size = new System.Drawing.Size(64, 18);
            this.Brutto.TabIndex = 3;
            // 
            // BruttoLabel
            // 
            this.BruttoLabel.AutoSize = true;
            this.BruttoLabel.Location = new System.Drawing.Point(25, 3);
            this.BruttoLabel.Name = "BruttoLabel";
            this.BruttoLabel.Size = new System.Drawing.Size(35, 13);
            this.BruttoLabel.TabIndex = 2;
            this.BruttoLabel.Text = "Brutto";
            // 
            // BruttoCheckbox
            // 
            this.BruttoCheckbox.BackColor = System.Drawing.Color.Chartreuse;
            this.BruttoCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BruttoCheckbox.Location = new System.Drawing.Point(7, 1);
            this.BruttoCheckbox.Name = "BruttoCheckbox";
            this.BruttoCheckbox.Size = new System.Drawing.Size(15, 15);
            this.BruttoCheckbox.TabIndex = 1;
            // 
            // Netto
            // 
            this.Netto.BackColor = System.Drawing.Color.LimeGreen;
            this.Netto.Controls.Add(this.label1);
            this.Netto.Controls.Add(this.NettoCheckbox);
            this.Netto.Location = new System.Drawing.Point(154, 88);
            this.Netto.Name = "Netto";
            this.Netto.Size = new System.Drawing.Size(63, 18);
            this.Netto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Netto";
            // 
            // NettoCheckbox
            // 
            this.NettoCheckbox.BackColor = System.Drawing.Color.LimeGreen;
            this.NettoCheckbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NettoCheckbox.Location = new System.Drawing.Point(7, 1);
            this.NettoCheckbox.Name = "NettoCheckbox";
            this.NettoCheckbox.Size = new System.Drawing.Size(15, 15);
            this.NettoCheckbox.TabIndex = 1;
            // 
            // Jednostka
            // 
            this.Jednostka.BackColor = System.Drawing.Color.LimeGreen;
            this.Jednostka.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Jednostka.Location = new System.Drawing.Point(231, 19);
            this.Jednostka.Margin = new System.Windows.Forms.Padding(0);
            this.Jednostka.Name = "Jednostka";
            this.Jednostka.Size = new System.Drawing.Size(61, 90);
            this.Jednostka.TabIndex = 9;
            this.Jednostka.Text = "kg";
            this.Jednostka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Masa
            // 
            this.Masa.BackColor = System.Drawing.Color.LimeGreen;
            this.Masa.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Masa.Location = new System.Drawing.Point(12, 19);
            this.Masa.Margin = new System.Windows.Forms.Padding(0);
            this.Masa.Name = "Masa";
            this.Masa.Size = new System.Drawing.Size(232, 90);
            this.Masa.TabIndex = 0;
            this.Masa.Text = "15000";
            this.Masa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.label8);
            this.Footer.Controls.Add(this.label7);
            this.Footer.Controls.Add(this.label6);
            this.Footer.Controls.Add(this.pictureBox2);
            this.Footer.Controls.Add(this.pictureBox1);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 237);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(304, 94);
            this.Footer.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(11, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tel: 510 710 502 / 508 466 409";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(11, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wagmatik s.c. wagmatik.pl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(155, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "ProgramWaga TARA v 1.0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(156, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UstawieniaKomunikacji
            // 
            this.UstawieniaKomunikacji.Controls.Add(this.panel2);
            this.UstawieniaKomunikacji.Controls.Add(this.panel1);
            this.UstawieniaKomunikacji.Controls.Add(this.label5);
            this.UstawieniaKomunikacji.Controls.Add(this.label4);
            this.UstawieniaKomunikacji.Controls.Add(this.COMPortsComboBox);
            this.UstawieniaKomunikacji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UstawieniaKomunikacji.Location = new System.Drawing.Point(0, 199);
            this.UstawieniaKomunikacji.Name = "UstawieniaKomunikacji";
            this.UstawieniaKomunikacji.Size = new System.Drawing.Size(304, 38);
            this.UstawieniaKomunikacji.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 1);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port COM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ustawienia transmisji";
            // 
            // COMPortsComboBox
            // 
            this.COMPortsComboBox.FormattingEnabled = true;
            this.COMPortsComboBox.Location = new System.Drawing.Point(225, 9);
            this.COMPortsComboBox.Name = "COMPortsComboBox";
            this.COMPortsComboBox.Size = new System.Drawing.Size(67, 21);
            this.COMPortsComboBox.TabIndex = 20;
            this.COMPortsComboBox.SelectedIndexChanged += new System.EventHandler(this.COMPortsComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Stabilne";
            // 
            // stabilne
            // 
            this.stabilne.BackColor = System.Drawing.Color.Salmon;
            this.stabilne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stabilne.Location = new System.Drawing.Point(161, 116);
            this.stabilne.Name = "stabilne";
            this.stabilne.Size = new System.Drawing.Size(15, 15);
            this.stabilne.TabIndex = 2;
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Salmon;
            this.zero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zero.Location = new System.Drawing.Point(230, 116);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(15, 15);
            this.zero.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Zero";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 331);
            this.Controls.Add(this.UstawieniaKomunikacji);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(320, 370);
            this.MinimumSize = new System.Drawing.Size(320, 370);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgramWaga TARA";
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.Brutto.ResumeLayout(false);
            this.Brutto.PerformLayout();
            this.Netto.ResumeLayout(false);
            this.Netto.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UstawieniaKomunikacji.ResumeLayout(false);
            this.UstawieniaKomunikacji.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.Panel Brutto;
        private System.Windows.Forms.Label BruttoLabel;
        private System.Windows.Forms.Panel BruttoCheckbox;
        private System.Windows.Forms.Panel Netto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NettoCheckbox;
        private System.Windows.Forms.Label Masa;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox taraTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UsunTareButton;
        private System.Windows.Forms.Button TarujButton;
        private System.Windows.Forms.Panel UstawieniaKomunikacji;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox COMPortsComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Jednostka;
        private System.Windows.Forms.Panel stabilne;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel zero;
        private System.Windows.Forms.Label label11;
    }
}

