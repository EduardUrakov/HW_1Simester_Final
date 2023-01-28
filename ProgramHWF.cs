void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Please input a number of items: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Please input a {i + 1} of elements: ");
    var txt = Convert.ToString(Console.ReadLine());
    array[i] = txt;
}

string[] FindIndex(string[] array)
{
    string[] newArray = new string[size];
    int indx = 3;
    int z = 0;
    for (int j = 0; j < size; j++)
    {
        if(array[j].Length <= indx)
        {
            newArray[z] = array[j];
            z++;
        }
    }
return newArray;
}

string[] myArray = FindIndex(array);

Console.WriteLine();
Console.Write("Inputs array:[ ");
ShowArray(array);
Console.Write("]");

Console.WriteLine();
Console.Write("New array:[ ");
ShowArray(myArray);
Console.Write("]");
