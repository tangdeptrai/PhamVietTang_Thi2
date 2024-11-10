using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class ProductBST
    {
            private Node root;

            public ProductBST()
            {
                root = null;
            }

            public void AddProduct(int maSo, string tenHang, int donGia)
            {
                root = AddProductRecursively(root, maSo, tenHang, donGia);
            }

            private Node AddProductRecursively(Node current, int maSo, string tenHang, int donGia)
            {
                if (current == null)
                {
                    Console.WriteLine("Thêm mặt hàng mới thành công!");
                    return new Node(maSo, tenHang, donGia);
                }

                if (maSo < current.MaSo)
                    current.Left = AddProductRecursively(current.Left, maSo, tenHang, donGia);
                else if (maSo > current.MaSo)
                    current.Right = AddProductRecursively(current.Right, maSo, tenHang, donGia);
                else
                    Console.WriteLine("Mã số mặt hàng đã tồn tại.");

                return current;
            }

            public void SearchProduct(int maSo)
            {
                Node node = SearchProductRecursively(root, maSo);
                if (node != null)
                {
                    Console.WriteLine($"Mặt hàng tìm thấy: Mã: {node.MaSo}, Tên: {node.TenHang}, Đơn giá: {node.DonGia}");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy mặt hàng.");
                }
            }

            private Node SearchProductRecursively(Node current, int maSo)
            {
                if (current == null) return null;

                if (maSo < current.MaSo)
                    return SearchProductRecursively(current.Left, maSo);
                else if (maSo > current.MaSo)
                    return SearchProductRecursively(current.Right, maSo);
                else
                    return current;
            }

            public LinkedList SaveToLinkedList()
            {
                LinkedList list = new LinkedList();
                SaveToLinkedListRecursively(root, list);
                return list;
            }

            private void SaveToLinkedListRecursively(Node current, LinkedList list)
            {
                if (current != null)
                {
                    SaveToLinkedListRecursively(current.Right, list);
                    list.AddToDescendingOrder(current.MaSo, current.TenHang, current.DonGia);
                    SaveToLinkedListRecursively(current.Left, list);
                }
            }
        }

    }

