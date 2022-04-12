namespace ISVT
{
    partial class General
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
            System.Windows.Forms.Label roomLabel;
            System.Windows.Forms.Label quantityLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(General));
            this.generalDataGridView = new System.Windows.Forms.DataGridView();
            this.roomTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorAddButton = new System.Windows.Forms.ToolStripButton();
            this.NavigatorDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.NavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.generalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ISVT.DataSet1();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalTableAdapter = new ISVT.DataSet1TableAdapters.GeneralTableAdapter();
            this.tableAdapterManager = new ISVT.DataSet1TableAdapters.TableAdapterManager();
            roomLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generalDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(360, 31);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(38, 13);
            roomLabel.TabIndex = 4;
            roomLabel.Text = "Room:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(360, 57);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Quantity:";
            // 
            // generalDataGridView
            // 
            this.generalDataGridView.AllowUserToAddRows = false;
            this.generalDataGridView.AllowUserToDeleteRows = false;
            this.generalDataGridView.AllowUserToResizeRows = false;
            this.generalDataGridView.AutoGenerateColumns = false;
            this.generalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.generalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.generalDataGridView.DataSource = this.generalBindingSource;
            this.generalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.generalDataGridView.Location = new System.Drawing.Point(12, 28);
            this.generalDataGridView.Name = "generalDataGridView";
            this.generalDataGridView.Size = new System.Drawing.Size(343, 220);
            this.generalDataGridView.TabIndex = 1;
            this.generalDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.generalDataGridView_DataError);
            // 
            // roomTextBox
            // 
            this.roomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generalBindingSource, "Room", true));
            this.roomTextBox.Location = new System.Drawing.Point(415, 28);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.Size = new System.Drawing.Size(100, 20);
            this.roomTextBox.TabIndex = 5;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.generalBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(415, 54);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 7;
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
            this.toolStrip1.Size = new System.Drawing.Size(527, 25);
            this.toolStrip1.TabIndex = 8;
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
            this.NavigatorAddButton.Click += new System.EventHandler(this.NavigatorAddButton_Click);
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
            this.NavigatorDeleteButton.Click += new System.EventHandler(this.NavigatorDeleteButton_Click);
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
            this.NavigatorSaveButton.Click += new System.EventHandler(this.NavigatorSaveButton_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn2.HeaderText = "Room";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // generalTableAdapter
            // 
            this.generalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComponentsTableAdapter = null;
            this.tableAdapterManager.ComputersTableAdapter = null;
            this.tableAdapterManager.GeneralTableAdapter = this.generalTableAdapter;
            this.tableAdapterManager.UpdateOrder = ISVT.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(roomLabel);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.generalDataGridView);
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общая информация";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.generalDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource generalBindingSource;
        private DataSet1TableAdapters.GeneralTableAdapter generalTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView generalDataGridView;
        private System.Windows.Forms.TextBox roomTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NavigatorAddButton;
        private System.Windows.Forms.ToolStripButton NavigatorDeleteButton;
        private System.Windows.Forms.ToolStripButton NavigatorSaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}