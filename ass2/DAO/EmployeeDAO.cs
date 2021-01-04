using ass2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DAO
{
    class EmployeeDAO
    {
        private static EmployeeDAO instance; // Ctrl + R + E

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }
        public DataTable GetListEmployee()
        {
            string query = $"Select  * FROM EMPLOYEE ";
                       
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        private EmployeeDAO() { }
        public DataTable GetListEmployeeCMND(int CMND )
        {
            string query = $"Select  * FROM EMPLOYEE WHERE CMND = {CMND}";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public DataTable GetListEmployeeWorkPoints()
        {
            string query = $"SELECT EMPLOYEE.ID,FName,LName,CMND,Age,Sex,Country,Date_start,Address,CO_Salary,Image_Employee,WorkDate,Num_shifts,Employee_id,Branch_id,idExpend" +
           " FROM EMPLOYEE JOIN WORK_POINTS " + $"ON EMPLOYEE.ID = Employee_id";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public Employee SelectNVByID(int id)
        {
            Employee re;
            string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]{ id});
            foreach (DataRow item in data.Rows)
            {
                re = new Employee(item);
                return re;
            }
            return null;
        }
        
        public bool InsertStaff(string Fname,string LName, int CMND, int age, string sex, string Country,string Date_start,string address, double CO_Salary,string image)
        {
            string query = $"INSERT INTO EMPLOYEE (FName,LName,CMND,Age,Sex,Country,Date_start, Address,CO_Salary, Image_Employee)" + 
                $" VALUES ('{Fname}','{LName}',{CMND},{age},'{sex}','{Country}','{Date_start}','{address}',{CO_Salary},'{image}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public bool UpdateStaff(int IDUser, string Fname, string LName, int CMND, int age, string sex, string Country, string Date_start, string address, double CO_Salary, string image)
        {
            string query = $"UPDATE EMPLOYEE SET FName = '{Fname}',LName = '{LName}',CMND ='{CMND}', Age = {age},Sex ='{sex}', Country = '{Country}',Date_start= '{Date_start}',Address ='{address}',CO_Salary ={CO_Salary},Image_employee = '{image}' WHERE ID = {IDUser}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

        public bool DeleteStaff(int IDUser)
        {
            string query = string.Format("DELETE FROM EMPLOYEE WHERE ID = '" + IDUser + "' ");
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return (result > 0);
        }

    }
}
