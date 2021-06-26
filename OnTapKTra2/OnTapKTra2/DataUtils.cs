using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKTra2
{
    class DataUtils
    {
        string fileName = "student.bin";
        public DataUtils()
        {
            
        }

        public List<Student> readFile()
        {
            List<Student> list = new List<Student>();
            Stream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
            IFormatter formatter = new BinaryFormatter();
            try
            {
                list = formatter.Deserialize(stream) as List<Student>;
            }
            catch (Exception)
            {
                
            }
            stream.Close();
            return list;
        }
        public bool writeFile(List<Student> list)
        {
            Stream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            IFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, list);
            }
            catch (Exception)
            {
                stream.Close();
                return false;
            }
            stream.Close();
            return true;
        }
    }
}
