using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ass2.DTO;
using ass2.DAO;

namespace ass2
{
    public partial class fBaoVo : Form
    {
        public fBaoVo()
        {
            InitializeComponent();
            LoadListEmployee();
        }
        
        public void LoadListEmployee()
        {
            dataGridView1.DataSource = EmployeeDAO.Instance.GetListEmployee();

        }
        private void fBaoVo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            
            tFName.Text = dataGridView1.Rows[i].Cells["FName"].Value.ToString();
            tLName.Text = dataGridView1.Rows[i].Cells["LName"].Value.ToString();
            tCMND.Text = dataGridView1.Rows[i].Cells["CMND"].Value.ToString();
            nbAge.Value = Convert.ToInt32(dataGridView1.Rows[i].Cells["Age"].Value);
            lbxSex.Text = dataGridView1.Rows[i].Cells["Sex"].Value.ToString();
            tCountry.Text = dataGridView1.Rows[i].Cells["Country"].Value.ToString();
            tCO_Salary.Text = dataGridView1.Rows[i].Cells["CO_Salary"].Value.ToString();
            dtDate_Start.Text = dataGridView1.Rows[i].Cells["Date_Start"].Value.ToString();
            tAddress.Text = dataGridView1.Rows[i].Cells["Address"].Value.ToString();
            tImage.Text = dataGridView1.Rows[i].Cells["Image_Employee"].Value.ToString();
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellContentClick(sender, e);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            clear();
        }
        private void clear()
        {
            tFName.Clear();
            tLName.Clear();
            tCMND.Clear();
            nbAge.Value = 0;
            lbxSex.Text = "1";
            tCountry.Clear();
            dtDate_Start.Value = DateTime.Now;
            tAddress.Clear();
            tCO_Salary.Clear();
            tImage.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string FName = tFName.Text;
            string LName = tLName.Text;
            int CMND = Convert.ToInt32(tCMND.Text);
            string CO_Salary = tCO_Salary.Text;
            int Age = (int)nbAge.Value;
            string Sex = lbxSex.Text;
            string Country = tCountry.Text;
            string Address = tAddress.Text;
            string Image = tImage.Text;
            DateTime Date = dtDate_Start.Value;
            string Date_start = Date.ToString("yyyyMMdd");

            int a = dataGridView1.Rows.Count;

            string query = $"SELECT * fROM EMPLOYEE WHERE CMND ='" + tCMND.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count >= 1)
            {
                MessageBox.Show("Employee has already existed in the system");
             
            }
            else
            {
                if (FName == "" || LName == ""|| CMND == 0 || Age < 18)
                {
                    MessageBox.Show("Wrong format, Unable to add a staff");
                }
                else
                {
                    if (EmployeeDAO.Instance.InsertStaff(FName,LName,CMND,Age,Sex,Country, Date_start, Address, Convert.ToDouble(CO_Salary),Image) )
                    {
                        MessageBox.Show("Staff added successfully");
                        
                        btnAdd.Enabled = false;
                        clear();
                        LoadListEmployee();
                    }
                    else
                    {
                       MessageBox.Show("Fail to add a Staff");
                       
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value);
            string FName = tFName.Text;
            string LName = tLName.Text;
            int CMND = Convert.ToInt32(tCMND.Text);
            double CO_Salary = Convert.ToDouble(tCO_Salary.Text);
            int Age = (int)nbAge.Value;
            string Sex = lbxSex.Text;
            string Country = tCountry.Text;
            string Address = tAddress.Text;
            string Image = tImage.Text;
            DateTime Date = dtDate_Start.Value;
            string Date_start = Date.ToString("yyyyMMdd");

            if (FName == "" || LName == "" || CMND == 0 || Age < 18)
            {
                MessageBox.Show("Wrong format, Unable to add a staff");
              
                return;
            }

            if (EmployeeDAO.Instance.UpdateStaff(id, FName, LName, CMND, Age, Sex, Country, Date_start, Address, CO_Salary, Image))
            {
                MessageBox.Show("Staff updated successfully");
               
                LoadListEmployee();
                clear();
            }
            else
            {
                MessageBox.Show("Fail to update Staff");
               
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int i = dataGridView1.CurrentRow.Index;
                int id = Convert.ToInt32(dataGridView1.Rows[i].Cells["ID"].Value);
                if (EmployeeDAO.Instance.DeleteStaff(id))
                {
                    MessageBox.Show("Employee deleted successfully");
                    
                    clear();
                    LoadListEmployee();
                }
                else
                {
                    MessageBox.Show("Fail to delete Employee");
            
                }
            }
        }

        private void lbxSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDAO.Instance.GetListEmployeeCMND(int.Parse(tb_search.Text));
            button2.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDAO.Instance.GetListEmployeeWorkPoints();
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = EmployeeDAO.Instance.GetListEmployee();
        }
    }
}
