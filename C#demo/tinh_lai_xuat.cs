// namespace Demo
// {
//     class TinhLaiSuat
//     {
//         static void Main(string[] args)
//         {
//             double money = 1.0;
//             int month = 1;
//             double intersetRate = 1.0;
//             Console.WriteLine("Enter investment amount: ");
//             money = Double.Parse(Console.ReadLine());
//             Console.WriteLine("Enter annual interest rate in percentage: ");
//             intersetRate = Double.Parse(Console.ReadLine());
//             Console.WriteLine("Enter annual interest rate in percentage: ");
//             intersetRate = Double.Parse(Console.ReadLine());
//             double totalInterset = 0;
//             for (int i = 0; i < month; i++)
//             {
//                 totalInterset += money * (intersetRate / 100) / 12;
//             }
//             Console.WriteLine("Total of interset: " + totalInterset);
//         }
//     }
// }