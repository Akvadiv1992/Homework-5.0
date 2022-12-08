Console.Clear();
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 
int count = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int z = 0; z < array.Length; z++)
{
    if (array[z] % 2 == 0)
    count++;
}
Console.WriteLine($"Из {array.Length} чисел, {count} четные. {array.Length - count} не четные");