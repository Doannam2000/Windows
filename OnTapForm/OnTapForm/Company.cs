using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapForm
{
    class Company
    {
        public int id{ get; set; }
        public string name { get; set; }
        public string phone{ get; set; }
        public float salary{ get; set; }
        public int addrid{ get; set; }
        public Company()
        {

        }
        public Company(int id,string name,string phone,float salary,int addrid)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.salary = salary;
            this.addrid = addrid;
        }
    }
}
