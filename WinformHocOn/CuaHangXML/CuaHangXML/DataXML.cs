using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CuaHangXML
{
    class DataXML
    {
        XmlDocument doc;
        XmlElement root;
        string filename;

        public DataXML()
        {
            doc = new XmlDocument();
            filename = "SanPham.xml";
            if (!File.Exists(filename))
            {
                XmlElement course = doc.CreateElement("cuahang");
                doc.AppendChild(course);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public List<SanPham> returnList()
        {
            XmlNodeList node = root.SelectNodes("sanpham");
            List<SanPham> list = new List<SanPham>();
            foreach (XmlNode item in node)
            {
                SanPham x = new SanPham();

                x.masp = item.SelectSingleNode("masp").InnerText;
                x.tensp = item.SelectSingleNode("tensp").InnerText;
                x.hangsx = item.SelectSingleNode("hangsx").InnerText;
                x.sl = int.Parse(item.SelectSingleNode("soluong").InnerText);
                x.giatien = int.Parse(item.SelectSingleNode("giatien").InnerText);
                list.Add(x);
            }
            return list;
        }

        public void UpdateSv(string masp)
        {

        }

        public void AddSp(SanPham x)
        {
            XmlElement xmlElement = doc.CreateElement("sanpham");

            XmlElement masp = doc.CreateElement("masp");
            masp.InnerText = x.masp;

            XmlElement tensp = doc.CreateElement("tensp");
            tensp.InnerText = x.tensp;

            XmlElement hangsx = doc.CreateElement("hangsx");
            hangsx.InnerText = x.hangsx;

            XmlElement soluong = doc.CreateElement("soluong");
            soluong.InnerText = x.sl.ToString();

            XmlElement giatien = doc.CreateElement("giatien");
            giatien.InnerText = x.giatien.ToString();


            xmlElement.AppendChild(masp);
            xmlElement.AppendChild(tensp);
            xmlElement.AppendChild(hangsx);
            xmlElement.AppendChild(soluong);
            xmlElement.AppendChild(giatien);

            root.AppendChild(xmlElement);
            doc.Save(filename);
        }


    }
}
