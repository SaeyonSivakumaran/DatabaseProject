namespace DatabaseGUI
{
    partial class Form2
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
            this.mainInfoTableView = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.peopleDatabaseDataSet = new DatabaseGUI.PeopleDatabaseDataSet();
            this.infoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableTableAdapter = new DatabaseGUI.PeopleDatabaseDataSetTableAdapters.InfoTableTableAdapter();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.peopleDatabaseDataSet1 = new DatabaseGUI.PeopleDatabaseDataSet1();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoTableDataSet = new DatabaseGUI.InfoTableDataSet();
            this.infoTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableTableAdapter1 = new DatabaseGUI.InfoTableDataSetTableAdapters.InfoTableTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDatabaseDataSet2 = new DatabaseGUI.PeopleDatabaseDataSet2();
            this.infoTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.infoTableTableAdapter2 = new DatabaseGUI.PeopleDatabaseDataSet2TableAdapters.InfoTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainInfoTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // mainInfoTableView
            // 
            this.mainInfoTableView.AutoGenerateColumns = false;
            this.mainInfoTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainInfoTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.id});
            this.mainInfoTableView.DataSource = this.infoTableBindingSource3;
            this.mainInfoTableView.Location = new System.Drawing.Point(12, 74);
            this.mainInfoTableView.Name = "mainInfoTableView";
            this.mainInfoTableView.ReadOnly = true;
            this.mainInfoTableView.RowTemplate.Height = 28;
            this.mainInfoTableView.Size = new System.Drawing.Size(704, 526);
            this.mainInfoTableView.TabIndex = 37;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(238, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(538, 56);
            this.titleLabel.TabIndex = 39;
            this.titleLabel.Text = "Database Application";
            // 
            // peopleDatabaseDataSet
            // 
            this.peopleDatabaseDataSet.DataSetName = "PeopleDatabaseDataSet";
            this.peopleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableBindingSource
            // 
            this.infoTableBindingSource.DataMember = "InfoTable";
            this.infoTableBindingSource.DataSource = this.peopleDatabaseDataSet;
            // 
            // infoTableTableAdapter
            // 
            this.infoTableTableAdapter.ClearBeforeFill = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(736, 74);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(248, 86);
            this.addButton.TabIndex = 40;
            this.addButton.Text = "Add Entry";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(736, 166);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(248, 223);
            this.removeButton.TabIndex = 41;
            this.removeButton.Text = "Remove Selected Entry";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(736, 514);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(248, 86);
            this.refreshButton.TabIndex = 42;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoTableBindingSource1
            // 
            this.infoTableBindingSource1.DataMember = "InfoTable";
            this.infoTableBindingSource1.DataSource = this.peopleDatabaseDataSet;
            // 
            // peopleDatabaseDataSet1
            // 
            this.peopleDatabaseDataSet1.DataSetName = "PeopleDatabaseDataSet1";
            this.peopleDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "school";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "school";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // infoTableDataSet
            // 
            this.infoTableDataSet.DataSetName = "InfoTableDataSet";
            this.infoTableDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableBindingSource2
            // 
            this.infoTableBindingSource2.DataMember = "InfoTable";
            this.infoTableBindingSource2.DataSource = this.infoTableDataSet;
            // 
            // infoTableTableAdapter1
            // 
            this.infoTableTableAdapter1.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // peopleDatabaseDataSet2
            // 
            this.peopleDatabaseDataSet2.DataSetName = "PeopleDatabaseDataSet2";
            this.peopleDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // infoTableBindingSource3
            // 
            this.infoTableBindingSource3.DataMember = "InfoTable";
            this.infoTableBindingSource3.DataSource = this.peopleDatabaseDataSet2;
            // 
            // infoTableTableAdapter2
            // 
            this.infoTableTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(736, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 113);
            this.button1.TabIndex = 43;
            this.button1.Text = "Filter Table";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(996, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.mainInfoTableView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainInfoTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainInfoTableView;
        private System.Windows.Forms.Label titleLabel;
        private PeopleDatabaseDataSet peopleDatabaseDataSet;
        private System.Windows.Forms.BindingSource infoTableBindingSource;
        private PeopleDatabaseDataSetTableAdapters.InfoTableTableAdapter infoTableTableAdapter;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource infoTableBindingSource1;
        private PeopleDatabaseDataSet1 peopleDatabaseDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private InfoTableDataSet infoTableDataSet;
        private System.Windows.Forms.BindingSource infoTableBindingSource2;
        private InfoTableDataSetTableAdapters.InfoTableTableAdapter infoTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private PeopleDatabaseDataSet2 peopleDatabaseDataSet2;
        private System.Windows.Forms.BindingSource infoTableBindingSource3;
        private PeopleDatabaseDataSet2TableAdapters.InfoTableTableAdapter infoTableTableAdapter2;
        private System.Windows.Forms.Button button1;
    }
}