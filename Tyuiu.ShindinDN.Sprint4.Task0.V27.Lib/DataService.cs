﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShindinDN.Sprint4.Task0.V27.Lib
{
    public class DataService : ISprint4Task0V27
    {
        public int GetMultOddArrEl(int[] array)
        {
            int x = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    x *= array[i] ;
                }
            }
            return x;
        }
    }
}
