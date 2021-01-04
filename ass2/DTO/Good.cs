using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2.DTO
{
    class Good
    {
        private int id;
        private string name;
        private DateTime exDay;
        private int core;
        private DateTime proDay;
        private int qr;
        private string company;
        private int price;
        private string image;
        private int rest;
        private int importId;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime ExDay { get => exDay; set => exDay = value; }
        public int Core { get => core; set => core = value; }
        public DateTime ProDay { get => proDay; set => proDay = value; }
        public int Qr { get => qr; set => qr = value; }
        public string Company { get => company; set => company = value; }
        public int Price { get => price; set => price = value; }
        public string Image { get => image; set => image = value; }
        public int Rest { get => rest; set => rest = value; }
        public int ImportId { get => importId; set => importId = value; }
        public Good(DataRow row)
        {
            this.id = (int)row["ID"];
            this.name = row["Name"].ToString();
            this.rest = (int)row["Rest"];
            this.price = (int)row["Price"];
            this.qr = (int)row["QR"];
            this.image = row["Image_pro"].ToString();
        }
    }
}
