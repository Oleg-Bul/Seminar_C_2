
//int[] numbers = new int[10];
//int[] a = {1,34,3423,2342,0,23,53,534};
//Console.WriteLine(a[2]);
// 1 - что мы хотим получить..(void - ничего, int - число, int[] - числовой массив)
// 2 - название функции - (может быть любым)
// 3 - что мы хоти отдать 
int[] CreaterArrayNumber(int size)
{
    int[] array = new int[size];// создаем массив задавая размер через size
    for (int i = 0; i < size; i++)//заполняем массив
    {
        array[i] = i+1;
    }    
    return array;  // отдаем массив  
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }
}
int [] numbers = CreaterArrayNumber(10);
WriteArray(numbers);



