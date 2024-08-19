// namespace Demo
// {
//     class InHinhTamGiacCan
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Nhap vao chieu dai: ");
//             int chieuDai = Int32.Parse(Console.ReadLine()); 
//             int[,] a = new int[chieuDai - 1,chieuDai*2 - 2];
//             for(int i = 0; i < chieuDai; i++){
//                 for(int j = 0; j <= i; j++){
//                     a[i, chieuDai - j - 1] = 1;
//                     a[i, chieuDai + j - 1] = 1;
//                 } 
//             }
            
//         }
//     }
// }