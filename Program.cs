void ShowAnswer(int number)
{
    int first = (number/10000)-(number % 10);
    int second = ((number / 1000) % 10)-((number / 10) % 10);
    if (first == 0 && second == 0) {Console.WriteLine($"{number} -> Да");}
    else {Console.WriteLine($"{number} -> Нет");}
}


int GetNumber(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number = GetNumber("Введите число: ");
ShowAnswer(number);