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
                            SinhVien a = nhapSV();
                            sv.Add(a);
                            break;
                        }
                    case 3:
                        {
                            int x;
                            do
                            {
                                Console.WriteLine("Nhập vị trí cần xóa :");
                                x = Convert.ToInt32(Console.ReadLine());
                            } while (x < 0 && x > sv.Count);
                            SinhVien a = nhapSV();
                            sv.Insert(x, a);
                            break;
                        }
                    case 4:
                        {
                            int x;
                            do
                            {
                                Console.WriteLine("Nhập vị trí cần xóa :");
                                x = Convert.ToInt32(Console.ReadLine());
                            } while (x < 0 && x > sv.Count);
                            sv.RemoveAt(x);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Nhập mã sinh viên cần tìm :");
                            string x = Console.ReadLine();
                            if (check(x, sv))
                            {
                                SinhVien a = new SinhVien(x);
                                if (sv.IndexOf(a) == -1)
                                {
                                    Console.WriteLine("Không có sinh viên cần tìm");
                                }
                                else
                                {
                                    Console.WriteLine(sv[sv.IndexOf(a)]);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Không có sinh viên nào ");
                            }
                            break;
                        }
                    case 6:
                        {
                            sv.Sort();
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
            list = (List<SinhVien>)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine("Hiện tại chưa có file nào để đọc");
            return list;
        }
        public static SinhVien nhapSV()
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
        }

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
