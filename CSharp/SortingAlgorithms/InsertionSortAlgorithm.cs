using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSortAlgorithm
    {


        //Time Complexity -> O(n^2) Zaman açısından kötü çünkü büyük arraylerde maliyet geometrik olarak artıyor.
        //Space Complexity -> O(1)

        //Büyük olanı var olanın arasına ekleme yöntemiyle sıralar.
        public void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                T key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = key;
            }
        }
    }
}
