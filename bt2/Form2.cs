using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void funData(TextBox txtform1)
        {
            label1.Text = txtform1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
