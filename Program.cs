Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int Pow(int number1, int number2)
{
  int res = 1;
  for(int i=1; i <= number2; i++)
  {
    res = res * number1;
  }
  return res;
}
  int ResPow = Pow(number1, number2);
  Console.WriteLine("Ответ: " + ResPow);