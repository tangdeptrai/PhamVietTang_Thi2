using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class Node
    {
        public int MaSo { get; set; }
        public string TenHang { get; set; }
        public int DonGia { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int maSo, string tenHang, int donGia)
        {
            MaSo = maSo;
            TenHang = tenHang;
            DonGia = donGia;
            Left = Right = null;
        }
    }
}
