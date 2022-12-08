Console.Clear();
Console.Write("Введите длинну массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 
int count = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10); //[1, 9]
Console.WriteLine($"[{string.Join(", ", array)}]");

for (int z = 1; z < array.Length; z+=2)
    count = count + array[z]; 
   
Console.WriteLine($"всего {array.Length} чисел, сумма элементов cтоящих на нечётных позициях = {count}");
