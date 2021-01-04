using ass2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DAO
{
    class CustomerDAO
    {
        private static CustomerDAO instance; // Ctrl + R + E

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }
        public Customer SelectKHById(int id)
        {
            Customer re;
            string query = "SELECT * FROM dbo.CUSTOMER WHERE ID = @";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                re = new Customer(item);
                return re;
            }
            return null;
        }
        public Customer SelectKHByPhone(string phone)
        {
            Customer re;
            string query = "SELECT * FROM dbo.CUSTOMER WHERE Phone = @";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });
            foreach (DataRow item in data.Rows)
            {
                re = new Customer(item);
                return re;
            }
            return null;
        }
        public DataTable SelectListKHById(int id)
        {

            string query = "SELECT * FROM dbo.CUSTOMER WHERE ID like '%"+id.ToString()+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
           
            return data;
        }
        public DataTable SelectListKHByPhone(string phone)
        {
           
            string query = "SELECT * FROM dbo.CUSTOMER WHERE Phone like '%"+phone+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
          
            return data;
        }
    }
}
