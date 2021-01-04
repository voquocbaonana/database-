using ass2.DAO;
using ass2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass2
{
    public partial class fKhachHang : Form
    {
        public fKhachHang()
        {
            InitializeComponent();
        }


        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choose = (sender as ComboBox).Text;
            if (choose == "Id" || choose == "Phone")
            {
                tbSearch.Enabled = true;
                tbSearch.Tag = choose;
            }
            else
            {
                tbSearch.Enabled = false;
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string choose = (sender as TextBox).Tag.ToString();
            string text = (sender as TextBox).Text;
            DataTable data;
            if (text == "")
            {
                return;
            }
            if (choose == "Id")
            {
                
                data = CustomerDAO.Instance.SelectListKHById(Convert.ToInt32(text));
                List<Customer> ls = new List<Customer>();
                foreach (DataRow item in data.Rows)
                {
                    ls.Add(new Customer(item));
                }
                dtgvKH.DataSource = ls;
            }
            else if (choose == "Phone")
            {
                data = CustomerDAO.Instance.SelectListKHByPhone(text);
                List<Customer> ls = new List<Customer>();
                foreach (DataRow item in data.Rows)
                {
                    ls.Add(new Customer(item));
                }
                dtgvKH.DataSource = ls;
                
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbChon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
