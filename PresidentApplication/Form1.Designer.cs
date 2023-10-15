namespace PresidentApplication
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
            this.NaturalBornCitizenCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BirthYearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RebelledCheckBox = new System.Windows.Forms.CheckBox();
            this.CheckEligibiity = new System.Windows.Forms.Button();
            this.PriorTermsNumeric = new System.Windows.Forms.NumericUpDown();
            this.ResidentYearsNumeric = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PriorTermsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentYearsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NaturalBornCitizenCheckBox
            // 
            this.NaturalBornCitizenCheckBox.AutoSize = true;
            this.NaturalBornCitizenCheckBox.Location = new System.Drawing.Point(40, 38);
            this.NaturalBornCitizenCheckBox.Name = "NaturalBornCitizenCheckBox";
            this.NaturalBornCitizenCheckBox.Size = new System.Drawing.Size(169, 24);
            this.NaturalBornCitizenCheckBox.TabIndex = 0;
            this.NaturalBornCitizenCheckBox.Text = "Natural Born Citizen";
            this.NaturalBornCitizenCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your birth year";
            // 
            // BirthYearDateTimePicker
            // 
            this.BirthYearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthYearDateTimePicker.Location = new System.Drawing.Point(365, 83);
            this.BirthYearDateTimePicker.Name = "BirthYearDateTimePicker";
            this.BirthYearDateTimePicker.Size = new System.Drawing.Size(129, 26);
            this.BirthYearDateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many years have you lived in the US?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "How many proir terms have you served?";
            // 
            // RebelledCheckBox
            // 
            this.RebelledCheckBox.AutoSize = true;
            this.RebelledCheckBox.Location = new System.Drawing.Point(40, 274);
            this.RebelledCheckBox.Name = "RebelledCheckBox";
            this.RebelledCheckBox.Size = new System.Drawing.Size(241, 24);
            this.RebelledCheckBox.TabIndex = 7;
            this.RebelledCheckBox.Text = "I have rebelled against the US";
            this.RebelledCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckEligibiity
            // 
            this.CheckEligibiity.Location = new System.Drawing.Point(226, 347);
            this.CheckEligibiity.Name = "CheckEligibiity";
            this.CheckEligibiity.Size = new System.Drawing.Size(135, 42);
            this.CheckEligibiity.TabIndex = 8;
            this.CheckEligibiity.Text = "Check Eligibiity";
            this.CheckEligibiity.UseVisualStyleBackColor = true;
            this.CheckEligibiity.Click += new System.EventHandler(this.CheckEligibiity_Click);
            // 
            // PriorTermsNumeric
            // 
            this.PriorTermsNumeric.Location = new System.Drawing.Point(389, 194);
            this.PriorTermsNumeric.Name = "PriorTermsNumeric";
            this.PriorTermsNumeric.Size = new System.Drawing.Size(104, 26);
            this.PriorTermsNumeric.TabIndex = 9;
            // 
            // ResidentYearsNumeric
            // 
            this.ResidentYearsNumeric.Location = new System.Drawing.Point(389, 130);
            this.ResidentYearsNumeric.Name = "ResidentYearsNumeric";
            this.ResidentYearsNumeric.Size = new System.Drawing.Size(104, 26);
            this.ResidentYearsNumeric.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 506);
            this.Controls.Add(this.ResidentYearsNumeric);
            this.Controls.Add(this.PriorTermsNumeric);
            this.Controls.Add(this.CheckEligibiity);
            this.Controls.Add(this.RebelledCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BirthYearDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NaturalBornCitizenCheckBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PresidentApplication";
            ((System.ComponentModel.ISupportInitialize)(this.PriorTermsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidentYearsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NaturalBornCitizenCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthYearDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox RebelledCheckBox;
        private System.Windows.Forms.Button CheckEligibiity;
        private System.Windows.Forms.NumericUpDown PriorTermsNumeric;
        private System.Windows.Forms.NumericUpDown ResidentYearsNumeric;
    }
}

