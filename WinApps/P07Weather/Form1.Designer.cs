
namespace P07Weather
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.labNames = new System.Windows.Forms.Label();
            this.lbPlaces = new System.Windows.Forms.ListBox();
            this.labWeather = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labWeatherInfo = new System.Windows.Forms.Label();
            this.pbWeatherPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(168, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labNames
            // 
            this.labNames.AutoSize = true;
            this.labNames.Location = new System.Drawing.Point(13, 43);
            this.labNames.Name = "labNames";
            this.labNames.Size = new System.Drawing.Size(42, 13);
            this.labNames.TabIndex = 1;
            this.labNames.Text = "Places:";
            // 
            // lbPlaces
            // 
            this.lbPlaces.FormattingEnabled = true;
            this.lbPlaces.Location = new System.Drawing.Point(16, 60);
            this.lbPlaces.Name = "lbPlaces";
            this.lbPlaces.Size = new System.Drawing.Size(165, 95);
            this.lbPlaces.TabIndex = 2;
            this.lbPlaces.SelectedIndexChanged += new System.EventHandler(this.lbPlaces_SelectedIndexChanged);
            // 
            // labWeather
            // 
            this.labWeather.AutoSize = true;
            this.labWeather.Location = new System.Drawing.Point(16, 181);
            this.labWeather.Name = "labWeather";
            this.labWeather.Size = new System.Drawing.Size(62, 13);
            this.labWeather.TabIndex = 3;
            this.labWeather.Text = "Weather in ";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(74, 181);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(0, 13);
            this.labName.TabIndex = 4;
            // 
            // labWeatherInfo
            // 
            this.labWeatherInfo.AutoSize = true;
            this.labWeatherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWeatherInfo.Location = new System.Drawing.Point(55, 209);
            this.labWeatherInfo.Name = "labWeatherInfo";
            this.labWeatherInfo.Size = new System.Drawing.Size(0, 26);
            this.labWeatherInfo.TabIndex = 5;
            this.labWeatherInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbWeatherPicture
            // 
            this.pbWeatherPicture.Location = new System.Drawing.Point(19, 296);
            this.pbWeatherPicture.Name = "pbWeatherPicture";
            this.pbWeatherPicture.Size = new System.Drawing.Size(162, 89);
            this.pbWeatherPicture.TabIndex = 6;
            this.pbWeatherPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 450);
            this.Controls.Add(this.pbWeatherPicture);
            this.Controls.Add(this.labWeatherInfo);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labWeather);
            this.Controls.Add(this.lbPlaces);
            this.Controls.Add(this.labNames);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Weather";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeatherPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label labNames;
        private System.Windows.Forms.ListBox lbPlaces;
        private System.Windows.Forms.Label labWeather;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labWeatherInfo;
        private System.Windows.Forms.PictureBox pbWeatherPicture;
    }
}

