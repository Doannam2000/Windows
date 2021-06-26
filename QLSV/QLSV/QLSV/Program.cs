using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace QuanLySVConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            String filename = "SinhVien.bin";
            List<SinhVien> sv = funcRead(filename);
            int chose;
            do
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("|1.Đọc danh sách sinh viên từ file và hiển thị |");
                Console.WriteLine("|2.Thêm 1 sinh viên                            |");
                Console.WriteLine("|3.Chèn sinh viên vào vị trí                   |");
                Console.WriteLine("|4.Xóa sinh viên                               |");
                Console.WriteLine("|5.Tìm sinh viên                               |");
                Console.WriteLine("|6.Sắp xếp sinh viên và hiển thị               |");
                Console.WriteLine("|7.Hiển thị danh sách                          |");
                Console.WriteLine("|8.Ghi vào file                                |");
                Console.WriteLine("|9.Kết thúc                                    |");
                Console.WriteLine("------------------------------------------------");
                Console.Write("==>> Nhập lựa chọn của bạn: ");
                chose = int.Parse(Console.ReadLine());
                switch (chose)
                {
                    case 1:
                        {
                            sv = funcRead(filename);
                            foreach (SinhVien item in sv)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhập thông tin sinh viên :");
                            SinhVien a = new SinhVien();
                            Console.WriteLine("Nhập mã sinh viên :");
                            a.ID = Console.ReadLine();
                            if (check(a.ID, sv))
                            {
                                Console.WriteLine("Nhập tên sinh viên :");
                                a.tenSV = Console.ReadLine();
                                Console.WriteLine("Nhập tuổi sinh viên :");
                                a.tuoi = Convert.ToInt32(Console.ReadLine());
                                sv.Add(a);
                            }
                            else
                            {
                                Console.WriteLine("Mã đã tồn tại ");
                            }
                            break;
                        }
                    case 3:
                        {
                            int x;
                           Console.WriteLine("Nhập vị trí cần chèn :");
                                try 
                                {
                                    x = Convert.ToInt32(Console.ReadLine());
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine("Nhập sai kiểu dữ liệu rồi");
                                    break;
                                }
                            if (x < 0)
                            {
                                Console.WriteLine("Vì vị trí nhập < 0 nên mặc định chuyển sang vị trí 0");
                                x = 0;
                            }
                            else if (x > sv.Count)
                            {
                                Console.WriteLine("Vì vị trí nhập > {0} nên mặc định chuyển sang vị trí {0}",sv.Count);
                                x = sv.Count;

                            }
                            Console.WriteLine("Nhập thông tin sinh viên :");
                            SinhVien a = new SinhVien();
                            Console.WriteLine("Nhập mã sinh viên :");
                            a.ID = Console.ReadLine();
                            if(check(a.ID,sv))
                            {
                                Console.WriteLine("Nhập tên sinh viên :");
                                a.tenSV = Console.ReadLine();
                                Console.WriteLine("Nhập tuổi sinh viên :");
                                a.tuoi = Convert.ToInt32(Console.ReadLine());
                                sv.Insert(x, a);
                            }
                            else
                            {
                                Console.WriteLine("Mã đã tồn tại ");
                            }    
                            break;
                        }
                    case 4:
                        {
                            int x;
                            Console.WriteLine("Nhập vị trí cần chèn :");
                            try
                            {
                                x = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Nhập sai kiểu dữ liệu rồi");
                                break;
                            }
                            if (x < 0)
                            {
                                Console.WriteLine("Vì vị trí nhập < 0 nên mặc định chuyển sang vị trí 0");
                                x = 0;
                            }
                            else if (x > sv.Count)
                            {
                                Console.WriteLine("Vì vị trí nhập > {0} nên mặc định chuyển sang vị trí {0}", sv.Count);
                                x = sv.Count;
                            }
                            sv.RemoveAt(x);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Nhập mã sinh viên cần tìm :");
                            string x = Console.ReadLine();
                            SinhVien a = new SinhVien(x);
                            if (sv.IndexOf(a) == -1)
                            {
                                Console.WriteLine("Không có sinh viên cần tìm");
                            }
                            else
                            {
                                Console.WriteLine(sv[sv.IndexOf(a)]);
                            }
                            break;
                        }
                    case 6:
                        {
                            sv.Sort();
                            foreach (SinhVien item in sv)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 7:
                        {
                            foreach (SinhVien item in sv)
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        }
                    case 8:
                        {

                            IFormatter formatter = new BinaryFormatter();
                            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                            formatter.Serialize(stream, sv);
                            stream.Close();
                            break;
                        }
                }
            } while (chose != 9);

        }

        public static List<SinhVien> funcRead(string file)
        {
            List<SinhVien> list = new List<SinhVien>();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                list = (List<SinhVien>)formatter.Deserialize(stream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hiện tại chưa có file nào để đọc");
            }
            stream.Close();
            return list;
        }
/*        public static SinhVien nhapAndCheckSV(List<SinhVien> sv)
        {

            Console.WriteLine("Nhập thông tin sinh viên :");
            SinhVien a = new SinhVien();
            Console.WriteLine("Nhập mã sinh viên :");
            a.ID = Console.ReadLine();
            Console.WriteLine("Nhập tên sinh viên :");
            a.tenSV = Console.ReadLine();
            Console.WriteLine("Nhập tuổi sinh viên :");
            a.tuoi = Convert.ToInt32(Console.ReadLine());
            return a;
        }*/

        public static bool check(string ma, List<SinhVien> sv)
        {
            foreach (SinhVien item in sv)
            {
                if (item.ID.Equals(ma))
                    return false;
            }
            return true;
        }
    }
}
