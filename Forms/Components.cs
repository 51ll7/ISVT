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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void generalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.generalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.dataSet1.Components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.General". При необходимости она может быть перемещена или удалена.
            this.generalTableAdapter.Fill(this.dataSet1.General);

        }
    }
}
