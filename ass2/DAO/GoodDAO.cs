using ass2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DAO
{
    class GoodDAO
    {
        private static GoodDAO instance; // Ctrl + R + E

        public static GoodDAO Instance
        {
            get { if (instance == null) instance = new GoodDAO(); return GoodDAO.instance; }
            private set { GoodDAO.instance = value; }
        }

        private GoodDAO() { }
        public Good SelectGoodByQR(int qr)
        {
            Good re;
            string query = "SELECT * FROM GOODS WHERE QR = @qr";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { qr });
            foreach (DataRow item in data.Rows)
            {
                re = new Good(item);
                return re;
            }
            return null;
        }
        public bool QRisValid(int qr)
        {
            string query = "SELECT * FROM GOODS WHERE QR = @qr";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { qr });
            foreach (DataRow item in data.Rows)
            {
                return true;
            }
            return false;
        }
    }
}
