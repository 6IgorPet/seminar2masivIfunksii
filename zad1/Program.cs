//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
System.Console.WriteLine("трёхзначное число инажмите enter");
while(true)
{
    string input = Console.ReadLine();
    if(!input.Equals("exit"))
    Console.WriteLine("{0}->{1}",input, input[1]);
     else
     break;
}



