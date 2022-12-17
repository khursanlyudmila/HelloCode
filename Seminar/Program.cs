Console.WriteLine("Введите число:");

string numberStr = Console.ReadLine() ?? "";// fsdfdsdsf, 1223423 "fsdfdsdsf", "1223423"
int number = int.Parse(numberStr);// "323" -> 323
if (number >=100 && number < 1000)
{
Console.WriteLine(number%10);
}
else
Console.WriteLine("Число не соответствует заданным параметрам");
