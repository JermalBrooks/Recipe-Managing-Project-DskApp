namespace Recipe_Managing_Project_DskApp
{
    partial class AddRecipe
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
            this.clbRestricted = new System.Windows.Forms.CheckedListBox();
            this.clbIntolerances = new System.Windows.Forms.CheckedListBox();
            this.rdrecipe = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rdInstruc = new System.Windows.Forms.Label();
            this.rdRestric = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbIngredients = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdbEasy = new System.Windows.Forms.RadioButton();
            this.rdbMedium = new System.Windows.Forms.RadioButton();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.gbComplex = new System.Windows.Forms.GroupBox();
            this.gbComplex.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbRestricted
            // 
            this.clbRestricted.FormattingEnabled = true;
            this.clbRestricted.Items.AddRange(new object[] {
            "Dairy",
            "Gluten",
            "Shellfish",
            "Tree Nuts",
            "Soy",
            "Eggs",
            "Peanuts",
            "Seafood",
            "Red Meat"});
            this.clbRestricted.Location = new System.Drawing.Point(186, 91);
            this.clbRestricted.Name = "clbRestricted";
            this.clbRestricted.Size = new System.Drawing.Size(120, 211);
            this.clbRestricted.TabIndex = 0;
            // 
            // clbIntolerances
            // 
            this.clbIntolerances.FormattingEnabled = true;
            this.clbIntolerances.Items.AddRange(new object[] {
            "Lactose",
            "Gluten",
            "Caffeine",
            "Casein",
            "Fructose",
            "MSG",
            "Eggs",
            "Soy",
            "Nuts",
            "Shellfish",
            "Peanuts",
            "Tree-nuts"});
            this.clbIntolerances.Location = new System.Drawing.Point(312, 91);
            this.clbIntolerances.Name = "clbIntolerances";
            this.clbIntolerances.Size = new System.Drawing.Size(120, 280);
            this.clbIntolerances.TabIndex = 1;
            // 
            // rdrecipe
            // 
            this.rdrecipe.AutoSize = true;
            this.rdrecipe.Location = new System.Drawing.Point(33, 30);
            this.rdrecipe.Name = "rdrecipe";
            this.rdrecipe.Size = new System.Drawing.Size(113, 20);
            this.rdrecipe.TabIndex = 2;
            this.rdrecipe.Text = "Recipe Name: ";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Location = new System.Drawing.Point(152, 31);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 19);
            this.tbName.TabIndex = 3;
            // 
            // rdInstruc
            // 
            this.rdInstruc.AutoSize = true;
            this.rdInstruc.Location = new System.Drawing.Point(523, 65);
            this.rdInstruc.Name = "rdInstruc";
            this.rdInstruc.Size = new System.Drawing.Size(92, 20);
            this.rdInstruc.TabIndex = 7;
            this.rdInstruc.Text = "Instructions";
            // 
            // rdRestric
            // 
            this.rdRestric.AutoSize = true;
            this.rdRestric.Location = new System.Drawing.Point(196, 65);
            this.rdRestric.Name = "rdRestric";
            this.rdRestric.Size = new System.Drawing.Size(93, 20);
            this.rdRestric.TabIndex = 8;
            this.rdRestric.Text = "Restrictions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intolerances";
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.Location = new System.Drawing.Point(438, 91);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(257, 183);
            this.rtbInstructions.TabIndex = 10;
            this.rtbInstructions.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingredients";
            // 
            // rtbIngredients
            // 
            this.rtbIngredients.Location = new System.Drawing.Point(13, 91);
            this.rtbIngredients.Name = "rtbIngredients";
            this.rtbIngredients.Size = new System.Drawing.Size(167, 211);
            this.rtbIngredients.TabIndex = 12;
            this.rtbIngredients.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Location = new System.Drawing.Point(12, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(294, 85);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "EX: Water, 1, Cup; Flour, 0.5, Cup;\nSeparate Name, Amount, and Unit with a comma." +
    "\nSeparate items with a Semicolon.";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(594, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 34);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(594, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdbEasy
            // 
            this.rdbEasy.AutoSize = true;
            this.rdbEasy.Location = new System.Drawing.Point(6, 25);
            this.rdbEasy.Name = "rdbEasy";
            this.rdbEasy.Size = new System.Drawing.Size(69, 24);
            this.rdbEasy.TabIndex = 17;
            this.rdbEasy.Text = "Easy";
            this.rdbEasy.UseVisualStyleBackColor = true;
            this.rdbEasy.CheckedChanged += new System.EventHandler(this.rdbEasy_CheckedChanged);
            // 
            // rdbMedium
            // 
            this.rdbMedium.AutoSize = true;
            this.rdbMedium.Location = new System.Drawing.Point(6, 52);
            this.rdbMedium.Name = "rdbMedium";
            this.rdbMedium.Size = new System.Drawing.Size(90, 24);
            this.rdbMedium.TabIndex = 18;
            this.rdbMedium.Text = "Medium";
            this.rdbMedium.UseVisualStyleBackColor = true;
            this.rdbMedium.CheckedChanged += new System.EventHandler(this.rdbMedium_CheckedChanged);
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Location = new System.Drawing.Point(6, 78);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(69, 24);
            this.rdbHard.TabIndex = 19;
            this.rdbHard.Text = "Hard";
            this.rdbHard.UseVisualStyleBackColor = true;
            this.rdbHard.CheckedChanged += new System.EventHandler(this.rdbHard_CheckedChanged);
            // 
            // gbComplex
            // 
            this.gbComplex.Controls.Add(this.rdbEasy);
            this.gbComplex.Controls.Add(this.rdbHard);
            this.gbComplex.Controls.Add(this.rdbMedium);
            this.gbComplex.Location = new System.Drawing.Point(438, 280);
            this.gbComplex.Name = "gbComplex";
            this.gbComplex.Size = new System.Drawing.Size(135, 112);
            this.gbComplex.TabIndex = 20;
            this.gbComplex.TabStop = false;
            this.gbComplex.Text = "Complexity";
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 404);
            this.Controls.Add(this.gbComplex);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rtbIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdRestric);
            this.Controls.Add(this.rdInstruc);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.rdrecipe);
            this.Controls.Add(this.clbIntolerances);
            this.Controls.Add(this.clbRestricted);
            this.Name = "AddRecipe";
            this.Text = "Add Recipe";
            this.gbComplex.ResumeLayout(false);
            this.gbComplex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbRestricted;
        private System.Windows.Forms.CheckedListBox clbIntolerances;
        private System.Windows.Forms.Label rdrecipe;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label rdInstruc;
        private System.Windows.Forms.Label rdRestric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbIngredients;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbEasy;
        private System.Windows.Forms.RadioButton rdbMedium;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.GroupBox gbComplex;
    }
}