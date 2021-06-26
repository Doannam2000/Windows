using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    class ReadWriteObjectFile
    {
        static void Main(string[] arg)
        {
            string filename = "student.bin";
            //  Write(filename);
            //  Read(filename);

            //TEST LIST COLLECTION
            List<Student> ds = new List<Student>();
            ds.Add(new Student("s1", "Anh", 9, "anh@gmail.com"));
            ds.Add(new Student("s2", "Tuan", 1, "tuananh@gmail.com"));
            ds.Add(new Student("s3", "Long", 3, "long@gmail.com"));
            ds.Add(new Student("s4", "Hai", 7, "hai@gmail.com"));

            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }
            Student x = new Student("s3");
            int vitri = ds.IndexOf(x);  
             
            x = ds[vitri];

            Console.WriteLine("\nKet qua tim kiem o vi tri : " + vitri);
            Console.WriteLine("Sv can tim la: " + x);

            ds.RemoveAt(3);
            Console.WriteLine("\n----\nSau khi xoa phan tu thu 2: ");
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }

            ds.Add(new Student("s5", "Van", 4, "van@gmail.com"));
            Console.WriteLine("\n----\nSau khi them vao: ");
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }
            ds.Insert(1, new Student("s6", "Mai", 8, "mai@gmail.com"));
            Console.WriteLine("\n----\nSau khi them vao vi tri so 1: ");
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }

            ds.Sort();
            Console.WriteLine("\n----\nSau khi sap xep danh sach: ");
            for (int i = 0; i < ds.Count; i++)
            {
                Console.WriteLine(ds[i]);
            }

        }
        public static void Write(string filename)
        {
            Student s1 = new Student("s1", "Mai Anh", 8, "anhmai@gmail.com");
            Student s2 = new Student("s2", "Van Tuan", 5, "tuananh@gmail.com");
            List<Student> li = new List<Student>();
            li.Add(s1);
            li.Add(s2);

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, li);
            //formatter.Serialize(stream, s2);
            stream.Close();

        }
        public static void Read(string filename)
        {
            Student s1, s2;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            List<Student> li = new List<Student>();
            li = (List<Student>)formatter.Deserialize(stream);
            foreach (Student item in li)
            {
                Console.WriteLine(item);

            }
           // s2 = (Student)formatter.Deserialize(stream);
 

            stream.Close();

        }
    }
}
