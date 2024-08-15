﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSortAlgorithm
    {


        //Time Complexity -> O(n^2) Zaman açısından kötü çünkü büyük arraylerde maliyet geometrik olarak artıyor.
        //Space Complexity -> O(1)
        public void SelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }
                var temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;

            }
        }
    }
}
