using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class LinkedListNode
    {
        public int MaSo { get; set; }
        public string TenHang { get; set; }
        public int DonGia { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int maSo, string tenHang, int donGia)
        {
            MaSo = maSo;
            TenHang = tenHang;
            DonGia = donGia;
            Next = null;
        }
    }
}
