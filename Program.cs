int dayNumber = 3;
Console.WriteLine($"При dayNumber = {dayNumber}:");
switch (dayNumber)
{
    case 5 or 6 or 7: 
        Console.WriteLine("Выходной");
        break;
    default: 
        Console.WriteLine("Будний"); 
        break;
}

int score = 78;

switch (score)
{
    case >= 0 and < 40:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 60:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 80:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}
int temperature = 20;

string category = temperature switch {
    >= 35 => "Очень жарко",
    >= 25 => "Жарко",
    >= 15 => "Комфортно",
    >= 0 => "Прохладно",
    _ => "Мороз"
};

Console.WriteLine($"Температура {temperature}°C: {category}");
