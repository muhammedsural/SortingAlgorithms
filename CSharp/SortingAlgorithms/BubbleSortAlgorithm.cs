using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSortAlgorithm
    {
        

        //ICompareble dan türemiş bir nesne gönderilirse direk yapacaktır.
        public void BubbleSort2<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    //Comparer sınıfı generic çalışabilen ve gelen tipe göre karşılaştırma yapabilen bir kütüphane.
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        //(array[j], array[j + 1]) = (array[j + 1], array[j]);

                    }
                }
            }
        }


    }
}
