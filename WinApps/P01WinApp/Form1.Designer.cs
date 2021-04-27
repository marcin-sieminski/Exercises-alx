
namespace P01WinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUruchom = new System.Windows.Forms.Button();
            this.txtWczytaj = new System.Windows.Forms.TextBox();
            this.txtWyswietl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUruchom
            // 
            this.btnUruchom.Location = new System.Drawing.Point(12, 12);
            this.btnUruchom.Name = "btnUruchom";
            this.btnUruchom.Size = new System.Drawing.Size(89, 68);
            this.btnUruchom.TabIndex = 0;
            this.btnUruchom.Text = "Start";
            this.btnUruchom.UseVisualStyleBackColor = true;
            this.btnUruchom.Click += new System.EventHandler(this.btnUruchom_Click);
            // 
            // txtWczytaj
            // 
            this.txtWczytaj.Location = new System.Drawing.Point(133, 12);
            this.txtWczytaj.Name = "txtWczytaj";
            this.txtWczytaj.Size = new System.Drawing.Size(100, 23);
            this.txtWczytaj.TabIndex = 1;
            // 
            // txtWyswietl
            // 
            this.txtWyswietl.Location = new System.Drawing.Point(133, 57);
            this.txtWyswietl.Name = "txtWyswietl";
            this.txtWyswietl.Size = new System.Drawing.Size(100, 23);
            this.txtWyswietl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 98);
            this.Controls.Add(this.txtWyswietl);
            this.Controls.Add(this.txtWczytaj);
            this.Controls.Add(this.btnUruchom);
            this.Name = "Form1";
            this.Text = "WinApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUruchom;
        private System.Windows.Forms.TextBox txtWczytaj;
        private System.Windows.Forms.TextBox txtWyswietl;
    }
}

