using System;
using System.Data;
using System.Windows.Forms;

namespace ISVT
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
            toolStrip1.Renderer = new MySR();
        }

        private void NavigatorSaveButton_Click(object sender, EventArgs e)
        {
            Validate();
            generalBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            generalTableAdapter.Fill(dataSet1.General);
        }

        private void NavigatorDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Точно хотите удалить?",
                "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (deleteResult == DialogResult.Yes) generalBindingSource.RemoveCurrent();
        }

        private void NavigatorAddButton_Click(object sender, EventArgs e)
        {
            roomTextBox.Focus();
            generalBindingSource.AddNew();
            try
            {
                generalDataGridView.CurrentRow.Cells[0].Value = (int)dataSet1.Tables["General"].Compute("MAX(ID)", null) + 1;
            }
            catch
            {
                generalDataGridView.CurrentRow.Cells[0].Value = 1;
            }
        }

        private void generalDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Заполните все значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            generalDataGridView.DataSource = dataSet1.General;                                           //Поиск по частичному совпадению
            (generalDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(ID,'System.String') like '{0}%' OR Room like '{0}%' OR Convert(Quantity,'System.String') like '{0}%'", toolStripTextBox1.Text);
            //generalBindingSource.Position = generalBindingSource.Find("Room", toolStripTextBox1.Text); //Поиск по полному совпадению
        }
    }
}
