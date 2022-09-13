/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] array = new int[2, 2, 2];


void FillAndPrintArray(int[,,] massiv)
{
    for (int i = 0; i < massiv.GetLength(2); i++)
    {
        for (int j = 0; j < massiv.GetLength(0); j++)
        {
            for (int g = 0; g < massiv.GetLength(1); g++)
            {
                int temp = new Random().Next(10, 100);
                massiv[j, g, i] = temp;
                for (int k = 0; k < g; k++)
                {
                    if (massiv[j, g - 1, i] == temp)
                    {
                        g--;
                        break;
                    }
                    if (massiv[j, g - 1, i] != temp) k++;
                }
                Console.Write($"{massiv[j, g, i]}({j},{g},{i})");
            }
            Console.Write("\n");
        }
    }
}

FillAndPrintArray(array);