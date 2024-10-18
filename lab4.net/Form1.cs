using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4.net
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string kq = lstWeb.SelectedItem.ToString();
            txtKQ.Text =$"Bạn đã chọn Website:\t\t{kq}";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
