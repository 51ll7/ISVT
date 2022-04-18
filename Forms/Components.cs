using System;
using System.Data;
using System.Windows.Forms;

namespace ISVT
{
    public partial class ComponentsT : Form
    {
        public ComponentsT()
        {
            InitializeComponent();
            toolStrip1.Renderer = new MySR();
        }

        private void componentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            componentsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            componentsTableAdapter.Fill(dataSet1.Components);
        }

        private void NavigatorDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Точно хотите удалить?",
                "Удаление", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (deleteResult == DialogResult.Yes) componentsBindingSource.RemoveCurrent();
        }

        private void NavigatorAddButton_Click(object sender, EventArgs e)
        {
            iDComputersTextBox.Focus();
            componentsBindingSource.AddNew();
            try
            {
                componentsDataGridView.CurrentRow.Cells[0].Value = (int)dataSet1.Tables["Components"].Compute("MAX(ID)", null) + 1;
            }
            catch
            {
                componentsDataGridView.CurrentRow.Cells[0].Value = 1;
            }
        }

        private void componentsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Заполните все значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            componentsDataGridView.DataSource = dataSet1.Components;                                           //Поиск по частичному совпадению
            (componentsDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert(ID,'System.String') like '{0}%' OR Convert(IDComputers,'System.String') like '{0}%' OR Description like '{0}%' OR Convert(Price,'System.String') like '{0}%'", toolStripTextBox1.Text);
            //componentsBindingSource.Position = componentsBindingSource.Find("Room", toolStripTextBox1.Text); //Поиск по полному совпадению
        }
    }
}
