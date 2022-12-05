
void ShowArray(string[] array) // Метод вывода массива
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FillArray(string [] array, int length) //Метод заполнения массива с клавиатуры
{
    Console.WriteLine("Enter element of array on a new line!");
    for (int i = 0; i < length; i++)
        array[i] = Console.ReadLine();  
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Array filling!");
Console.WriteLine("How many elements are in the array?");
int size = Convert.ToInt32(Console.ReadLine());
string [] initialArray = new string [size];

FillArray(initialArray,size);

Console.Write("Initial array: ");
ShowArray(initialArray);

int count = 0;
for (int i = 0; i < size; i++)
   if(initialArray[i].Length <= 3)  count++;
string [] finalArray = new string [count];

int k = 0, j = 0;
while ( k < size)
{
    if(initialArray[k].Length <= 3)
    {
        finalArray[j] = initialArray[k];
        j++;
    }
    k++;
}
Console.Write("Final array: ");
ShowArray(finalArray);