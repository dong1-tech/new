namespace Demo
{
    class GiaiPhuongTrinhBacNhat
    {
        static void Main(string[] args)
        {
            float a, b, x;
            Console.Write("Nhap vao a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao b: ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                x = - b / a;
                Console.WriteLine("Nghiem cua phuong trinh la: " + x);
            }
        }
    }
}

