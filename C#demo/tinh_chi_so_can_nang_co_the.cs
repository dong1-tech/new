namespace Demo{
    class BMI{
        static void Main(string[] args){
            float weight, height, BMI;
            Console.Write("Nhap vao can nang: ");
            weight = float.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu cao: ");
            height = float.Parse(Console.ReadLine());
            BMI = weight/height;
            if(BMI < 18.5){
                Console.WriteLine("Underweight");
            }else if(BMI < 25){
                Console.WriteLine("Normal");
            }else if(BMI <30){
                Console.WriteLine("Overweight");
            }else{
                Console.WriteLine("Obese");
            }
            
        }
    }
}
