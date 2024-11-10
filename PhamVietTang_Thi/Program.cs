// See https://aka.ms/new-console-template for more information

//23DH113104_PhamVietTang

using PhamVietTang_Thi;
using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        ProductBST productBST = new ProductBST();
        int choice;

        do
        {
            Console.WriteLine("\n--- Quản lý danh sách hàng hóa ---");
            Console.WriteLine("1. Thêm mặt hàng mới");
            Console.WriteLine("2. Tìm kiếm mặt hàng");
            Console.WriteLine("3. Lưu tất cả mặt hàng vào danh sách liên kết và in ra");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn của bạn: ");

            // Sử dụng TryParse để tránh lỗi khi người dùng nhập không phải là số
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    try
                    {
                        Console.Write("Nhập mã số mặt hàng: ");
                        int maSo = int.Parse(Console.ReadLine());
                        Console.Write("Nhập tên hàng: ");
                        string tenHang = Console.ReadLine();
                        Console.Write("Nhập đơn giá: ");
                        int donGia = int.Parse(Console.ReadLine());

                        productBST.AddProduct(maSo, tenHang, donGia);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ, vui lòng nhập lại.");
                    }
                    break;

                case 2:
                    try
                    {
                        Console.Write("Nhập mã số mặt hàng cần tìm kiếm: ");
                        int searchMaSo = int.Parse(Console.ReadLine());
                        productBST.SearchProduct(searchMaSo);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Dữ liệu không hợp lệ, vui lòng nhập lại.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Danh sách mặt hàng theo thứ tự giảm dần:");
                    LinkedList list = productBST.SaveToLinkedList();
                    list.DisplayItems();
                    break;

                case 0:
                    Console.WriteLine("Thoát chương trình.");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        } while (choice != 0);
    }
}

