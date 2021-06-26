using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    [Serializable]
    class Student:IComparable<Student>
    {
        public string id{ get; set; }
        public string name{ get; set; }
        public int mark{ get; set; }
        public string email { get; set; }

        public Student()
        {

        }
        public Student(string id, string name, int mark, string email)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
            this.email = email;

        }
        public Student(string id)
        {
            this.id = id;
        }
        public override string ToString()
        {
            return id + ", " + name + ", " + mark + ", " + email;
        }
        public override bool Equals(object obj)
        {
            Student s = (Student)obj;
            return (this.id.Equals(s.id));
        }

        public int CompareTo(Student other)
        {
            // return (this.mark - other.mark);
            return (this.id.CompareTo(other.id));
        }
    }
}
