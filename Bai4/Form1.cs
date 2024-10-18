using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThem2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSoNguyen.Items.Count; i++)
            {
                if (int.TryParse(lstSoNguyen.Items[i].ToString(), out int value))
                {
                    lstSoNguyen.Items[i] = value + 2;
                }
            }
        }

        private void BtnChanDau_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSoNguyen.Items.Count; i++)
            {
                if (int.TryParse(lstSoNguyen.Items[i].ToString(), out int value) && value%2==0)
                {
                    MessageBox.Show("Số chẵn đầu tiên: "+value);
                    break;
                }
            }
        }

        private void BtnLeCuoi_Click(object sender, EventArgs e)
        {
            for (int i = lstSoNguyen.Items.Count-1; i >=0; i--)
            {
                if (int.TryParse(lstSoNguyen.Items[i].ToString(), out int value) && value % 2 != 0)
                {
                    MessageBox.Show("Số lẻ cuối cùng: " + value);
                    break;
                }
            }
        }

        private void BtnXoaDangChon_Click(object sender, EventArgs e)
        {
            for (int i = lstSoNguyen.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstSoNguyen.Items.Remove(lstSoNguyen.SelectedItems[i]);
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string add = txtSoNguyen.Text;
            lstSoNguyen.Items.Add(add);
            txtSoNguyen.Clear();
        }

        private void BtnXoaDau_Click(object sender, EventArgs e)
        {
            lstSoNguyen.Items.RemoveAt(0);
        }

        private void BtnXoaCuoi_Click(object sender, EventArgs e)
        {
            lstSoNguyen.Items.RemoveAt(lstSoNguyen.Items.Count-1);
        }

        private void BtnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
