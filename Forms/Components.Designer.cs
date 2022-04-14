namespace ISVT
{
    partial class ComponentsT
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
            System.Windows.Forms.Label iDComputersLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentsT));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorAddButton = new System.Windows.Forms.ToolStripButton();
            this.NavigatorDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.NavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.dataSet1 = new ISVT.DataSet1();
            this.generalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generalTableAdapter = new ISVT.DataSet1TableAdapters.GeneralTableAdapter();
            this.tableAdapterManager = new ISVT.DataSet1TableAdapters.TableAdapterManager();
            this.componentsTableAdapter = new ISVT.DataSet1TableAdapters.ComponentsTableAdapter();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDComputersTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            iDComputersLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDComputersLabel
            // 
            iDComputersLabel.AutoSize = true;
            iDComputersLabel.Location = new System.Drawing.Point(461, 31);
            iDComputersLabel.Name = "iDComputersLabel";
            iDComputersLabel.Size = new System.Drawing.Size(71, 13);
            iDComputersLabel.TabIndex = 11;
            iDComputersLabel.Text = "IDComputers:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(461, 57);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(461, 83);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 15;
            priceLabel.Text = "Price:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.NavigatorAddButton,
            this.NavigatorDeleteButton,
            this.NavigatorSaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(650, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NavigatorAddButton
            // 
            this.NavigatorAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorAddButton.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorAddButton.Image")));
            this.NavigatorAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavigatorAddButton.Name = "NavigatorAddButton";
            this.NavigatorAddButton.Size = new System.Drawing.Size(23, 22);
            this.NavigatorAddButton.Text = "Добавить";
            // 
            // NavigatorDeleteButton
            // 
            this.NavigatorDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorDeleteButton.Image")));
            this.NavigatorDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavigatorDeleteButton.Name = "NavigatorDeleteButton";
            this.NavigatorDeleteButton.Size = new System.Drawing.Size(23, 22);
            this.NavigatorDeleteButton.Text = "toolStripButton2";
            this.NavigatorDeleteButton.ToolTipText = "Удалить";
            // 
            // NavigatorSaveButton
            // 
            this.NavigatorSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NavigatorSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("NavigatorSaveButton.Image")));
            this.NavigatorSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NavigatorSaveButton.Name = "NavigatorSaveButton";
            this.NavigatorSaveButton.Size = new System.Drawing.Size(23, 22);
            this.NavigatorSaveButton.Text = "toolStripButton3";
            this.NavigatorSaveButton.ToolTipText = "Сохранить";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generalBindingSource
            // 
            this.generalBindingSource.DataMember = "General";
            this.generalBindingSource.DataSource = this.dataSet1;
            // 
            // generalTableAdapter
            // 
            this.generalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComponentsTableAdapter = this.componentsTableAdapter;
            this.tableAdapterManager.ComputersTableAdapter = null;
            this.tableAdapterManager.GeneralTableAdapter = this.generalTableAdapter;
            this.tableAdapterManager.UpdateOrder = ISVT.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // componentsTableAdapter
            // 
            this.componentsTableAdapter.ClearBeforeFill = true;
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "Components";
            this.componentsBindingSource.DataSource = this.dataSet1;
            // 
            // componentsDataGridView
            // 
            this.componentsDataGridView.AllowUserToAddRows = false;
            this.componentsDataGridView.AllowUserToDeleteRows = false;
            this.componentsDataGridView.AllowUserToResizeRows = false;
            this.componentsDataGridView.AutoGenerateColumns = false;
            this.componentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.componentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.componentsDataGridView.DataSource = this.componentsBindingSource;
            this.componentsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.componentsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.componentsDataGridView.Name = "componentsDataGridView";
            this.componentsDataGridView.Size = new System.Drawing.Size(443, 220);
            this.componentsDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDComputers";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDComputers";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iDComputersTextBox
            // 
            this.iDComputersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componentsBindingSource, "IDComputers", true));
            this.iDComputersTextBox.Location = new System.Drawing.Point(538, 28);
            this.iDComputersTextBox.Name = "iDComputersTextBox";
            this.iDComputersTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDComputersTextBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componentsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(538, 54);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.componentsBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(538, 80);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 16;
            // 
            // ComponentsT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(iDComputersLabel);
            this.Controls.Add(this.iDComputersTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.componentsDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ComponentsT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компоненты";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NavigatorAddButton;
        private System.Windows.Forms.ToolStripButton NavigatorDeleteButton;
        private System.Windows.Forms.ToolStripButton NavigatorSaveButton;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource generalBindingSource;
        private DataSet1TableAdapters.GeneralTableAdapter generalTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.ComponentsTableAdapter componentsTableAdapter;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private System.Windows.Forms.DataGridView componentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iDComputersTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}