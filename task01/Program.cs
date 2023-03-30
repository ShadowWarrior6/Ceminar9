//Задайте значения M и N. Напишите программу, которая выведет все
//чётные натуральные числа в промежутке от M до N с помощью рекурсии

Console.WriteLine("Введите число N");
int M = Convert.ToInt32(Console.ReadLine()!);
 Console.WriteLine("Введите число M");
int N = Convert.ToInt32(Console.ReadLine()!);

void Numbers(int M, int N)
{
    if (M>N)return;

    if(M%2==0)
    {
        Console.Write($" {M} ");

    }
     Numbers(M+1,N);

}
Numbers(M,N);