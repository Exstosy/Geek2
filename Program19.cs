Console.WriteLine("Введите пятизначное число ");
 string number = Console.ReadLine();
 int number2 = number.Length;
  if (number2 == 5)
  { 
      if(number[0] == number[4] && number[1] == number[3])
    {
      Console.WriteLine($"Палиндром");
    }
       else 
    {
     Console.WriteLine($"Не Палиндром"); 
    }
   }
 else
   {
     Console.WriteLine($"НЕ пятизначное");
        
   }
   {
    
  }
