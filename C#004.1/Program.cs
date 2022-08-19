Console.Write("Введите произвольное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int number)
{
    int length = Convert.ToString(number).Length;
    int j = 0;
    int res = 0;

    for (int i = 0; i < length; i++)
    {
      j = number - number % 10;
      res = res + (number - j);
      number = number / 10;
    }
    return res;
}
int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр: " + sumNumber);