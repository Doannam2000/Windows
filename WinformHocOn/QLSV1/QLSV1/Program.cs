using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            List<SinhVien> sv = new List<SinhVien>();
            do
            {
                Console.WriteLine("----------------MENU--------------|");
                Console.WriteLine("1.Đọc danh sách từ file           |");
                Console.WriteLine("2.Thêm 1 sinh viên                |");
                Console.WriteLine("3.Chèn sinh viên                  |");
                Console.WriteLine("4.Xóa sinh viên                   |");
                Console.WriteLine("5.Tìm sinh viên                   |");
                Console.WriteLine("6.Sắp xếp sinh viên               |");
                Console.WriteLine("7.Hiển thị danh sách              |");
                Console.WriteLine("8.Ghi vào file                    |");
                Console.WriteLine("9.Kết thúc                        |");
                Console.WriteLine("----------------------------------|");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        sv = ReadSV();
                        break;

                    case 2:
                        SinhVien a = new SinhVien();
                        Console.WriteLine("Nhập thông tin sinh viên");
                        Console.WriteLine("Nhập mã sinh viên :");
                        a.masv = Console.ReadLine();
                        if (sv.IndexOf(a) == -1)
                        {
                            Console.WriteLine("Nhập tên sinh viên :");
                            a.tensv = Console.ReadLine();
                            Console.WriteLine("Nhập tuổi sinh viên :");
                            try
                            {
                                a.tuoi = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Bạn nhập sai dữ liệu");
                                break;
                            }
                            Console.WriteLine("Nhập địa chỉ sinh viên :");
                            a.diachi = Console.ReadLine();
                            sv.Add(a);
                        }
                        else
                            Console.WriteLine("Đã tồn tại");
                        break;

                    case 3:
                        Console.WriteLine("Nhập vị trí cần chèn 0 <= vtri <= {0} ( nếu k thỏa mãn vị trí sẽ tự động chèn vào đầu hoặc cuối )", sv.Count);
                        int vt = int.Parse(Console.ReadLine());
                        if (vt < 0)
                            vt = 0;
                        else if (vt > sv.Count)
                            vt = sv.Count;
                        SinhVien b = new SinhVien();
                        Console.WriteLine("Nhập thông tin sinh viên");
                        Console.WriteLine("Nhập mã sinh viên :");
                        b.masv = Console.ReadLine();
                        if (sv.IndexOf(b) == -1)
                        {
                            Console.WriteLine("Nhập tên sinh viên :");
                            b.tensv = Console.ReadLine();
                            Console.WriteLine("Nhập tuổi sinh viên :");
                            try
                            {
                                b.tuoi = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Bạn nhập sai dữ liệu");
                                break;
                            }
                            Console.WriteLine("Nhập địa chỉ sinh viên :");
                            b.diachi = Console.ReadLine();
                            sv.Insert(vt, b);
                        }
                        else
                            Console.WriteLine("Đã tồn tại");
                        break;

                    case 4:
                        Console.WriteLine("Nhập vị trí cần xóa 0 <= vtri <= {0} ( nếu k thỏa mãn vị trí sẽ tự động xóa ở đầu hoặc cuối )", sv.Count);
                        vt = int.Parse(Console.ReadLine());
                        if (vt < 0)
                            vt = 0;
                        else if (vt > sv.Count)
                            vt = sv.Count-1;
                        sv.RemoveAt(vt);
                        break;

                    case 5:
                        a = new SinhVien();
                        Console.WriteLine("Nhập mã sinh viên cần tìm :");
                        a.masv = Console.ReadLine();
                        if (sv.IndexOf(a) == -1)
                            Console.WriteLine("Không có sinh viên nào");
                        else
                            Console.WriteLine(sv[sv.IndexOf(a)]);
                        break;

                    case 6:
                        sv.Sort();
                        break;

                    case 7:
                        foreach (SinhVien item in sv)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 8:
                        if(WriteFile(sv))
                            Console.WriteLine("OK");
                        else
                            Console.WriteLine("Không được =.=");
                        break;

                    case 9: return;

                }
            } while (true);
        }

        public static List<SinhVien> ReadSV()
        {
            List<SinhVien> SV = new List<SinhVien>();

            Stream stream = new FileStream("sinhvien.bin", FileMode.OpenOrCreate, FileAccess.Read);
            IFormatter formater = new BinaryFormatter();
            try
            {
                SV = (List<SinhVien>)formater.Deserialize(stream);
            }
            catch (Exception)
            {
            }
            stream.Close();
            return SV;
        }
        public static Boolean WriteFile(List<SinhVien> sv)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("sinhvien.bin", FileMode.OpenOrCreate, FileAccess.Write);
            try
            {
                formatter.Serialize(stream, sv);
                stream.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    
}
