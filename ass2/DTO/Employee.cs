using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DTO
{
    class Employee
    {
        private int id;
        private string fName;
        private string lName;
        private int CMND;
        private int age;
        private int sex;
        private string country;
        private DateTime Date_start;
        private string address;
        private float salary;
        private string image;

        public Employee(
            int id,
            string fName,
            string lName,
            int CMND,
            int age,
            int sex,
            string country,
            DateTime Date_start, 
            string address,
            float salary,
            string image)
        {
           
        }
        public Employee(DataRow row)
        {
            this.id = (int)row["ID"];
            this.fName = row["FName"].ToString();
            this.lName = row["LName"].ToString();
            this.CMND = (int)row["CMND"];
            this.age = (int)row["Age"];
            this.sex = Convert.ToInt32( row["Sex"].ToString());
            this.country= row["Country"].ToString();
            this.Date_start = (DateTime)row["Date_start"];
            this.address= row["Address"].ToString();
            this.salary= (float)Convert.ToDouble(row["CO_Salary"].ToString());
            this.image = row["Image_Employee"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public int CMND1 { get => CMND; set => CMND = value; }
        public int Age { get => age; set => age = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Country { get => country; set => country = value; }
        public DateTime Date_start1 { get => Date_start; set => Date_start = value; }
        public string Address { get => address; set => address = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Image { get => image; set => image = value; }
    }
}
