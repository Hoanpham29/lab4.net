using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var items in lstLopB.SelectedItems)
            {
                lstLopA.Items.Add((string)items);
            }
            for (int i = lstLopB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach(string items in lstLopA.Items)
            {
                lstLopB.Items.Add(items);
            }
            for (int i = lstLopA.Items.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.Items[i]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (string items in lstLopB.Items)
            {
                lstLopA.Items.Add(items);
            }
            for (int i = lstLopB.Items.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Remove(lstLopB.Items[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var items in lstLopA.SelectedItems)
            {
                lstLopB.Items.Add((string)items);
            }
            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            lstLopA.Items.Add(ten);
            txtTen.Clear();
        }

        private void btnXoaA_Click(object sender, EventArgs e)
        {
            for (int i = lstLopA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[i]);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnXoaB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
