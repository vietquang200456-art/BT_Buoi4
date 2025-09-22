using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4LTWIN
{
    public partial class Form1 : Form
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "Nguyen Van A", ID = 1 });
            students.Add(new Student() { Name = "Nguyen Van B", ID = 2 });
            students.Add(new Student() { Name = "Nguyen Van C", ID = 3 });
            students.Add(new Student() { Name = "Nguyen Van D", ID = 4 });
            students.Add(new Student() { Name = "Nguyen Van E", ID = 5 });
            return students;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "MSSV";
            dataGridView1.Columns[1].Name = "Họ tên";
            dataGridView1.Columns[2].Name = "Giới Tính";
            dataGridView1.Columns[3].Name = "Điểm TB";
            dataGridView1.Columns[4].Name = "Khoa";
            cbChuyenNganh.SelectedIndex = 0;
            rdbNu.Checked = true;
        }
        private void UpdateStatic()
        {
            int countNam = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["Giới Tính"].Value != null && row.Cells["Giới Tính"].Value.ToString() == "Nam")
                {
                    countNam++;
                }
            }
            txbTongSVNam.Text = countNam.ToString();

            int CountNu = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells["Giới Tính"].Value != null && row.Cells["Giới Tính"].Value.ToString() == "Nữ")
                {
                    CountNu++;
                }
            }
            txbTongSVNu.Text = CountNu.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        { 
        }

       
        

        private void btnSua1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
          

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string gioiTinh = rdbNam.Checked ? "Nam" : "Nữ";

                dataGridView1.Rows.Add(
                txbMSSV.Text,
                txbHoTen.Text,
                gioiTinh,
                txbDTB.Text,
                cbChuyenNganh.Text
            );
            txbMSSV.Clear();
            txbHoTen.Clear();
            txbDTB.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = true;
            cbChuyenNganh.SelectedText = "";
            UpdateStatic();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            txbMSSV.Clear();
            txbHoTen.Clear();
            txbDTB.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            cbChuyenNganh.SelectedText = "";
            UpdateStatic();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txbMSSV.Text = row.Cells["MSSV"].Value.ToString();
                txbHoTen.Text = row.Cells["Họ Tên"].Value.ToString();
                txbDTB.Text = row.Cells["Điểm TB"].Value.ToString();
                cbChuyenNganh.Text = row.Cells["Khoa"].Value.ToString();
                if(row.Cells["Giới Tính"].Value.ToString() == "Nam")
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng hợp lệ.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells["MSSV"].Value = txbMSSV.Text;
                dataGridView1.CurrentRow.Cells["Họ Tên"].Value = txbHoTen.Text;
                dataGridView1.CurrentRow.Cells["Điểm TB"].Value = txbDTB.Text;
                dataGridView1.CurrentRow.Cells["Giới Tính"].Value = rdbNam.Checked ? "Nam" : "Nữ";
                dataGridView1.CurrentRow.Cells["Khoa"].Value = cbChuyenNganh.Text;
            }
            txbMSSV.Clear();
            txbHoTen.Clear();
            txbDTB.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            cbChuyenNganh.SelectedText = "";
            UpdateStatic();
        }
    }
}
