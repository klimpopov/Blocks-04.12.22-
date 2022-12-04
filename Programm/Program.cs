// Из имеющегося массива строк формирет массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно задать с клавиатуры, либо задать на старте выполнения алгоритма.   
// Пример: 
// ["hello", "2", "world", ":-)"] -> ["2",":-)"]

string[] array = { "hello", "2", "world", ":-)" };          //Вводимый массив
int symbolLength = 3;                                       // Ограничения по кол-вам символов
ArrayStringLength(array, symbolLength);

void ArrayStringLength (string[] array, int symbolLenght)   // Метод вывода массива строк с ограничением по длине
{
string symbols = "";
for (int i = 0; i < array.Length; i++)
{
    symbols = array[i];                                     //Запись во временную переменную значения i-элемента массива
    if (symbols.Length <= symbolLength)                     // Проверка длины элемента с ограничением
        Console.Write($"{array[i]} ");                      // Печать, если условие оказалось верным 
}
}