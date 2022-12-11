Console.Clear();
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 10); //[1, 9]
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
            max = array[z];
    if (array[z] < min)
            min = array[z];
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между значениями = {max - min}");