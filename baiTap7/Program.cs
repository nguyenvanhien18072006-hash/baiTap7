// Bai Tap Buoi 7

// Bài 1: In dãy số cơ bản
Console.WriteLine("=== In day so ===");
Console.Write("Nhap so nguyen duong n :");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i<=n)
{
    Console.WriteLine(i);
    i++;
}

// Bài 2: Tính tổng các số chẵn
Console.WriteLine("=== Tinh tong cac so chan ===");
int sum = 0;
int i = 2;
while (i<=100)
{
    sum+=i;
    i+=2;
}
Console.WriteLine($"Tong so chan : {sum}");

// Bài 3: Ép buộc nhập đúng dữ liệu
Console.WriteLine("=== Nhap dung so lieu ===");
double diem = 0;
do
{
    Console.Write($"Nhap diem : ");
    diem = double.Parse(Console.ReadLine());
    
} while (diem<0||diem>10);
Console.WriteLine($"Diem hop le  : {diem}");

// Bài 4: Đếm số lượng chữ số
Console.WriteLine("=== Dem so luong chu so ===");
Console.Write("Nhap n :");
int n=int.Parse(Console.ReadLine());
if (n == 0)
{
    Console.WriteLine("So chu so: 1");
}
else
{
    int count = 0;
    while (n > 0)
    {
        n /= 10;
        count++;
    }

    Console.WriteLine($"So chu so la  : {count}");
}
// Bài 5: Số đảo ngược
Console.WriteLine("=== So dao nguoc ===");
Console.Write("Nhap so nguyen duong n : ");
int n=int.Parse(Console.ReadLine());
int dao =0;
while (n>0)
{
    int digit = n % 10;
    dao = dao * 10 + digit;
    n /= 10;
}
Console.WriteLine($"So sau khi dao nguoc la  : {dao}");

// Bài 6: Trò chơi đoán số (Guess the Number)
Console.WriteLine("=== Tro choi doan so ===");
Random rd = new Random();
int secret = rd.Next(1, 101);
int guess = 0;
do
{
    Console.Write("Nhap so doan   : ");
    guess = int.Parse(Console.ReadLine());
    if (guess < secret)
    {
        Console.WriteLine("Qua thap");
    }
    else if (guess > secret)
    {
        Console.WriteLine("Qua cao");
    }
    else
    {
        Console.WriteLine("Chinh xac!");
    }
} while(guess!=secret);

// Bài 7: Tìm Ước chung lớn nhất (UCLN)
Console.WriteLine("=== Tim Uoc Chung Lon Nhat ===");
Console.Write("Nhap so nguyen duong a  : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Nhap so nguyen duong b : ");
int b=int.Parse(Console.ReadLine());
while (b!=0)
{
    int r = a%b;
    a = b;
    b = r;
    
}
Console.WriteLine($"Uoc chung lon nhat cua hai so la : {a} ");

// Bài 8: Phân tích ra thừa số nguyên tố
Console.WriteLine("=== Phan Tich  ===");
Console.Write("Nhap so nguyen duong n : ");
int n=int.Parse(Console.ReadLine());
int i =2;
bool first=true;
Console.WriteLine("KET QUA : ");
while (n>1)
{
    if (n % i == 0)
    {
        if (!first)
        {
            Console.Write(" x ");
        }
        Console.Write(i);
        first = false;
        n = n / i;
    }
    else
    {
        i++;
    }
}
// Bài 9: Dãy Fibonacci có giới hạn
Console.WriteLine("=== Day Fibonacci  ===");
Console.Write("Nhap gia tri Max :  ");
int max = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
Console.Write("Day Fibonacci ");
if (a<= max) Console.Write(a +" ");
if (b <= max) Console.Write(b +" ");
int c= a+b;
while (c<=max)
{
    Console.Write(c+" ");
    a=b;
    b=c;
    c=a+b;
}
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


    
