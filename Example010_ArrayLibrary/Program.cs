void FillArray (int [] collection)
{
int length = collection.Length;
int index = 0;
while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
//void метод ничего не возвращает значение
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
    Console.WriteLine(col[position]);
    position++;
    }
}

int Index0f(int [] collection, int find) // в качестве аргумента приходит массив colection и элемент find
{
    int count = collection.Length; //определяем колиечтво элементов
    int index = 0; //потребуются индексы щелкать массивы с помощью переменной index
    //для этого создаем цикл while
    int position = -1; //определяем новую переменную , по умолчанию это будет 0, 
    //в которую будем ложить значение index. 
    //если не встречается ни одного элемента, то покажет -1
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int [10]; // new int [10] - это создали новый массив из 10 элементов, 
//по умолчанию он заполнен нулями,
//для того чтобы заполнить др.числами, воспользуемся методом void


FillArray(array); //метод заполнения массива
array[4] = 4;
array[6] = 4;

PrintArray(array); //метод печати массива на экран
Console.WriteLine ();

int pos = Index0f(array, 4444);
Console.WriteLine(pos);