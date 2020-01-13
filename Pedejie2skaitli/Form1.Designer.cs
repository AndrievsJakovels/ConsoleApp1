namespace Pedejie2skaitli
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
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxNumerOneLAst2 = new System.Windows.Forms.TextBox();
            this.textBoxNumerTwoLAst2 = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelNumberOne = new System.Windows.Forms.Label();
            this.labelNumberTwo = new System.Windows.Forms.Label();
            this.labelNumberOneLast = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(77, 128);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 0;
            this.buttonCheck.Text = "Pārbaudīt";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBoxNumerOneLAst2
            // 
            this.textBoxNumerOneLAst2.Location = new System.Drawing.Point(302, 38);
            this.textBoxNumerOneLAst2.Name = "textBoxNumerOneLAst2";
            this.textBoxNumerOneLAst2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerOneLAst2.TabIndex = 3;
            // 
            // textBoxNumerTwoLAst2
            // 
            this.textBoxNumerTwoLAst2.Location = new System.Drawing.Point(302, 64);
            this.textBoxNumerTwoLAst2.Name = "textBoxNumerTwoLAst2";
            this.textBoxNumerTwoLAst2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerTwoLAst2.TabIndex = 4;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(207, 128);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(122, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Sākt no jauna";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // labelNumberOne
            // 
            this.labelNumberOne.AutoSize = true;
            this.labelNumberOne.Location = new System.Drawing.Point(12, 39);
            this.labelNumberOne.Name = "labelNumberOne";
            this.labelNumberOne.Size = new System.Drawing.Size(47, 13);
            this.labelNumberOne.TabIndex = 6;
            this.labelNumberOne.Text = "skaitlis 1";
            // 
            // labelNumberTwo
            // 
            this.labelNumberTwo.AutoSize = true;
            this.labelNumberTwo.Location = new System.Drawing.Point(12, 70);
            this.labelNumberTwo.Name = "labelNumberTwo";
            this.labelNumberTwo.Size = new System.Drawing.Size(47, 13);
            this.labelNumberTwo.TabIndex = 7;
            this.labelNumberTwo.Text = "skaitlis 2";
            // 
            // labelNumberOneLast
            // 
            this.labelNumberOneLast.AutoSize = true;
            this.labelNumberOneLast.Location = new System.Drawing.Point(176, 39);
            this.labelNumberOneLast.Name = "labelNumberOneLast";
            this.labelNumberOneLast.Size = new System.Drawing.Size(120, 13);
            this.labelNumberOneLast.TabIndex = 8;
            this.labelNumberOneLast.Text = "skaitļa 1 pedējie 2 cipari";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "skaitļa 2 pedējie 2 cipari";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(127, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(153, 13);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "Ievadiet divus veselus  skaitlus";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 201);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNumberOneLast);
            this.Controls.Add(this.labelNumberTwo);
            this.Controls.Add(this.labelNumberOne);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxNumerTwoLAst2);
            this.Controls.Add(this.textBoxNumerOneLAst2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxNumerOneLAst2;
        private System.Windows.Forms.TextBox textBoxNumerTwoLAst2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelNumberOne;
        private System.Windows.Forms.Label labelNumberTwo;
        private System.Windows.Forms.Label labelNumberOneLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInfo;
    }
}

