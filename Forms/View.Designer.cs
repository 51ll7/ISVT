
namespace ISVT.Forms
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.generalDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.computersDataGridView = new System.Windows.Forms.DataGridView();
            this.componentsDataGridView = new System.Windows.Forms.DataGridView();
            this.computersToComponentsDataGridView = new System.Windows.Forms.DataGridView();
            this.computersComponentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalToComputersDataGridView = new System.Windows.Forms.DataGridView();
            this.generalComputersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.descriptionDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ISVT.DataSet1();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalTableAdapter = new ISVT.DataSet1TableAdapters.GeneralTableAdapter();
            this.computersTableAdapter = new ISVT.DataSet1TableAdapters.ComputersTableAdapter();
            this.componentsTableAdapter = new ISVT.DataSet1TableAdapters.ComponentsTableAdapter();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersToComponentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersComponentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalToComputersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalComputersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // generalDataGridView
            // 
            this.generalDataGridView.AllowUserToAddRows = false;
            this.generalDataGridView.AllowUserToDeleteRows = false;
            this.generalDataGridView.AllowUserToResizeRows = false;
            this.generalDataGridView.AutoGenerateColumns = false;
            this.generalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.generalDataGridView.DataSource = this.generalBindingSource;
            this.generalDataGridView.Location = new System.Drawing.Point(0, 30);
            this.generalDataGridView.Name = "generalDataGridView";
            this.generalDataGridView.ReadOnly = true;
            this.generalDataGridView.RowHeadersWidth = 25;
            this.generalDataGridView.Size = new System.Drawing.Size(217, 150);
            this.generalDataGridView.TabIndex = 0;
            this.generalDataGridView.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Помещения",
            "Помещения + Вычислительная техника",
            "Вычислительная техника",
            "Вычислительная техника + Компоненты",
            "Компоненты"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(250, 23);
            this.toolStripComboBox1.Text = "Сортировка";
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // computersDataGridView
            // 
            this.computersDataGridView.AllowUserToAddRows = false;
            this.computersDataGridView.AllowUserToDeleteRows = false;
            this.computersDataGridView.AllowUserToResizeRows = false;
            this.computersDataGridView.AutoGenerateColumns = false;
            this.computersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.computersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.receivingDateDataGridViewTextBoxColumn});
            this.computersDataGridView.DataSource = this.computersBindingSource;
            this.computersDataGridView.Location = new System.Drawing.Point(0, 50);
            this.computersDataGridView.Name = "computersDataGridView";
            this.computersDataGridView.ReadOnly = true;
            this.computersDataGridView.RowHeadersWidth = 25;
            this.computersDataGridView.Size = new System.Drawing.Size(240, 150);
            this.computersDataGridView.TabIndex = 2;
            this.computersDataGridView.Visible = false;
            // 
            // componentsDataGridView
            // 
            this.componentsDataGridView.AllowUserToAddRows = false;
            this.componentsDataGridView.AllowUserToDeleteRows = false;
            this.componentsDataGridView.AllowUserToResizeRows = false;
            this.componentsDataGridView.AutoGenerateColumns = false;
            this.componentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.componentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.componentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.componentsDataGridView.DataSource = this.componentsBindingSource;
            this.componentsDataGridView.Location = new System.Drawing.Point(0, 70);
            this.componentsDataGridView.Name = "componentsDataGridView";
            this.componentsDataGridView.ReadOnly = true;
            this.componentsDataGridView.RowHeadersWidth = 25;
            this.componentsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.componentsDataGridView.TabIndex = 3;
            this.componentsDataGridView.Visible = false;
            // 
            // computersToComponentsDataGridView
            // 
            this.computersToComponentsDataGridView.AllowUserToAddRows = false;
            this.computersToComponentsDataGridView.AllowUserToDeleteRows = false;
            this.computersToComponentsDataGridView.AllowUserToResizeRows = false;
            this.computersToComponentsDataGridView.AutoGenerateColumns = false;
            this.computersToComponentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.computersToComponentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computersToComponentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersToComponentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn2,
            this.priceDataGridViewTextBoxColumn2});
            this.computersToComponentsDataGridView.DataSource = this.computersComponentsBindingSource;
            this.computersToComponentsDataGridView.Location = new System.Drawing.Point(458, 30);
            this.computersToComponentsDataGridView.Name = "computersToComponentsDataGridView";
            this.computersToComponentsDataGridView.ReadOnly = true;
            this.computersToComponentsDataGridView.RowHeadersWidth = 25;
            this.computersToComponentsDataGridView.Size = new System.Drawing.Size(230, 150);
            this.computersToComponentsDataGridView.TabIndex = 4;
            this.computersToComponentsDataGridView.Visible = false;
            // 
            // computersComponentsBindingSource
            // 
            this.computersComponentsBindingSource.DataMember = "Computers_Components";
            this.computersComponentsBindingSource.DataSource = this.computersBindingSource;
            // 
            // generalToComputersDataGridView
            // 
            this.generalToComputersDataGridView.AllowUserToAddRows = false;
            this.generalToComputersDataGridView.AllowUserToDeleteRows = false;
            this.generalToComputersDataGridView.AllowUserToResizeRows = false;
            this.generalToComputersDataGridView.AutoGenerateColumns = false;
            this.generalToComputersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.generalToComputersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.generalToComputersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalToComputersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn3,
            this.priceDataGridViewTextBoxColumn3,
            this.receivingDateDataGridViewTextBoxColumn1});
            this.generalToComputersDataGridView.DataSource = this.generalComputersBindingSource;
            this.generalToComputersDataGridView.Location = new System.Drawing.Point(458, 50);
            this.generalToComputersDataGridView.Name = "generalToComputersDataGridView";
            this.generalToComputersDataGridView.ReadOnly = true;
            this.generalToComputersDataGridView.RowHeadersWidth = 25;
            this.generalToComputersDataGridView.Size = new System.Drawing.Size(240, 150);
            this.generalToComputersDataGridView.TabIndex = 5;
            this.generalToComputersDataGridView.Visible = false;
            // 
            // generalComputersBindingSource
            // 
            this.generalComputersBindingSource.DataMember = "General_Computers";
            this.generalComputersBindingSource.DataSource = this.generalBindingSource;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // descriptionDataGridViewTextBoxColumn3
            // 
            this.descriptionDataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn3.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn3.Name = "descriptionDataGridViewTextBoxColumn3";
            this.descriptionDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn3
            // 
            this.priceDataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn3.FillWeight = 75F;
            this.priceDataGridViewTextBoxColumn3.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn3.Name = "priceDataGridViewTextBoxColumn3";
            this.priceDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // receivingDateDataGridViewTextBoxColumn1
            // 
            this.receivingDateDataGridViewTextBoxColumn1.DataPropertyName = "ReceivingDate";
            this.receivingDateDataGridViewTextBoxColumn1.FillWeight = 50F;
            this.receivingDateDataGridViewTextBoxColumn1.HeaderText = "ReceivingDate";
            this.receivingDateDataGridViewTextBoxColumn1.Name = "receivingDateDataGridViewTextBoxColumn1";
            this.receivingDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // generalBindingSource
            // 
            this.generalBindingSource.DataMember = "General";
            this.generalBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computersBindingSource
            // 
            this.computersBindingSource.DataMember = "Computers";
            this.computersBindingSource.DataSource = this.dataSet1;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "Components";
            this.componentsBindingSource.DataSource = this.dataSet1;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 75F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receivingDateDataGridViewTextBoxColumn
            // 
            this.receivingDateDataGridViewTextBoxColumn.DataPropertyName = "ReceivingDate";
            this.receivingDateDataGridViewTextBoxColumn.FillWeight = 50F;
            this.receivingDateDataGridViewTextBoxColumn.HeaderText = "ReceivingDate";
            this.receivingDateDataGridViewTextBoxColumn.Name = "receivingDateDataGridViewTextBoxColumn";
            this.receivingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 50F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // generalTableAdapter
            // 
            this.generalTableAdapter.ClearBeforeFill = true;
            // 
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // componentsTableAdapter
            // 
            this.componentsTableAdapter.ClearBeforeFill = true;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn2.FillWeight = 50F;
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 311);
            this.Controls.Add(this.generalToComputersDataGridView);
            this.Controls.Add(this.computersToComponentsDataGridView);
            this.Controls.Add(this.componentsDataGridView);
            this.Controls.Add(this.computersDataGridView);
            this.Controls.Add(this.generalDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersToComponentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersComponentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalToComputersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalComputersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView generalDataGridView;
        private DataSet1 dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingSource generalBindingSource;
        private DataSet1TableAdapters.GeneralTableAdapter generalTableAdapter;
        private System.Windows.Forms.DataGridView computersDataGridView;
        private System.Windows.Forms.BindingSource computersBindingSource;
        private DataSet1TableAdapters.ComputersTableAdapter computersTableAdapter;
        private System.Windows.Forms.DataGridView componentsDataGridView;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private DataSet1TableAdapters.ComponentsTableAdapter componentsTableAdapter;
        private System.Windows.Forms.DataGridView computersToComponentsDataGridView;
        private System.Windows.Forms.BindingSource computersComponentsBindingSource;
        private System.Windows.Forms.DataGridView generalToComputersDataGridView;
        private System.Windows.Forms.BindingSource generalComputersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivingDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
    }
}