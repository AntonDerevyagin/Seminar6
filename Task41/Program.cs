// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int numb = Convert.ToInt32(Console.ReadLine());
// int [] array = new int (numb);
// for  (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine()
// }

// void MethodRead(string message)
// {
//     do
//     {
//     Console.WriteLine("message");
//     string numb = Console.ReadLine();
//     while ( numb != "stop");
    
//     }
// }

// MethodRead("Введите число");

// string word;
// do
//     {
//     Console.WriteLine("Введите слово:");
//     word = Console.ReadLine();
    
// }
// while (word != "stop");



Console.WriteLine("Введите число");
int count = 0;

while (true)
{
  string numb = Console.ReadLine();
  if (numb == "stop")
  {
    break;
  }
  else if ((Convert.ToInt32(numb) > 0))
  {
    count++;
  }

}
Console.WriteLine(count);





