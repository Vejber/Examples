// формула чисел Фибоначчи 
// f(1) = 1
// f(2) = 1
//f(n) = f(n-1)+f(n-2)

int Fibonacci(int n ) // вот тут double
{
    if(n == 1 || n ==2) return 1;
    else return Fibonacci(n-1)+(n-2);
}

for(int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}

//для больших чисел лучше испольщовать double