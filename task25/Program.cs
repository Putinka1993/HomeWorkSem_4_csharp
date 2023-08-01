Console.WriteLine("enter the number A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter the number B: ");
int b = int.Parse(Console.ReadLine()!);

int Exponentiate(int a, int b) {
    int m = a;
    for (int i = 1; i < b; i++)
        a *= m; 
    return a;
}

int res = Convert.ToInt32(Exponentiate(a, b));
Console.WriteLine($"Степень числа {a} и {b} равна {res}");