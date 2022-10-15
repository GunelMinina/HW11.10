// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int [,] array = FillArray (rowCount, columnCount, 1, 10);
PrintArray(array);

int [,] SortedArray = SortArray(array);

Console.WriteLine("Отсортированный массив");
PrintArray(SortedArray);

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

int[,] SortArray (int [,] inputArray){
     
    for(int i = 0; i < inputArray.GetLength(0); i++) {
        
        for(int j = 0; j < inputArray.GetLength(1); j++) {
            int maxPosition = j;
for (int k = j+1; k < inputArray.GetLength(1); k++)
{
if(array[i,k] > inputArray[i,maxPosition])
{
maxPosition = k;
}
}
int temporary = inputArray[i,j];
inputArray[i,j] = inputArray[i,maxPosition];
inputArray[i,maxPosition] = temporary;
    }  
        }
  return inputArray;
}