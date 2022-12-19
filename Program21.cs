 Console.Clear();
int n1 =  ReadInt("Введите координату X первой точки:");
int n2 =  ReadInt("Введите координату Y первой точки:");
int n3 =  ReadInt("Введите координату Z первой точки:");
int nr4 = ReadInt("Введите координату X второй точки:");
int nr5 = ReadInt("Введите координату Y второй точки:");
int nr6 = ReadInt("Введите координату Z второй точки:");
   int A = nr4 - n1;
   int B = nr5 - n2;
   int C = nr6 - n3;
double lenght = Math.Sqrt( A * A + B *B + C * C);
   Console.WriteLine($"Длина отрезка {lenght}");
   {}
int ReadInt(string message)
   
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
  
}