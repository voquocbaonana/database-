using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DTO
{
    class Customer
    {
        private int id;
        private string name;
        private string sex;
        private string adress;
        private string typeCard;
        private string phone;
        private int poin;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Adress { get => adress; set => adress = value; }
        public string TypeCard { get => typeCard; set => typeCard = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Poin { get => poin; set => poin = value; }
        public string Email { get => email; set => email = value; }
        public Customer(DataRow row)
        {
            this.id = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.phone = row["Phone"].ToString();
            this.poin = (int)row["Points"];
        }
    }
}
