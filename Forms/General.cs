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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void NavigatorSaveButton_Click(object sender, EventArgs e)
        {
            Validate();
            generalBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.General". При необходимости она может быть перемещена или удалена.
            generalTableAdapter.Fill(dataSet1.General);

        }

        private void NavigatorDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Точно хотите удалить?", 
                "Удаление",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (deleteResult == DialogResult.Yes) generalBindingSource.RemoveCurrent();
        }

        private void NavigatorAddButton_Click(object sender, EventArgs e)
        {
            generalBindingSource.Add();
        }
    }
}
