// Преобразование десятичного числа в двоичное через строку


Console.WriteLine("Введите число");
int number10 = int.Parse(Console.ReadLine());
int number2;
string result = string.Empty;

for (; number10 > 0; number10 /= 2)
{
    number2 = number10%2;
    result = number2 + result;
}

Console.WriteLine(result);