using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void delPassdata(TextBox text);

        private void btnBam_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            delPassdata del = new delPassdata(form2.funData);
            del(this.txtNhap);
            form2.ShowDialog();
        }
    }
}
