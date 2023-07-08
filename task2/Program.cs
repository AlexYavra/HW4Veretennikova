//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    string Readinput = System.Console.ReadLine();
    int result  = int.Parse(Readinput);
    return result;
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number = Prompt("введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");