
namespace P08Players
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
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datDataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labImie = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabZawodnicy = new System.Windows.Forms.TabPage();
            this.tabTrenerzy = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateDataUrTrener = new System.Windows.Forms.DateTimePicker();
            this.tbNazwiskoTrener = new System.Windows.Forms.TextBox();
            this.tbImieTrener = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTrenerzy = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajTrener = new System.Windows.Forms.Button();
            this.btnWyczyscTrener = new System.Windows.Forms.Button();
            this.btnUsunTrener = new System.Windows.Forms.Button();
            this.btn_EdytujTrener = new System.Windows.Forms.Button();
            this.tabZawody = new System.Windows.Forms.TabPage();
            this.tabSkocznie = new System.Windows.Forms.TabPage();
            this.tabMiasta = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabZawodnicy.SuspendLayout();
            this.tabTrenerzy.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(6, 19);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 0;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(87, 19);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(168, 19);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(249, 19);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 3;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(330, 19);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(75, 23);
            this.btnWyczysc.TabIndex = 4;
            this.btnWyczysc.Text = "Wyczyść";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(6, 67);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(415, 134);
            this.lbDane.TabIndex = 5;
            this.lbDane.SelectedIndexChanged += new System.EventHandler(this.lbDane_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWczytaj);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.btnWyczysc);
            this.groupBox1.Controls.Add(this.btnUsun);
            this.groupBox1.Controls.Add(this.btnEdytuj);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datDataUrodzenia);
            this.groupBox2.Controls.Add(this.txtKraj);
            this.groupBox2.Controls.Add(this.txtWaga);
            this.groupBox2.Controls.Add(this.txtWzrost);
            this.groupBox2.Controls.Add(this.txtNazwisko);
            this.groupBox2.Controls.Add(this.txtImie);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labImie);
            this.groupBox2.Location = new System.Drawing.Point(6, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 243);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Szczegóły";
            // 
            // datDataUrodzenia
            // 
            this.datDataUrodzenia.Location = new System.Drawing.Point(135, 154);
            this.datDataUrodzenia.Name = "datDataUrodzenia";
            this.datDataUrodzenia.Size = new System.Drawing.Size(200, 20);
            this.datDataUrodzenia.TabIndex = 11;
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(135, 127);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(100, 20);
            this.txtKraj.TabIndex = 10;
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(135, 100);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(100, 20);
            this.txtWaga.TabIndex = 9;
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(135, 73);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(100, 20);
            this.txtWzrost.TabIndex = 8;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(135, 46);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 7;
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(135, 20);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wzrost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Waga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kraj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data urodzenia";
            // 
            // labImie
            // 
            this.labImie.AutoSize = true;
            this.labImie.Location = new System.Drawing.Point(7, 20);
            this.labImie.Name = "labImie";
            this.labImie.Size = new System.Drawing.Size(26, 13);
            this.labImie.TabIndex = 0;
            this.labImie.Text = "Imię";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabZawodnicy);
            this.tabControl1.Controls.Add(this.tabTrenerzy);
            this.tabControl1.Controls.Add(this.tabZawody);
            this.tabControl1.Controls.Add(this.tabSkocznie);
            this.tabControl1.Controls.Add(this.tabMiasta);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 497);
            this.tabControl1.TabIndex = 8;
            // 
            // tabZawodnicy
            // 
            this.tabZawodnicy.Controls.Add(this.groupBox1);
            this.tabZawodnicy.Controls.Add(this.groupBox2);
            this.tabZawodnicy.Controls.Add(this.lbDane);
            this.tabZawodnicy.Location = new System.Drawing.Point(4, 22);
            this.tabZawodnicy.Name = "tabZawodnicy";
            this.tabZawodnicy.Padding = new System.Windows.Forms.Padding(3);
            this.tabZawodnicy.Size = new System.Drawing.Size(438, 471);
            this.tabZawodnicy.TabIndex = 0;
            this.tabZawodnicy.Text = "Zawodnicy";
            this.tabZawodnicy.UseVisualStyleBackColor = true;
            // 
            // tabTrenerzy
            // 
            this.tabTrenerzy.Controls.Add(this.groupBox4);
            this.tabTrenerzy.Controls.Add(this.lbTrenerzy);
            this.tabTrenerzy.Controls.Add(this.groupBox3);
            this.tabTrenerzy.Location = new System.Drawing.Point(4, 22);
            this.tabTrenerzy.Name = "tabTrenerzy";
            this.tabTrenerzy.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrenerzy.Size = new System.Drawing.Size(438, 471);
            this.tabTrenerzy.TabIndex = 1;
            this.tabTrenerzy.Text = "Trenerzy";
            this.tabTrenerzy.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateDataUrTrener);
            this.groupBox4.Controls.Add(this.tbNazwiskoTrener);
            this.groupBox4.Controls.Add(this.tbImieTrener);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 207);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 243);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Szczegóły";
            // 
            // dateDataUrTrener
            // 
            this.dateDataUrTrener.Location = new System.Drawing.Point(135, 154);
            this.dateDataUrTrener.Name = "dateDataUrTrener";
            this.dateDataUrTrener.Size = new System.Drawing.Size(200, 20);
            this.dateDataUrTrener.TabIndex = 11;
            // 
            // tbNazwiskoTrener
            // 
            this.tbNazwiskoTrener.Location = new System.Drawing.Point(135, 46);
            this.tbNazwiskoTrener.Name = "tbNazwiskoTrener";
            this.tbNazwiskoTrener.Size = new System.Drawing.Size(100, 20);
            this.tbNazwiskoTrener.TabIndex = 7;
            // 
            // tbImieTrener
            // 
            this.tbImieTrener.Location = new System.Drawing.Point(135, 20);
            this.tbImieTrener.Name = "tbImieTrener";
            this.tbImieTrener.Size = new System.Drawing.Size(100, 20);
            this.tbImieTrener.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nazwisko";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Data urodzenia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Imię";
            // 
            // lbTrenerzy
            // 
            this.lbTrenerzy.FormattingEnabled = true;
            this.lbTrenerzy.Location = new System.Drawing.Point(6, 67);
            this.lbTrenerzy.Name = "lbTrenerzy";
            this.lbTrenerzy.Size = new System.Drawing.Size(415, 134);
            this.lbTrenerzy.TabIndex = 8;
            this.lbTrenerzy.SelectedIndexChanged += new System.EventHandler(this.lbTrenerzy_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnDodajTrener);
            this.groupBox3.Controls.Add(this.btnWyczyscTrener);
            this.groupBox3.Controls.Add(this.btnUsunTrener);
            this.groupBox3.Controls.Add(this.btn_EdytujTrener);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Wczytaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnWczytajTrenerzy_Click);
            // 
            // btnDodajTrener
            // 
            this.btnDodajTrener.Location = new System.Drawing.Point(87, 19);
            this.btnDodajTrener.Name = "btnDodajTrener";
            this.btnDodajTrener.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTrener.TabIndex = 1;
            this.btnDodajTrener.Text = "Dodaj";
            this.btnDodajTrener.UseVisualStyleBackColor = true;
            this.btnDodajTrener.Click += new System.EventHandler(this.btnDodajTrener_Click);
            // 
            // btnWyczyscTrener
            // 
            this.btnWyczyscTrener.Location = new System.Drawing.Point(330, 19);
            this.btnWyczyscTrener.Name = "btnWyczyscTrener";
            this.btnWyczyscTrener.Size = new System.Drawing.Size(75, 23);
            this.btnWyczyscTrener.TabIndex = 4;
            this.btnWyczyscTrener.Text = "Wyczyść";
            this.btnWyczyscTrener.UseVisualStyleBackColor = true;
            // 
            // btnUsunTrener
            // 
            this.btnUsunTrener.Location = new System.Drawing.Point(168, 19);
            this.btnUsunTrener.Name = "btnUsunTrener";
            this.btnUsunTrener.Size = new System.Drawing.Size(75, 23);
            this.btnUsunTrener.TabIndex = 2;
            this.btnUsunTrener.Text = "Usuń";
            this.btnUsunTrener.UseVisualStyleBackColor = true;
            this.btnUsunTrener.Click += new System.EventHandler(this.btnUsunTrener_Click);
            // 
            // btn_EdytujTrener
            // 
            this.btn_EdytujTrener.Location = new System.Drawing.Point(249, 19);
            this.btn_EdytujTrener.Name = "btn_EdytujTrener";
            this.btn_EdytujTrener.Size = new System.Drawing.Size(75, 23);
            this.btn_EdytujTrener.TabIndex = 3;
            this.btn_EdytujTrener.Text = "Edytuj";
            this.btn_EdytujTrener.UseVisualStyleBackColor = true;
            this.btn_EdytujTrener.Click += new System.EventHandler(this.btn_EdytujTrener_Click);
            // 
            // tabZawody
            // 
            this.tabZawody.Location = new System.Drawing.Point(4, 22);
            this.tabZawody.Name = "tabZawody";
            this.tabZawody.Size = new System.Drawing.Size(438, 471);
            this.tabZawody.TabIndex = 2;
            this.tabZawody.Text = "Zawody";
            this.tabZawody.UseVisualStyleBackColor = true;
            // 
            // tabSkocznie
            // 
            this.tabSkocznie.Location = new System.Drawing.Point(4, 22);
            this.tabSkocznie.Name = "tabSkocznie";
            this.tabSkocznie.Size = new System.Drawing.Size(438, 471);
            this.tabSkocznie.TabIndex = 3;
            this.tabSkocznie.Text = "Skocznie";
            this.tabSkocznie.UseVisualStyleBackColor = true;
            // 
            // tabMiasta
            // 
            this.tabMiasta.Location = new System.Drawing.Point(4, 22);
            this.tabMiasta.Name = "tabMiasta";
            this.tabMiasta.Size = new System.Drawing.Size(438, 471);
            this.tabMiasta.TabIndex = 4;
            this.tabMiasta.Text = "Miasta";
            this.tabMiasta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Manager Zawodników";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabZawodnicy.ResumeLayout(false);
            this.tabTrenerzy.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labImie;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.DateTimePicker datDataUrodzenia;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabZawodnicy;
        private System.Windows.Forms.TabPage tabTrenerzy;
        private System.Windows.Forms.TabPage tabZawody;
        private System.Windows.Forms.TabPage tabSkocznie;
        private System.Windows.Forms.TabPage tabMiasta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateDataUrTrener;
        private System.Windows.Forms.TextBox tbNazwiskoTrener;
        private System.Windows.Forms.TextBox tbImieTrener;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbTrenerzy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDodajTrener;
        private System.Windows.Forms.Button btnWyczyscTrener;
        private System.Windows.Forms.Button btnUsunTrener;
        private System.Windows.Forms.Button btn_EdytujTrener;
    }
}

