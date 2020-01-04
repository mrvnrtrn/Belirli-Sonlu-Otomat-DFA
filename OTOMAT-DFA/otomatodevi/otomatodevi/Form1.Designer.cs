namespace otomatodevi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tsayi = new System.Windows.Forms.TextBox();
            this.combogiris = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listboxgirisler = new System.Windows.Forms.ListBox();
            this.listboxyollar = new System.Windows.Forms.ListBox();
            this.listboxcikis = new System.Windows.Forms.ListBox();
            this.tabloekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combo0 = new System.Windows.Forms.ComboBox();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tgiris = new System.Windows.Forms.TextBox();
            this.tyol = new System.Windows.Forms.TextBox();
            this.tcikis = new System.Windows.Forms.TextBox();
            this.stateekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btextekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanýlacak State Sayýsý :";
            // 
            // tsayi
            // 
            this.tsayi.Location = new System.Drawing.Point(235, 51);
            this.tsayi.Margin = new System.Windows.Forms.Padding(2);
            this.tsayi.Name = "tsayi";
            this.tsayi.Size = new System.Drawing.Size(72, 20);
            this.tsayi.TabIndex = 1;
            this.tsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // combogiris
            // 
            this.combogiris.FormattingEnabled = true;
            this.combogiris.Location = new System.Drawing.Point(254, 145);
            this.combogiris.Margin = new System.Windows.Forms.Padding(2);
            this.combogiris.Name = "combogiris";
            this.combogiris.Size = new System.Drawing.Size(53, 21);
            this.combogiris.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "State Seçiniz :";
            // 
            // listboxgirisler
            // 
            this.listboxgirisler.FormattingEnabled = true;
            this.listboxgirisler.Location = new System.Drawing.Point(322, 51);
            this.listboxgirisler.Margin = new System.Windows.Forms.Padding(2);
            this.listboxgirisler.Name = "listboxgirisler";
            this.listboxgirisler.Size = new System.Drawing.Size(75, 173);
            this.listboxgirisler.TabIndex = 4;
            this.listboxgirisler.SelectedIndexChanged += new System.EventHandler(this.listboxgirisler_SelectedIndexChanged);
            // 
            // listboxyollar
            // 
            this.listboxyollar.FormattingEnabled = true;
            this.listboxyollar.Location = new System.Drawing.Point(419, 51);
            this.listboxyollar.Margin = new System.Windows.Forms.Padding(2);
            this.listboxyollar.Name = "listboxyollar";
            this.listboxyollar.Size = new System.Drawing.Size(73, 173);
            this.listboxyollar.TabIndex = 5;
            this.listboxyollar.SelectedIndexChanged += new System.EventHandler(this.listboxyollar_SelectedIndexChanged);
            // 
            // listboxcikis
            // 
            this.listboxcikis.FormattingEnabled = true;
            this.listboxcikis.Location = new System.Drawing.Point(515, 51);
            this.listboxcikis.Margin = new System.Windows.Forms.Padding(2);
            this.listboxcikis.Name = "listboxcikis";
            this.listboxcikis.Size = new System.Drawing.Size(73, 173);
            this.listboxcikis.TabIndex = 6;
            this.listboxcikis.SelectedIndexChanged += new System.EventHandler(this.listboxcikis_SelectedIndexChanged);
            // 
            // tabloekle
            // 
            this.tabloekle.Location = new System.Drawing.Point(219, 271);
            this.tabloekle.Margin = new System.Windows.Forms.Padding(2);
            this.tabloekle.Name = "tabloekle";
            this.tabloekle.Size = new System.Drawing.Size(88, 35);
            this.tabloekle.TabIndex = 10;
            this.tabloekle.Text = "Tabloya Ekle";
            this.tabloekle.UseVisualStyleBackColor = true;
            this.tabloekle.Click += new System.EventHandler(this.tabloekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "0 yolu ile gidilen State :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "1 yolu ile gidilen State :";
            // 
            // combo0
            // 
            this.combo0.FormattingEnabled = true;
            this.combo0.Location = new System.Drawing.Point(254, 180);
            this.combo0.Margin = new System.Windows.Forms.Padding(2);
            this.combo0.Name = "combo0";
            this.combo0.Size = new System.Drawing.Size(53, 21);
            this.combo0.TabIndex = 13;
            // 
            // combo1
            // 
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(254, 223);
            this.combo1.Margin = new System.Windows.Forms.Padding(2);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(53, 21);
            this.combo1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 292);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "GÝRÝÞLER:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "YOLLAR:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 356);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ÇIKIÞLAR:";
            // 
            // tgiris
            // 
            this.tgiris.Location = new System.Drawing.Point(403, 289);
            this.tgiris.Margin = new System.Windows.Forms.Padding(2);
            this.tgiris.Name = "tgiris";
            this.tgiris.Size = new System.Drawing.Size(123, 20);
            this.tgiris.TabIndex = 18;
            // 
            // tyol
            // 
            this.tyol.Location = new System.Drawing.Point(403, 319);
            this.tyol.Margin = new System.Windows.Forms.Padding(2);
            this.tyol.Name = "tyol";
            this.tyol.Size = new System.Drawing.Size(123, 20);
            this.tyol.TabIndex = 19;
            // 
            // tcikis
            // 
            this.tcikis.Location = new System.Drawing.Point(403, 355);
            this.tcikis.Margin = new System.Windows.Forms.Padding(2);
            this.tcikis.Name = "tcikis";
            this.tcikis.Size = new System.Drawing.Size(123, 20);
            this.tcikis.TabIndex = 20;
            // 
            // stateekle
            // 
            this.stateekle.Location = new System.Drawing.Point(219, 95);
            this.stateekle.Margin = new System.Windows.Forms.Padding(2);
            this.stateekle.Name = "stateekle";
            this.stateekle.Size = new System.Drawing.Size(88, 33);
            this.stateekle.TabIndex = 21;
            this.stateekle.Text = "State Ekle";
            this.stateekle.UseVisualStyleBackColor = true;
            this.stateekle.Click += new System.EventHandler(this.stateekle_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "GÝRÝÞLER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "YOLLAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "ÇIKIÞLAR";
            // 
            // btextekle
            // 
            this.btextekle.Location = new System.Drawing.Point(404, 248);
            this.btextekle.Name = "btextekle";
            this.btextekle.Size = new System.Drawing.Size(88, 23);
            this.btextekle.TabIndex = 26;
            this.btextekle.Text = "Tablodan Ekle";
            this.btextekle.UseVisualStyleBackColor = true;
            this.btextekle.Click += new System.EventHandler(this.btextekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 65);
            this.button1.TabIndex = 27;
            this.button1.Text = "Yapýlan Ödev Açýklamasý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::otomatodevi.Properties.Resources.uni_logo__1_;
            this.button2.Location = new System.Drawing.Point(1, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 108);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(599, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btextekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stateekle);
            this.Controls.Add(this.tcikis);
            this.Controls.Add(this.tyol);
            this.Controls.Add(this.tgiris);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.combo0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabloekle);
            this.Controls.Add(this.listboxcikis);
            this.Controls.Add(this.listboxyollar);
            this.Controls.Add(this.listboxgirisler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combogiris);
            this.Controls.Add(this.tsayi);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Biçimsel Diller ve Otomatlar Ödevi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsayi;
        private System.Windows.Forms.ComboBox combogiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listboxgirisler;
        private System.Windows.Forms.ListBox listboxyollar;
        private System.Windows.Forms.ListBox listboxcikis;
        private System.Windows.Forms.Button tabloekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combo0;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tgiris;
        private System.Windows.Forms.TextBox tyol;
        private System.Windows.Forms.TextBox tcikis;
        private System.Windows.Forms.Button stateekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btextekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

