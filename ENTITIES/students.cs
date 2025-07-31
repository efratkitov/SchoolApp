using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES
{
    //מחלקה לייצוג תלמיד
    public class student
    {
        public string ID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }

        public string homePhone { get; set; }

        public string birthdayyear { get; set; }
        public string class1 { get; set; }
        public string address { get; set; }

        //פעולה בונה
        //public student(int id, string firstName, string lastName, string homePhone, int birthdayyaer, string class1, string address)
        //{
        //    ID = id;
        //    this.firstName = firstName;
        //    LastName = lastName;
        //    this.homePhone = homePhone;
        //    this.birthdayyaer = birthdayyaer;
        //    this.class1 = class1;
        //    this.address = address;
        //}

    }


}
