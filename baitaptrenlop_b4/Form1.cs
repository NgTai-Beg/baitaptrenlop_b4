using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitaptrenlop_b4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Nguyen Van A", Age = 20 });
            students.Add(new Student() { Id = 2, Name = "Nguyen Van B", Age = 22 });
            students.Add(new Student() { Id = 3, Name = "Nguyen Van c", Age = 30 });
            dtgSv.DataSource = students;
        }

        private void dtgSv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dt = (DataGridView)sender;
            if (e.RowIndex == -1)
            {
                return;
            }
            DataGridViewRow row = dt.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAge.Text = row.Cells[2].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          students.Add(new Student() {Id = int.Parse(txtId.Text),Name = txtName.Text,Age=int.Parse(txtAge.Text)});
          dtgSv.DataSource = new BindingList<Student>(students);
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int currentIndex = dtgSv.CurrentCell.RowIndex;
            students.RemoveAt(currentIndex);
            dtgSv.DataSource = new BindingList<Student>(students);
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgSv.SelectedRows.Count > 0)
            {
                // Lấy chỉ số dòng được chọn
                int selectedIndex = dtgSv.SelectedRows[0].Index;

                // Cập nhật trực tiếp vào danh sách students
                students[selectedIndex].Id = int.Parse(txtId.Text); 
                students[selectedIndex].Name = txtName.Text;
                students[selectedIndex].Age = int.Parse(txtAge.Text);

                // Làm mới lại DataGridView để hiển thị thay đổi
                dtgSv.Refresh();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtId.Clear();
            txtName.Clear();
            txtAge.Clear();  



        }
    }
}
