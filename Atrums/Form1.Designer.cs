namespace Atrums
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
            this.textBoxMeters = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.textBoxSpeedms = new System.Windows.Forms.TextBox();
            this.textBoxSpeedhmh = new System.Windows.Forms.TextBox();
            this.textBoxDistancekm = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelMetri = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelSpeedms = new System.Windows.Forms.Label();
            this.labelSpeedkmh = new System.Windows.Forms.Label();
            this.labelDistancemk = new System.Windows.Forms.Label();
            this.labelDistanceMiles = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMeters
            // 
            this.textBoxMeters.Location = new System.Drawing.Point(89, 61);
            this.textBoxMeters.Name = "textBoxMeters";
            this.textBoxMeters.Size = new System.Drawing.Size(100, 20);
            this.textBoxMeters.TabIndex = 0;
            this.textBoxMeters.TextChanged += new System.EventHandler(this.TextBoxMeters_TextChanged);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(89, 110);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinutes.TabIndex = 1;
            this.textBoxMinutes.TextChanged += new System.EventHandler(this.TextBoxMinutes_TextChanged);
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(404, 61);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.ReadOnly = true;
            this.textBoxSeconds.Size = new System.Drawing.Size(100, 20);
            this.textBoxSeconds.TabIndex = 2;
            this.textBoxSeconds.TextChanged += new System.EventHandler(this.TextBoxSeconds_TextChanged);
            // 
            // textBoxSpeedms
            // 
            this.textBoxSpeedms.Location = new System.Drawing.Point(404, 87);
            this.textBoxSpeedms.Name = "textBoxSpeedms";
            this.textBoxSpeedms.ReadOnly = true;
            this.textBoxSpeedms.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeedms.TabIndex = 3;
            // 
            // textBoxSpeedhmh
            // 
            this.textBoxSpeedhmh.Location = new System.Drawing.Point(404, 113);
            this.textBoxSpeedhmh.Name = "textBoxSpeedhmh";
            this.textBoxSpeedhmh.ReadOnly = true;
            this.textBoxSpeedhmh.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeedhmh.TabIndex = 4;
            // 
            // textBoxDistancekm
            // 
            this.textBoxDistancekm.Location = new System.Drawing.Point(404, 142);
            this.textBoxDistancekm.Name = "textBoxDistancekm";
            this.textBoxDistancekm.ReadOnly = true;
            this.textBoxDistancekm.Size = new System.Drawing.Size(100, 20);
            this.textBoxDistancekm.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(404, 174);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(89, 155);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Rēķināt";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(89, 194);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Sākt no jauna";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelMetri
            // 
            this.labelMetri.AutoSize = true;
            this.labelMetri.Location = new System.Drawing.Point(44, 64);
            this.labelMetri.Name = "labelMetri";
            this.labelMetri.Size = new System.Drawing.Size(30, 13);
            this.labelMetri.TabIndex = 9;
            this.labelMetri.Text = "Metri";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(44, 110);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(44, 13);
            this.labelMinutes.TabIndex = 10;
            this.labelMinutes.Text = "Minutes";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(259, 61);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(127, 13);
            this.labelSeconds.TabIndex = 11;
            this.labelSeconds.Text = "Pateretais laiks sekundēs";
            // 
            // labelSpeedms
            // 
            this.labelSpeedms.AutoSize = true;
            this.labelSpeedms.Location = new System.Drawing.Point(259, 87);
            this.labelSpeedms.Name = "labelSpeedms";
            this.labelSpeedms.Size = new System.Drawing.Size(66, 13);
            this.labelSpeedms.TabIndex = 12;
            this.labelSpeedms.Text = "Ātrums (m/s)";
            // 
            // labelSpeedkmh
            // 
            this.labelSpeedkmh.AutoSize = true;
            this.labelSpeedkmh.Location = new System.Drawing.Point(259, 116);
            this.labelSpeedkmh.Name = "labelSpeedkmh";
            this.labelSpeedkmh.Size = new System.Drawing.Size(73, 13);
            this.labelSpeedkmh.TabIndex = 13;
            this.labelSpeedkmh.Text = "Ātrums (mk/h)";
            // 
            // labelDistancemk
            // 
            this.labelDistancemk.AutoSize = true;
            this.labelDistancemk.Location = new System.Drawing.Point(259, 142);
            this.labelDistancemk.Name = "labelDistancemk";
            this.labelDistancemk.Size = new System.Drawing.Size(97, 13);
            this.labelDistancemk.TabIndex = 14;
            this.labelDistancemk.Text = "Attālums kilometros";
            // 
            // labelDistanceMiles
            // 
            this.labelDistanceMiles.AutoSize = true;
            this.labelDistanceMiles.Location = new System.Drawing.Point(259, 174);
            this.labelDistanceMiles.Name = "labelDistanceMiles";
            this.labelDistanceMiles.Size = new System.Drawing.Size(80, 13);
            this.labelDistanceMiles.TabIndex = 15;
            this.labelDistanceMiles.Text = "Attālums jūdzēs";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(44, 23);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(232, 13);
            this.labelInfo.TabIndex = 16;
            this.labelInfo.Text = "Ievadiet attālumu (m) un paterēto laiku (minutes)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 247);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelDistanceMiles);
            this.Controls.Add(this.labelDistancemk);
            this.Controls.Add(this.labelSpeedkmh);
            this.Controls.Add(this.labelSpeedms);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelMetri);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBoxDistancekm);
            this.Controls.Add(this.textBoxSpeedhmh);
            this.Controls.Add(this.textBoxSpeedms);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxMeters);
            this.Name = "Form1";
            this.Text = "Atrums";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMeters;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.TextBox textBoxSpeedms;
        private System.Windows.Forms.TextBox textBoxSpeedhmh;
        private System.Windows.Forms.TextBox textBoxDistancekm;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelMetri;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelSpeedms;
        private System.Windows.Forms.Label labelSpeedkmh;
        private System.Windows.Forms.Label labelDistancemk;
        private System.Windows.Forms.Label labelDistanceMiles;
        private System.Windows.Forms.Label labelInfo;
    }
}

