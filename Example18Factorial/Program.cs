// рекурсия которая помогает вычислить факториал

int Factorial(int n)
{
    if (n == 1) return 1; //опредение факториала
    else return n* Factorial(n -1);
}

Console.WriteLine(Factorial(5));

//чтобы вычислить факториал больших чисел может произойти переполнение
//типа int, тогда его можно заменить на тип double