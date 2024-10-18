using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = cmbFont.SelectedItem.ToString();
            richTextBox1.Font = new Font(selectedFont, richTextBox1.Font.Size);
        }
    }
}
