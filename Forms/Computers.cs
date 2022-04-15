using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISVT
{
    public partial class Computers : Form
    {
        public Computers()
        {
            InitializeComponent();
            toolStrip1.Renderer = new MySR();
        }

        private void computersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            computersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);
        }

        private void Computers_Load(object sender, EventArgs e)
        {
            computersTableAdapter.Fill(dataSet1.Computers);
        }

        private void NavigatorDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Точно хотите удалить?",
                "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (deleteResult == DialogResult.Yes) computersBindingSource.RemoveCurrent();
        }

        private void NavigatorAddButton_Click(object sender, EventArgs e)
        {
            iDRoomTextBox.Focus();
            computersBindingSource.AddNew();
            try
            {
                computersDataGridView.CurrentRow.Cells[0].Value = (int)dataSet1.Tables["Computers"].Compute("MAX(ID)", null) + 1;
            }
            catch
            {
                computersDataGridView.CurrentRow.Cells[0].Value = 1;
            }
        }

        private void computersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Заполните все значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            computersDataGridView.DataSource = dataSet1.Computers;                                           //Поиск по частичному совпадению
            (computersDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(ID,'System.String') like '{0}%' OR Convert(IDRoom,'System.String') like '{0}%' OR Convert(Quantity,'System.String') like '{0}%' OR Description like '{0}%' Convert(Price,'System.String') like '{0}%' OR Convert(ReceivingDate,'System.String') like '{0}%'", toolStripTextBox1.Text);
            //computersBindingSource.Position = computersBindingSource.Find("Description", toolStripTextBox1.Text); //Поиск по полному совпадению
        }
    }
}
