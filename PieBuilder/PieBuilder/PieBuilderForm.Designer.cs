
namespace PieBuilder
{
    partial class PieBuilderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateButton = new System.Windows.Forms.Button();
            this.crustComboBox = new System.Windows.Forms.ComboBox();
            this.fillingComboBox = new System.Windows.Forms.ComboBox();
            this.fillingLabel = new System.Windows.Forms.Label();
            this.crustLabel = new System.Windows.Forms.Label();
            this.recipeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(95, 238);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(94, 29);
            this.generateButton.TabIndex = 0;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // crustComboBox
            // 
            this.crustComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crustComboBox.FormattingEnabled = true;
            this.crustComboBox.Items.AddRange(new object[] {
            "Plain",
            "Peppercorn",
            "Potato"});
            this.crustComboBox.Location = new System.Drawing.Point(70, 46);
            this.crustComboBox.Name = "crustComboBox";
            this.crustComboBox.Size = new System.Drawing.Size(119, 28);
            this.crustComboBox.TabIndex = 1;
            // 
            // fillingComboBox
            // 
            this.fillingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillingComboBox.FormattingEnabled = true;
            this.fillingComboBox.Items.AddRange(new object[] {
            "Beef",
            "Chicken",
            "Steak and Kidney"});
            this.fillingComboBox.Location = new System.Drawing.Point(70, 12);
            this.fillingComboBox.Name = "fillingComboBox";
            this.fillingComboBox.Size = new System.Drawing.Size(119, 28);
            this.fillingComboBox.TabIndex = 2;
            // 
            // fillingLabel
            // 
            this.fillingLabel.AutoSize = true;
            this.fillingLabel.Location = new System.Drawing.Point(12, 15);
            this.fillingLabel.Name = "fillingLabel";
            this.fillingLabel.Size = new System.Drawing.Size(52, 20);
            this.fillingLabel.TabIndex = 3;
            this.fillingLabel.Text = "Filling:";
            // 
            // crustLabel
            // 
            this.crustLabel.AutoSize = true;
            this.crustLabel.Location = new System.Drawing.Point(12, 49);
            this.crustLabel.Name = "crustLabel";
            this.crustLabel.Size = new System.Drawing.Size(45, 20);
            this.crustLabel.TabIndex = 4;
            this.crustLabel.Text = "Crust:";
            // 
            // recipeTextBox
            // 
            this.recipeTextBox.Location = new System.Drawing.Point(196, 12);
            this.recipeTextBox.Multiline = true;
            this.recipeTextBox.Name = "recipeTextBox";
            this.recipeTextBox.ReadOnly = true;
            this.recipeTextBox.Size = new System.Drawing.Size(269, 255);
            this.recipeTextBox.TabIndex = 5;
            // 
            // PieBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 279);
            this.Controls.Add(this.recipeTextBox);
            this.Controls.Add(this.crustLabel);
            this.Controls.Add(this.fillingLabel);
            this.Controls.Add(this.fillingComboBox);
            this.Controls.Add(this.crustComboBox);
            this.Controls.Add(this.generateButton);
            this.MaximizeBox = false;
            this.Name = "PieBuilderForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pie Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ComboBox crustComboBox;
        private System.Windows.Forms.ComboBox fillingComboBox;
        private System.Windows.Forms.Label fillingLabel;
        private System.Windows.Forms.Label crustLabel;
        private System.Windows.Forms.TextBox recipeTextBox;
    }
}

