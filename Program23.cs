int number = ReadInt("Ввведите N :");
 for (int i = 1; i <= number; i++)
  {
    Console.WriteLine($"{i*i*i}");
  }
  int ReadInt(string message)
  {
    Console.WriteLine(message);
     return Convert.ToInt32(Console.ReadLine());
          }