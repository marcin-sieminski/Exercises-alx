
namespace P04PlayersManager
{
    partial class FrmPlayers
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lsbPlayers = new System.Windows.Forms.ListBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtKraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWzrostOd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWzrostDo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWagaOd = new System.Windows.Forms.TextBox();
            this.txtWagaDo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datDataUrOd = new System.Windows.Forms.DateTimePicker();
            this.datDataUrDo = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDataOd = new System.Windows.Forms.CheckBox();
            this.checkBoxDataDo = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImieNew = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtWagaNew = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtWzrostNew = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtKrajNew = new System.Windows.Forms.TextBox();
            this.txtNazwiskoNew = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(21, 13);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(285, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lsbPlayers
            // 
            this.lsbPlayers.FormattingEnabled = true;
            this.lsbPlayers.Location = new System.Drawing.Point(312, 52);
            this.lsbPlayers.Name = "lsbPlayers";
            this.lsbPlayers.Size = new System.Drawing.Size(171, 290);
            this.lsbPlayers.TabIndex = 2;
            this.lsbPlayers.SelectedIndexChanged += new System.EventHandler(this.lsbPlayers_SelectedIndexChanged);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(84, 64);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 3;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(84, 95);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 4;
            // 
            // txtKraj
            // 
            this.txtKraj.Location = new System.Drawing.Point(84, 126);
            this.txtKraj.Name = "txtKraj";
            this.txtKraj.Size = new System.Drawing.Size(100, 20);
            this.txtKraj.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kraj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Wzrost od";
            // 
            // txtWzrostOd
            // 
            this.txtWzrostOd.Location = new System.Drawing.Point(84, 157);
            this.txtWzrostOd.Name = "txtWzrostOd";
            this.txtWzrostOd.Size = new System.Drawing.Size(100, 20);
            this.txtWzrostOd.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wzrost do";
            // 
            // txtWzrostDo
            // 
            this.txtWzrostDo.Location = new System.Drawing.Point(84, 188);
            this.txtWzrostDo.Name = "txtWzrostDo";
            this.txtWzrostDo.Size = new System.Drawing.Size(100, 20);
            this.txtWzrostDo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Waga od";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Waga do";
            // 
            // txtWagaOd
            // 
            this.txtWagaOd.Location = new System.Drawing.Point(84, 219);
            this.txtWagaOd.Name = "txtWagaOd";
            this.txtWagaOd.Size = new System.Drawing.Size(100, 20);
            this.txtWagaOd.TabIndex = 15;
            // 
            // txtWagaDo
            // 
            this.txtWagaDo.Location = new System.Drawing.Point(84, 250);
            this.txtWagaDo.Name = "txtWagaDo";
            this.txtWagaDo.Size = new System.Drawing.Size(100, 20);
            this.txtWagaDo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data ur. od";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data ur. do";
            // 
            // datDataUrOd
            // 
            this.datDataUrOd.Location = new System.Drawing.Point(84, 281);
            this.datDataUrOd.Name = "datDataUrOd";
            this.datDataUrOd.Size = new System.Drawing.Size(200, 20);
            this.datDataUrOd.TabIndex = 19;
            // 
            // datDataUrDo
            // 
            this.datDataUrDo.Location = new System.Drawing.Point(84, 312);
            this.datDataUrDo.Name = "datDataUrDo";
            this.datDataUrDo.Size = new System.Drawing.Size(200, 20);
            this.datDataUrDo.TabIndex = 20;
            // 
            // checkBoxDataOd
            // 
            this.checkBoxDataOd.AutoSize = true;
            this.checkBoxDataOd.Location = new System.Drawing.Point(291, 287);
            this.checkBoxDataOd.Name = "checkBoxDataOd";
            this.checkBoxDataOd.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDataOd.TabIndex = 21;
            this.checkBoxDataOd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDataDo
            // 
            this.checkBoxDataDo.AutoSize = true;
            this.checkBoxDataDo.Location = new System.Drawing.Point(291, 318);
            this.checkBoxDataDo.Name = "checkBoxDataDo";
            this.checkBoxDataDo.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDataDo.TabIndex = 22;
            this.checkBoxDataDo.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(499, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(579, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(491, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Imię";
            // 
            // txtImieNew
            // 
            this.txtImieNew.Location = new System.Drawing.Point(558, 52);
            this.txtImieNew.Name = "txtImieNew";
            this.txtImieNew.Size = new System.Drawing.Size(100, 20);
            this.txtImieNew.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(558, 207);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Data ur.";
            // 
            // txtWagaNew
            // 
            this.txtWagaNew.Location = new System.Drawing.Point(558, 176);
            this.txtWagaNew.Name = "txtWagaNew";
            this.txtWagaNew.Size = new System.Drawing.Size(100, 20);
            this.txtWagaNew.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(491, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Waga";
            // 
            // txtWzrostNew
            // 
            this.txtWzrostNew.Location = new System.Drawing.Point(558, 143);
            this.txtWzrostNew.Name = "txtWzrostNew";
            this.txtWzrostNew.Size = new System.Drawing.Size(100, 20);
            this.txtWzrostNew.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(491, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Wzrost";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(491, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Kraj";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(491, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Nazwisko";
            // 
            // txtKrajNew
            // 
            this.txtKrajNew.Location = new System.Drawing.Point(558, 112);
            this.txtKrajNew.Name = "txtKrajNew";
            this.txtKrajNew.Size = new System.Drawing.Size(100, 20);
            this.txtKrajNew.TabIndex = 29;
            // 
            // txtNazwiskoNew
            // 
            this.txtNazwiskoNew.Location = new System.Drawing.Point(558, 81);
            this.txtNazwiskoNew.Name = "txtNazwiskoNew";
            this.txtNazwiskoNew.Size = new System.Drawing.Size(100, 20);
            this.txtNazwiskoNew.TabIndex = 28;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(313, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(170, 23);
            this.btnNew.TabIndex = 44;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 354);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtWagaNew);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtWzrostNew);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtKrajNew);
            this.Controls.Add(this.txtNazwiskoNew);
            this.Controls.Add(this.txtImieNew);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.checkBoxDataDo);
            this.Controls.Add(this.checkBoxDataOd);
            this.Controls.Add(this.datDataUrDo);
            this.Controls.Add(this.datDataUrOd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtWagaDo);
            this.Controls.Add(this.txtWagaOd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWzrostDo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWzrostOd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKraj);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.lsbPlayers);
            this.Controls.Add(this.btnRead);
            this.Name = "FrmPlayers";
            this.Text = "Players Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lsbPlayers;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtKraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWzrostOd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWzrostDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWagaOd;
        private System.Windows.Forms.TextBox txtWagaDo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datDataUrOd;
        private System.Windows.Forms.DateTimePicker datDataUrDo;
        private System.Windows.Forms.CheckBox checkBoxDataOd;
        private System.Windows.Forms.CheckBox checkBoxDataDo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImieNew;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtWagaNew;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtWzrostNew;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtKrajNew;
        private System.Windows.Forms.TextBox txtNazwiskoNew;
        private System.Windows.Forms.Button btnNew;
    }
}

