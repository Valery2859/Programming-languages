﻿using System;
string[,] matrix = {{"|"," "," "," "," "," "," "},
                 {"|"," "," "," "," "," "," "},
                 {"|"," "," "," "," "," "," "},
                 {"|"," "," ","@"," "," "," "},
                 {"|"," "," "," "," "," "," "},
                 {"|"," "," "," "," "," "," "},
                 {"|"," "," "," "," "," "," "}};
int row = 3;
int column = 3;
int oldRow = 0;
int oldColumn = 0;
while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    matrix[row, column] = " ";
    oldRow = row;
    oldColumn = column;
    if (key.Key == ConsoleKey.W) row--;
    if (key.Key == ConsoleKey.S) row++;
    if (key.Key == ConsoleKey.A) column--;
    if (key.Key == ConsoleKey.D) column++;

    if (row > matrix.GetLength(0) - 1) row = matrix.GetLength(0) - 1;
    if (row < 0) row = 0;

    if (column > matrix.GetLength(1) - 1) column = matrix.GetLength(1) - 1;
    if (column < 0) column = 0;
    matrix[row, column] = "@";
    WriteMatrix(matrix);
}
static void WriteMatrix(string[,]matrix)
{
    Console.Clear();
    for(int i = 0;i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+ " ");
        }
        Console.WriteLine();
    }
}