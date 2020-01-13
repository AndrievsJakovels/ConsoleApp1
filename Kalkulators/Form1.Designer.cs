namespace Kalkulators
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMius = new System.Windows.Forms.Button();
            this.buttonMultiplay = new System.Windows.Forms.Button();
            this.buttonAvg = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pirmais skaitlis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Otrais skaitlis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezultats";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(104, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(27, 121);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 6;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // buttonMius
            // 
            this.buttonMius.Location = new System.Drawing.Point(118, 121);
            this.buttonMius.Name = "buttonMius";
            this.buttonMius.Size = new System.Drawing.Size(75, 23);
            this.buttonMius.TabIndex = 7;
            this.buttonMius.Text = "-";
            this.buttonMius.UseVisualStyleBackColor = true;
            this.buttonMius.Click += new System.EventHandler(this.ButtonMius_Click);
            // 
            // buttonMultiplay
            // 
            this.buttonMultiplay.Location = new System.Drawing.Point(27, 150);
            this.buttonMultiplay.Name = "buttonMultiplay";
            this.buttonMultiplay.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplay.TabIndex = 8;
            this.buttonMultiplay.Text = "*";
            this.buttonMultiplay.UseVisualStyleBackColor = true;
            this.buttonMultiplay.Click += new System.EventHandler(this.ButtonMultiplay_Click);
            // 
            // buttonAvg
            // 
            this.buttonAvg.Location = new System.Drawing.Point(118, 150);
            this.buttonAvg.Name = "buttonAvg";
            this.buttonAvg.Size = new System.Drawing.Size(75, 23);
            this.buttonAvg.TabIndex = 9;
            this.buttonAvg.Text = "AVG";
            this.buttonAvg.UseVisualStyleBackColor = true;
            this.buttonAvg.Click += new System.EventHandler(this.ButtonAvg_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(27, 179);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 23);
            this.buttonMin.TabIndex = 10;
            this.buttonMin.Text = "MIN";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.ButtonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(118, 179);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 23);
            this.buttonMax.TabIndex = 11;
            this.buttonMax.Text = "MAX";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.ButtonMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 221);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonAvg);
            this.Controls.Add(this.buttonMultiplay);
            this.Controls.Add(this.buttonMius);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMius;
        private System.Windows.Forms.Button buttonMultiplay;
        private System.Windows.Forms.Button buttonAvg;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
    }
}

