//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите число < 1000");
int number = Convert.ToInt32(Console.ReadLine());


if (number>=100)
{
    System.Console.WriteLine(number%10);
}
else
{
    System.Console.WriteLine("error");

}


