Random rnd = new Random();
int number = rnd.Next(1,10);

Console.Write("Введите число от 1 до 10: ");
for (int i = 0; i < 100; i++)
{
    try
    {
        int ur_number = int.Parse(Console.ReadLine());

        if (ur_number <= 0 || ur_number > 10)
        {
            Console.Write("Введите число от 1 до 10: ");
        }
        else if (ur_number != number)
        {
            Console.Write("Вы не угадали число! Попробуйте еще раз: ");
            continue;
        }
        else if (ur_number == number)
        {
            Console.WriteLine($"Вы угадали число! {number}");
            break;
        }
    }
    catch
    {
        Console.WriteLine("Введите число, а не буквы: ");
        continue;
    }
}