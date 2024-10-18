using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string kq = cbWeb.SelectedItem.ToString();
            txtKQ.Text = $"Bạn đã chọn Website:\t{kq}";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }
    }
}
