

Console.WriteLine("Введите желаемую длину массива: ");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапозон чисел от и до");
Console.WriteLine("Введите число ОТ скольки: ");
int minValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число ДО скольки: ");
int maxValue = int.Parse(Console.ReadLine());


int[] array_create(int length, int minValue, int maxValue) {
    int[] result = new int[length];
    for (int i = 0; i < length; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] res = array_create(length, minValue, maxValue);

Console.WriteLine($"[{String.Join(", ", res)}]");