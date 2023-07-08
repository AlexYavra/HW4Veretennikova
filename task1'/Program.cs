// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Сделать через функции
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string massage)
{
    System.Console.Write(massage);
    string Readinput = System.Console.ReadLine();
    int result = int.Parse(Readinput);
    return result;
}
int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}
bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt ("Введите основание: ");
int exponent = Prompt ("Введите показатель: ");
if (ValidateExponent (exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
} 
