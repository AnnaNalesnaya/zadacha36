// Задача 36: Задайте одномерный массив, 
//заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19 //-4, -6, 89, 6] -> 0 
int Prompt(string message)
{
    Console.ForegroundColor=ConsoleColor.White;
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int [] ArreyFill(int size)
{
    int i = 0;
    int [] arrey = new int [size];
    while (i<size)
    {
        arrey[i] = new Random().Next (-100, 100);
        i++;
    }
    return arrey;
}
void PrintArrey(int[] arrey)
{
    System.Console.Write("[");
    for (int i = 0; i < arrey.Length; i++)
    {
        System.Console.Write(arrey[i]);
        if (i < arrey.Length - 1)
        {
            System.Console.Write(" , ");
        }
    }
    System.Console.Write("]");
}
int EvendIndexNumSum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}
int sizeArray = Prompt("введите размер массива: ");
for (int i = 0; i < 4; i++)
{
    int[] newArray = ArreyFill(sizeArray);
    PrintArrey(newArray);
    System.Console.Write("-> ");
    System.Console.WriteLine(EvendIndexNumSum(newArray));

}
