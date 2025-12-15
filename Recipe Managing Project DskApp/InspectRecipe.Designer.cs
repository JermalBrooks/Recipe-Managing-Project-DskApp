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
            this.lstIntolerances = new System.Windows.Forms.ListView();
            this.lstRestrictions = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdRecipeName = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListView();
            this.rdComplex = new System.Windows.Forms.Label();
            this.nComplexity = new System.Windows.Forms.Label();
            this.recipeName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingredients ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restrictions ";
            // 
            // lstIntolerances
            // 
            this.lstIntolerances.HideSelection = false;
            this.lstIntolerances.Location = new System.Drawing.Point(191, 262);
            this.lstIntolerances.Name = "lstIntolerances";
            this.lstIntolerances.Size = new System.Drawing.Size(121, 138);
            this.lstIntolerances.TabIndex = 2;
            this.lstIntolerances.UseCompatibleStateImageBehavior = false;
            this.lstIntolerances.View = System.Windows.Forms.View.List;
            // 
            // lstRestrictions
            // 
            this.lstRestrictions.HideSelection = false;
            this.lstRestrictions.Location = new System.Drawing.Point(191, 97);
            this.lstRestrictions.Name = "lstRestrictions";
            this.lstRestrictions.Size = new System.Drawing.Size(121, 124);
            this.lstRestrictions.TabIndex = 3;
            this.lstRestrictions.UseCompatibleStateImageBehavior = false;
            this.lstRestrictions.View = System.Windows.Forms.View.List;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Intolerances";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Instructions";
            // 
            // rdRecipeName
            // 
            this.rdRecipeName.AutoSize = true;
            this.rdRecipeName.Location = new System.Drawing.Point(58, 26);
            this.rdRecipeName.Name = "rdRecipeName";
            this.rdRecipeName.Size = new System.Drawing.Size(63, 20);
            this.rdRecipeName.TabIndex = 6;
            this.rdRecipeName.Text = "Recipe:";
            // 
            // lstIngredients
            // 
            this.lstIngredients.HideSelection = false;
            this.lstIngredients.Location = new System.Drawing.Point(2, 97);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(171, 303);
            this.lstIngredients.TabIndex = 8;
            this.lstIngredients.UseCompatibleStateImageBehavior = false;
            this.lstIngredients.View = System.Windows.Forms.View.Tile;
            // 
            // rdComplex
            // 
            this.rdComplex.AutoSize = true;
            this.rdComplex.Location = new System.Drawing.Point(40, 46);
            this.rdComplex.Name = "rdComplex";
            this.rdComplex.Size = new System.Drawing.Size(93, 20);
            this.rdComplex.TabIndex = 9;
            this.rdComplex.Text = "Complexity: ";
            // 
            // nComplexity
            // 
            this.nComplexity.AutoSize = true;
            this.nComplexity.Location = new System.Drawing.Point(127, 46);
            this.nComplexity.Name = "nComplexity";
            this.nComplexity.Size = new System.Drawing.Size(73, 20);
            this.nComplexity.TabIndex = 10;
            this.nComplexity.Text = "unknown";
            // 
            // recipeName
            // 
            this.recipeName.AutoSize = true;
            this.recipeName.Location = new System.Drawing.Point(127, 26);
            this.recipeName.Name = "recipeName";
            this.recipeName.Size = new System.Drawing.Size(73, 20);
            this.recipeName.TabIndex = 11;
            this.recipeName.Text = "unknown";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(498, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Location = new System.Drawing.Point(328, 97);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(245, 303);
            this.rtbInstructions.TabIndex = 13;
            this.rtbInstructions.Text = "";
            // 
            // InspectRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.recipeName);
            this.Controls.Add(this.nComplexity);
            this.Controls.Add(this.rdComplex);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.rdRecipeName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstRestrictions);
            this.Controls.Add(this.lstIntolerances);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InspectRecipe";
            this.Text = "View Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstIntolerances;
        private System.Windows.Forms.ListView lstRestrictions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rdRecipeName;
        private System.Windows.Forms.ListView lstIngredients;
        private System.Windows.Forms.Label rdComplex;
        private System.Windows.Forms.Label nComplexity;
        private System.Windows.Forms.Label recipeName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox rtbInstructions;
    }
}