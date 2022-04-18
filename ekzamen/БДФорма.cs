using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ekzamen
{
    public partial class БДФорма : Form
    {
        public БДФорма()
        {
            InitializeComponent();
        }

        private void БДФорма_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_КЭ_РученинААDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this._44П_КЭ_РученинААDataSet.Книги);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
