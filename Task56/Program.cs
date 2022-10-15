// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива, не равное числу строк");
int columnCount = int.Parse(Console.ReadLine());

int [,] array = FillArray (rowCount, columnCount, 1, 10);
PrintArray(array);

Console.WriteLine("Строка с наименьшей суммой элементов: " + GetRowMinSum(array) + " строка");

int [,] FillArray (int rows, int colunms, int min, int max){
    int [,] filledArray = new int[rows, colunms];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < colunms; j++){
            filledArray[i, j] = new Random().Next(min,max+1);
        }
    }
    return filledArray;
}

void PrintArray (int [,] inputArray){
    for(int i = 0; i < inputArray.GetLength(0); i++) {
        for(int j = 0; j < inputArray.GetLength(1); j++) {
        Console.Write(" " + inputArray[i, j]);
        }
Console.WriteLine();
    }
    
}

int GetRowMinSum (int [,] inputArray){
    int RowMinSum = 0;
    int IndexRowMinSum = 0;
    
    for (int k = 0; k < inputArray.GetLength(1); k++){
        RowMinSum += inputArray [0,k];
    }
    for(int i = 1; i < inputArray.GetLength(0); i++) {
                int RowSum = 0;
        
        for(int j = 0; j < inputArray.GetLength(1); j++) {
            RowSum += inputArray[i,j];
    }  
    if (RowSum < RowMinSum){
        RowMinSum = RowSum;
        IndexRowMinSum = i;
    }
        }
  return IndexRowMinSum;
}