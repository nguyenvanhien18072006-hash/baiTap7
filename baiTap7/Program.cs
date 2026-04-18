
// Bài 10: Xây dựng Menu điều hướng Console
int luachon;
do
{
    Console.WriteLine("=== Menu  ===");
    Console.WriteLine("1. Tinh Dien Tich Hinh Chu Nhat  ");
    Console.WriteLine("2. Tinh Dien Tich Hinh Tron  ");
    Console.WriteLine("3. Thoat ");
    Console.Write("Nhap lua chon : ");
    luachon = int.Parse(Console.ReadLine());
    switch (luachon)
    {
        case 1:
            Console.Write("Nhap chieu dai HCN : ");
            double dai = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong HCN : ");
            double rong = double.Parse(Console.ReadLine());
            double sHCN = dai * rong;
            Console.WriteLine($"Dien tich HCN = {sHCN} m2");
            break;
        case 2:
            Console.Write("Nhap ban kinh cua hinh tron :");
            double r = double.Parse(Console.ReadLine());

            double sHT = Math.PI * r * r;
            Console.WriteLine($"Dien tich HT = {sHT} m2");
            break;
        case 3:
            Console.WriteLine("Thoat chhuong trinh .....");
            break;
        default:
            Console.WriteLine("Lua chon khong hop le ");
            break;

    }
} while (luachon != 3);


    
