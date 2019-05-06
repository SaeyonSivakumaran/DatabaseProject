namespace DatabaseGUI
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
            this.components = new System.ComponentModel.Container();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            this.provinceOptions = new System.Windows.Forms.ComboBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.schoolBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoTableView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDatabaseDataSet = new DatabaseGUI.PeopleDatabaseDataSet();
            this.infoTableTableAdapter = new DatabaseGUI.PeopleDatabaseDataSetTableAdapters.InfoTableTableAdapter();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(57, 452);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(468, 66);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "SUBMIT INFORMATION";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(216, 166);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(339, 42);
            this.nameBox.TabIndex = 34;
            // 
            // ageBox
            // 
            this.ageBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageBox.Location = new System.Drawing.Point(216, 220);
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(120, 42);
            this.ageBox.TabIndex = 32;
            // 
            // provinceOptions
            // 
            this.provinceOptions.BackColor = System.Drawing.SystemColors.Window;
            this.provinceOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceOptions.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provinceOptions.FormattingEnabled = true;
            this.provinceOptions.Items.AddRange(new object[] {
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
            this.provinceOptions.Location = new System.Drawing.Point(216, 321);
            this.provinceOptions.Name = "provinceOptions";
            this.provinceOptions.Size = new System.Drawing.Size(339, 43);
            this.provinceOptions.TabIndex = 31;
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleRadio.Location = new System.Drawing.Point(358, 275);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(122, 39);
            this.femaleRadio.TabIndex = 30;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleRadio.Location = new System.Drawing.Point(216, 275);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(97, 39);
            this.maleRadio.TabIndex = 29;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // schoolBox
            // 
            this.schoolBox.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolBox.Location = new System.Drawing.Point(216, 375);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(339, 42);
            this.schoolBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 54);
            this.label7.TabIndex = 27;
            this.label7.Text = "School: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 54);
            this.label6.TabIndex = 26;
            this.label6.Text = "Province:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 54);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sex: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 54);
            this.label4.TabIndex = 24;
            this.label4.Text = "Age:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 54);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // infoTableView
            // 
            this.infoTableView.AutoGenerateColumns = false;
            this.infoTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn});
            this.infoTableView.DataSource = this.infoTableBindingSource;
            this.infoTableView.Location = new System.Drawing.Point(583, 22);
            this.infoTableView.Name = "infoTableView";
            this.infoTableView.ReadOnly = true;
            this.infoTableView.RowTemplate.Height = 28;
            this.infoTableView.Size = new System.Drawing.Size(614, 535);
            this.infoTableView.TabIndex = 36;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "school";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "school";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoTableBindingSource
            // 
            this.infoTableBindingSource.DataMember = "InfoTable";
            this.infoTableBindingSource.DataSource = this.peopleDatabaseDataSet;
            // 
            // peopleDatabaseDataSet
            // 
            this.peopleDatabaseDataSet.DataSetName = "PeopleDatabaseDataSet";
            this.peopleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableTableAdapter
            // 
            this.infoTableTableAdapter.ClearBeforeFill = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(17, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(538, 56);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Database Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1209, 569);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.infoTableView);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.provinceOptions);
            this.Controls.Add(this.femaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.schoolBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Database Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.NumericUpDown ageBox;
        private System.Windows.Forms.ComboBox provinceOptions;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.TextBox schoolBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView infoTableView;
        private PeopleDatabaseDataSet peopleDatabaseDataSet;
        private System.Windows.Forms.BindingSource infoTableBindingSource;
        private PeopleDatabaseDataSetTableAdapters.InfoTableTableAdapter infoTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label titleLabel;
    }
}

