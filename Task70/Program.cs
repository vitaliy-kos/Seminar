// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] arr, string sep = ",")
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"“{arr[i]}”{sep} ");
        else Console.Write($"“{arr[i]}”");
    }
    Console.WriteLine("]");
}

int GetArraySizeFromUser(string message)
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string GetUserInputString(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    return str;
}

string[] CreateAndFillArrayByUser(int arrSize)
{
    string[] arr = new string[arrSize];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetUserInputString($"Insert {i+1} value: ");
    }

    return arr;
}

string[] FilterArrayLessLengthElem(string[] inputArray, int strLength)
{
    string[] outputArray = new string[CountArrayLessLengthElem(inputArray, strLength)];

    for (int i = 0, j = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length <= strLength) {
            outputArray[j] = inputArray[i];
            j++;
        }
    }

    return outputArray;
}

int CountArrayLessLengthElem(string[] inpArr, int strLen)
{
    int count = 0;

    for(int i = 0; i < inpArr.Length; i++) {
        if(inpArr[i].Length <= strLen) {
            count++;
        }
    }

    return count;
}

int arraySize = GetArraySizeFromUser("Insert quantity elements in array: ");

string[] filledArray = CreateAndFillArrayByUser(arraySize);
Console.WriteLine("Inserted array: ");
PrintArray(filledArray);

string[] resultArray = FilterArrayLessLengthElem(filledArray, 3);
Console.WriteLine("Filtred array with values less then 3 signs: ");
PrintArray(resultArray);