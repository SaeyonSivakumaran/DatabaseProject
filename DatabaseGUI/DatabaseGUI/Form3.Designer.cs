namespace DatabaseGUI
{
    partial class Form3
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
            this.filterTitleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.provinceFilterOptions = new System.Windows.Forms.ComboBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filterTitleLabel
            // 
            this.filterTitleLabel.AutoSize = true;
            this.filterTitleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTitleLabel.Location = new System.Drawing.Point(157, 29);
            this.filterTitleLabel.Name = "filterTitleLabel";
            this.filterTitleLabel.Size = new System.Drawing.Size(271, 56);
            this.filterTitleLabel.TabIndex = 39;
            this.filterTitleLabel.Text = "Filter Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 39);
            this.label6.TabIndex = 40;
            this.label6.Text = "Filter By Location:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // provinceFilterOptions
            // 
            this.provinceFilterOptions.BackColor = System.Drawing.SystemColors.Window;
            this.provinceFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceFilterOptions.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceFilterOptions.FormattingEnabled = true;
            this.provinceFilterOptions.Items.AddRange(new object[] {
            "AB - Alberta",
            "BC - British Colombia",
            "MB - Manitoba",
            "NB - New Brunswick",
            "NL - Newfoundland and Labrador",
            "NS - Nova Scotia",
            "ON - Ontario",
            "PE - Prince Edward Island",
            "QC - Quebec",
            "SK - Saskatchewan",
            "NT - Northwest Territories",
            "NU - Nunavut",
            "YT - Yukon "});
            this.provinceFilterOptions.Location = new System.Drawing.Point(19, 162);
            this.provinceFilterOptions.Name = "provinceFilterOptions";
            this.provinceFilterOptions.Size = new System.Drawing.Size(339, 43);
            this.provinceFilterOptions.TabIndex = 41;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(103, 398);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(350, 66);
            this.filterButton.TabIndex = 42;
            this.filterButton.Text = "SUBMIT FILTER";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(570, 498);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.provinceFilterOptions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterTitleLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filterTitleLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox provinceFilterOptions;
        private System.Windows.Forms.Button filterButton;
    }
}