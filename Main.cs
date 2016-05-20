using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnaddstocks_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStocks addstocks = new AddStocks();
            addstocks.ShowDialog();
        }
    }
}
