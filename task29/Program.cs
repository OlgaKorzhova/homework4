// Программа задает массив из 8 элементов и выводит их на экран

int num = int.Parse(Console.ReadLine());
int [] array = new int[num];
for (int i = 0; i < num; i++)

{
    array[i] = new Random().Next(num + 1);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();
