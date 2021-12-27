using Kiet.DAO;
using Kiet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranTuanKiet_ADO
{
    public partial class Form1 : Form
    {
        CustomerDAO cusBAL = new CustomerDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ProductDTO> lstCus = cusBAL.ReadCustomer();
            foreach (ProductDTO cus in lstCus)
            {
                dataGridView1.Rows.Add(cus.MAKH, cus.TENKH,cus.SDT,cus.SOTIENNO);
            }
        }

        private void tbnThem_Click(object sender, EventArgs e)
        {
            if (tbid.Text.Length > 0 || tbname.Text.Length > 0 || tbsono.Text.Length > 0 || tbsdt.Text.Length > 0)
                tbid.Text = " ";
            tbname.Text = " ";
            tbsdt.Text = " ";
            tbsono.Text = " ";

        }

        private void btnXoa_Click(object sender, EventArgs e)

        {
            
                MessageBox.Show("Bạn có chắc là muốn xóa thành viên này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
           
                SqlConnection conn = new SqlConnection(@"Data Source =TRAN-TUAN-KIET\SQLEXPRESS; Initial Catalog=QLBH_01;
                        User id = sa; Password = sa");
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from CONGNO where MAKH =@MAKH", conn);
                cmd.Parameters.Add(new SqlParameter("@MAKH", tbid.Text));
                cmd.ExecuteNonQuery();
                conn.Close();

                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(idx);
            
        }

        private void btnghi_Click(object sender, EventArgs e)

        {
            if ((tbid.Text == "") || (tbname.Text == "") || tbsdt.Text=="" || tbsono.Text=="")
            {
                MessageBox.Show("Hãy Điền đủ thông tin !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(@"Data Source =TRAN-TUAN-KIET\SQLEXPRESS; Initial Catalog=QLBH_01;
                        User id = sa; Password = sa");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into CONGNO values (@MAKH,@TENKH,@SDT,@SOTIENNO)", conn);
                cmd.Parameters.Add(new SqlParameter("@MAKH", tbid.Text));
                cmd.Parameters.Add(new SqlParameter("@TENKH", tbname.Text));
                cmd.Parameters.Add(new SqlParameter("@SDT", tbsdt.Text));
                cmd.Parameters.Add(new SqlParameter("@SOTIENNO", tbsono.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                dataGridView1.Rows.Add(tbid.Text, tbname.Text, tbsdt.Text, tbsono.Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ROW(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            
            if (idx >= 0)
            {
                tbid.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                tbname.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                tbsdt.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                tbsono.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            }
        }

      
    }
}
