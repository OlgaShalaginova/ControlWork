Console.Clear();
Console.Write("Введите количество элементов массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int count = 0;
string[] massive = new string[lenght];
FillArray(massive);
Console.WriteLine("Первоначальный массив: ");
PrintArray(massive);
string[] massive2 = new string[count];
FillSecondArrayWithIF(massive, massive2);
Console.WriteLine("Массив с элементами, длина которых меньше либо равна 3 символам: ");
PrintArray(massive2);

void FillArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"Введите {i+1}-й элемент массива: ");
                    array[i] = Console.ReadLine();
                    if (massive[i].Length <= 3)
                    count++;
                }
            }

void PrintArray(string[] array)
            {
                Console.Write("[ ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine("]");
            }

void FillSecondArrayWithIF(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
      if(array1[i].Length <= 3)
         {
          array2[i] = array1[i];
         }
    }
}

