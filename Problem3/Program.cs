// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;  //Сказано ведь от одного в любом случае
if (N<0)    //но не сказано, что число обязательно будет положительным
{
    while (i > N-1)
    {
        System.Console.Write(Math.Pow(i,3)+ " ");
        i--;
    }
} 
else
{
    while (i < N+1)
    {
        System.Console.Write(Math.Pow(i,3)+ " ");
        i++;
    }
}