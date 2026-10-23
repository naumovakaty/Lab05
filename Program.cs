int dayNumber = 6;

switch (dayNumber)
{
    case 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}


int score = 78;

switch (score)
{
    case >= 0 and < 50:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 50 and < 70:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 70 and < 85:
        Console.WriteLine("Хорошо");
        break;
    case >= 85 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный бал");
        break;
}