 //Напишите программу
 // которая на вход принимает два числа и выдаёт:
 //1. какое число большее 
 //2. какое меньшее

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
//1. ввести первое число
//2. ввести второе число
//3. сравнить эти числа 


 Console.WriteLine("Введите первое число: ");

  int number_A = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите второе число: ");
  int number_B = Convert.ToInt32(Console.ReadLine());

 if (number_A > number_B)
            {
                Console.WriteLine("Первое число " + number_A + " больше чем второе " + number_B);
            }
            else
            {
                Console.WriteLine("Второе число " + number_B + " больше чем первое " + number_A);
            }