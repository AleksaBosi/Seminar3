Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);

void Palindrom(int num)
{
    int count = 0;
    int temp = num;
    while (temp > 0)
    {
        temp = temp / 10;
        count++;
    }
    bool test = true;
    for (int i = 0; i < count / 2; i++)
    {
        int startPow = (int)Math.Pow(10, (count - 1 - i));
        int startDigit = num / startPow % 10;
        int endPow = (int)Math.Pow(10, i);
        int endDigit = num / endPow % 10;

        if (startDigit != endDigit)
        {
            Console.WriteLine("Данное число не является палиндромом");
            test = false;
            break;
        }

    }
    if (test == true) Console.WriteLine("Данное число является палиндромом");

}