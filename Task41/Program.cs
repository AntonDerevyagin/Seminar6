// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


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
Console.WriteLine($"Количество чисел > 0 = ({count}) ");





