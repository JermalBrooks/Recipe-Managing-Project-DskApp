namespace Recipe_Managing_Project_DskApp
{
    partial class InspectRecipe
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdRecipeName = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.rdComplex = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recipeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredients ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restrictions ";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(191, 275);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 138);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(191, 110);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(121, 124);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intolerances";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instructions";
            // 
            // rdRecipeName
            // 
            this.rdRecipeName.AutoSize = true;
            this.rdRecipeName.Location = new System.Drawing.Point(40, 26);
            this.rdRecipeName.Name = "rdRecipeName";
            this.rdRecipeName.Size = new System.Drawing.Size(63, 20);
            this.rdRecipeName.TabIndex = 6;
            this.rdRecipeName.Text = "Recipe:";
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(360, 110);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(314, 303);
            this.listView3.TabIndex = 7;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(44, 110);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(121, 303);
            this.listView4.TabIndex = 8;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // rdComplex
            // 
            this.rdComplex.AutoSize = true;
            this.rdComplex.Location = new System.Drawing.Point(187, 26);
            this.rdComplex.Name = "rdComplex";
            this.rdComplex.Size = new System.Drawing.Size(93, 20);
            this.rdComplex.TabIndex = 9;
            this.rdComplex.Text = "Complexity: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "unknown";
            // 
            // recipeName
            // 
            this.recipeName.AutoSize = true;
            this.recipeName.Location = new System.Drawing.Point(109, 26);
            this.recipeName.Name = "recipeName";
            this.recipeName.Size = new System.Drawing.Size(73, 20);
            this.recipeName.TabIndex = 11;
            this.recipeName.Text = "unknown";
            // 
            // InspectRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.recipeName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdComplex);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.rdRecipeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InspectRecipe";
            this.Text = "InspectRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rdRecipeName;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Label rdComplex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recipeName;
    }
}