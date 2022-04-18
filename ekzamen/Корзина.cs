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
    public partial class Корзина : Form
    {
        public Корзина()
        {
            InitializeComponent();
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Заказ_Click(object sender, EventArgs e)
        {
            Program.price = 0;
            Program.count = 0;

        }
    }
}
