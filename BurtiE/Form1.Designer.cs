namespace BurtiE
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
            this.labelVards = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVards
            // 
            this.labelVards.AutoSize = true;
            this.labelVards.Location = new System.Drawing.Point(12, 74);
            this.labelVards.Name = "labelVards";
            this.labelVards.Size = new System.Drawing.Size(34, 13);
            this.labelVards.TabIndex = 0;
            this.labelVards.Text = "Vārds";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(111, 22);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(75, 13);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.Text = "Ievadiet vardu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Location = new System.Drawing.Point(20, 121);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(132, 13);
            this.labelInfo2.TabIndex = 4;
            this.labelInfo2.Text = "Burtu \"e\" daudzums vārdā";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(177, 176);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(101, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Sākt no jauna";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(177, 100);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(75, 23);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "Skaitīt";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.ButtonResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 211);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelVards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVards;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonResult;
    }
}

