using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SamarAA.SprintReview.V15.Lib
{
    public class DataService
    {
        public int[,] GetRandomMatrix(ref int[,] array, int n1, int n2)
        {
            Random random = new Random();
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(n1, n2 + 1);
                }
            }

            /*for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1)+1; j++)
                {
                    if(j % 3 == 0 && array[i, j - 2] <= array[i, j - 1])
                    {
                        array[i, j - 1] = array[i, j - 2] * array[i, j - 2] - array[i, j - 1] * array[i, j - 1];
                    }
                    else
                    {
                        array[i, j - 1] = array[i, j - 1] * array[i, j - 1] - array[i, j - 2] * array[i, j - 2];
                    }
                }
            }*/
            /*for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 2; i < array.GetLength(1); j += 3)
                {
                    
                    int previous1 = array[i,j - 1];
                    int previous2 = array[i,j - 2];
                    int difference = previous1 * previous1 - previous2 * previous2;
                    array[i, j] = difference;
                    /*if (previous2 >= previous1)
                    {
                        int difference = previous2 * previous2 - previous1 * previous1;
                        array[i, j] = difference;
                    }
                    else
                    {
                        int difference = previous1 * previous1 - previous2 * previous2;
                        array[i, j] = difference;
                    }
                }
            }*/
            return array;
        }
        public int GetRes(int[,] array, int c, int k, int l)
        {
            int res = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 != 0 && i >= k && i <= l)
                {
                    res *= array[i, c];
                }
            }
            return res;
         
        }
    }
}
