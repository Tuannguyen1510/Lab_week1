internal class Program
{
    private static void Main(string[] args)
    {
        // Khai báo biến và nhập dữ liệu 
        Console.WriteLine("Nhap id nhan vien: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap ten nhan vien: ");
        string name = Console.ReadLine();
        Console.WriteLine("Nhap dia chi nhan vien: ");
        string address = Console.ReadLine();

        Console.WriteLine("Nhập ngày sinh (định dạng dd/MM/yyyy): ");
        DateTime birthday;
        // Sử dụng DateTime.TryParse để kiểm tra tính hợp lệ của ngày sinh nhập vào
        while (!DateTime.TryParse(Console.ReadLine(), out birthday) || birthday > DateTime.Now)
        {
            Console.WriteLine("Ngày sinh không hợp lệ. Vui lòng nhập lại (định dạng dd/MM/yyyy) và nhỏ hơn hiện tại");
        }
        Console.WriteLine("Nhap luong cua nhan vien: ");
        int Salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap tien thuong cua nhan vien: ");
        int Bonus  = Convert.ToInt32(Console.ReadLine());
        int TotalSalary = Salary + Bonus;


        Console.WriteLine("-------------Hiển thị thông tin của nhân viên----------------");
        Console.WriteLine("id : {0} , name: {1} , address: {2} ,  birthday: {3} , Salary: {4} , Bonus : {5} , TotalSalary: {6}", id, name,address,birthday.ToShortDateString(), Salary,Bonus, TotalSalary);
    }
}