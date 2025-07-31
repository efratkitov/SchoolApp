using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    public class teacher
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string mailaddress { get; set; }

        //פעולה בונה
        public teacher(int id, string firstName, string lastName, string phone, string mailaddress)
        {
            ID = id;
            this.firstName = firstName;
            LastName = lastName;
            Phone = phone;
            this.mailaddress = mailaddress;
        }
    }
}
