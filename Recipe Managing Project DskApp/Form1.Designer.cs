namespace Recipe_Managing_Project_DskApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seafood = new System.Windows.Forms.ListBox();
            this.meat = new System.Windows.Forms.ListBox();
            this.veggies = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(575, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intolerances";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(575, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Food Allergies";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(692, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Search";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Substitution and Health Section";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.veggies);
            this.groupBox3.Controls.Add(this.meat);
            this.groupBox3.Controls.Add(this.seafood);
            this.groupBox3.Location = new System.Drawing.Point(346, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(206, 298);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Food Restrictions";
            // 
            // seafood
            // 
            this.seafood.FormattingEnabled = true;
            this.seafood.ItemHeight = 20;
            this.seafood.Location = new System.Drawing.Point(0, 26);
            this.seafood.Name = "seafood";
            this.seafood.Size = new System.Drawing.Size(120, 64);
            this.seafood.TabIndex = 0;
            // 
            // meat
            // 
            this.meat.FormattingEnabled = true;
            this.meat.ItemHeight = 20;
            this.meat.Location = new System.Drawing.Point(0, 120);
            this.meat.Name = "meat";
            this.meat.Size = new System.Drawing.Size(120, 64);
            this.meat.TabIndex = 1;
            // 
            // veggies
            // 
            this.veggies.FormattingEnabled = true;
            this.veggies.ItemHeight = 20;
            this.veggies.Location = new System.Drawing.Point(0, 208);
            this.veggies.Name = "veggies";
            this.veggies.Size = new System.Drawing.Size(120, 64);
            this.veggies.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recipes Displayed Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calhoun CookBook";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox seafood;
        private System.Windows.Forms.ListBox veggies;
        private System.Windows.Forms.ListBox meat;
        private System.Windows.Forms.Label label2;
    }
}

