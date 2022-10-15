// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первого двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первого двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

Console.WriteLine("Первый массив");
int [,] array1 = FillArray (rowCount, columnCount, 1, 10);
PrintArray(array1);

Console.WriteLine("Второй массив");
int [,] array2 = FillArray (columnCount, rowCount, 1, 10);
PrintArray(array2);

int [,] ResultArray = MultiplyArrays(array1, array2);

Console.WriteLine("Результат");
PrintArray(ResultArray);

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

int[,] MultiplyArrays (int [,] inputArray1, int [,] inputArray2){
    int[,] ResultArray = new int[inputArray1.GetLength(0), inputArray2.GetLength(1)];

        for ( int i = 0; i < inputArray1.GetLength(0); i++)
        {
            for (int j = 0; j < inputArray2.GetLength(1); j++)
            {
                ResultArray[i, j] = 0;

                for (int k = 0; k < inputArray1.GetLength(1); k++)
                {
                    ResultArray[i, j] += inputArray1[i, k] * inputArray2[k, j];
                }
            }
        }

        return ResultArray;
}
     