using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class LinkedList
    {
        private LinkedListNode head;

        public LinkedList()
        {
            head = null;
        }

        public void AddToDescendingOrder(int maSo, string tenHang, int donGia)
        {
            LinkedListNode newNode = new LinkedListNode(maSo, tenHang, donGia);

            if (head == null || head.MaSo < maSo)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                LinkedListNode current = head;
                while (current.Next != null && current.Next.MaSo >= maSo)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void DisplayItems()
        {
            LinkedListNode current = head;
            while (current != null)
            {
                Console.WriteLine($"Mã: {current.MaSo}, Tên: {current.TenHang}, Đơn giá: {current.DonGia}");
                current = current.Next;
            }
        }
    }
}
