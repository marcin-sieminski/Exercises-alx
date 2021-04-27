
namespace P04DataBinding
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
            this.lbData = new System.Windows.Forms.ListBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(12, 41);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(120, 199);
            this.lbData.TabIndex = 0;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 12);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(120, 23);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 257);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Button btnRead;
    }
}

