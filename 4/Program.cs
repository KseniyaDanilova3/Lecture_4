// Рекурсия

//факториал 3

// int Factorial(int n)
// {
              // 1! = 1
              // 0! = 1
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6


// факториал 39

// int Factorial(int n) (идет переполнение) int меняем на double
double Factorial(int n)

{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial(i)}");
}