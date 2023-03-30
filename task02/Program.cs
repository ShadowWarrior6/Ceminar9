Console.WriteLine("введите число M");
int M=Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine()!);

int Sum(int M,int N)
{
    if (M==N)return N;
    else return M + Sum(M + 1, N);
}
Console.Write($" {Sum(M,N)} ");
