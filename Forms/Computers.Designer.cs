namespace ISVT
{
    partial class Computers
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
            System.Windows.Forms.Label iDRoomLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label receivingDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Computers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorAddButton = new System.Windows.Forms.ToolStripButton();
            this.NavigatorDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.NavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.dataSet1 = new ISVT.DataSet1();
            this.computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computersTableAdapter = new ISVT.DataSet1TableAdapters.ComputersTableAdapter();
            this.tableAdapterManager = new ISVT.DataSet1TableAdapters.TableAdapterManager();
            this.computersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRoomTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.receivingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDRoomLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            receivingDateLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDRoomLabel
            // 
            iDRoomLabel.AutoSize = true;
            iDRoomLabel.Location = new System.Drawing.Point(561, 31);
            iDRoomLabel.Name = "iDRoomLabel";
            iDRoomLabel.Size = new System.Drawing.Size(49, 13);
            iDRoomLabel.TabIndex = 12;
            iDRoomLabel.Text = "IDRoom:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(561, 57);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(561, 83);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 16;
            priceLabel.Text = "Price:";
            // 
            // receivingDateLabel
            // 
            receivingDateLabel.AutoSize = true;
            receivingDateLabel.Location = new System.Drawing.Point(561, 110);
            receivingDateLabel.Name = "receivingDateLabel";
            receivingDateLabel.Size = new System.Drawing.Size(84, 13);
            receivingDateLabel.TabIndex = 18;
            receivingDateLabel.Text = "Receiving Date:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.NavigatorAddButton,
            this.NavigatorDeleteButton,
            this.NavigatorSaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
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
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
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
            this.NavigatorSaveButton.Click += new System.EventHandler(this.computersBindingNavigatorSaveItem_Click);
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
            // computersTableAdapter
            // 
            this.computersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComponentsTableAdapter = null;
            this.tableAdapterManager.ComputersTableAdapter = this.computersTableAdapter;
            this.tableAdapterManager.GeneralTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ISVT.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // computersDataGridView
            // 
            this.computersDataGridView.AllowUserToAddRows = false;
            this.computersDataGridView.AllowUserToDeleteRows = false;
            this.computersDataGridView.AllowUserToResizeRows = false;
            this.computersDataGridView.AutoGenerateColumns = false;
            this.computersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.computersDataGridView.DataSource = this.computersBindingSource;
            this.computersDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.computersDataGridView.Location = new System.Drawing.Point(12, 28);
            this.computersDataGridView.Name = "computersDataGridView";
            this.computersDataGridView.Size = new System.Drawing.Size(541, 220);
            this.computersDataGridView.TabIndex = 10;
            this.computersDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.computersDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDRoom";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDRoom";
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ReceivingDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "ReceivingDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // iDRoomTextBox
            // 
            this.iDRoomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computersBindingSource, "IDRoom", true));
            this.iDRoomTextBox.Location = new System.Drawing.Point(651, 28);
            this.iDRoomTextBox.Name = "iDRoomTextBox";
            this.iDRoomTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDRoomTextBox.TabIndex = 13;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computersBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(651, 54);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computersBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(651, 80);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 17;
            // 
            // receivingDateDateTimePicker
            // 
            this.receivingDateDateTimePicker.CustomFormat = "dd\'.\'MM\'.\'yyyy HH\':\'mm tt";
            this.receivingDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.computersBindingSource, "ReceivingDate", true));
            this.receivingDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.receivingDateDateTimePicker.Location = new System.Drawing.Point(651, 106);
            this.receivingDateDateTimePicker.Name = "receivingDateDateTimePicker";
            this.receivingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.receivingDateDateTimePicker.TabIndex = 19;
            // 
            // Computers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 261);
            this.Controls.Add(iDRoomLabel);
            this.Controls.Add(this.iDRoomTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(receivingDateLabel);
            this.Controls.Add(this.receivingDateDateTimePicker);
            this.Controls.Add(this.computersDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Computers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вычислительная техника";
            this.Load += new System.EventHandler(this.Computers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource computersBindingSource;
        private DataSet1TableAdapters.ComputersTableAdapter computersTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView computersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox iDRoomTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.DateTimePicker receivingDateDateTimePicker;
    }
}