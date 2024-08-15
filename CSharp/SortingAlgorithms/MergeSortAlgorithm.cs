using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MergeSortAlgorithm
    {


        /*
         Merge Sort

        Performance
            Time Complexity -> O(n*logn) 2 tabanlı logtur burada
            Space Complexity -> O(n)

        Array en küçük elemanlarına ortadan böle böle katmanlı olacak şekilde ayrılır en küçük elemanlar karşılaştırıp sıralayarak birleştirilerek ana array tekrar oluşturulur.
        For Example
            array -> [3 4 7 1 9 6]
            2.Sub -> [3 4 7], [1 9 6]
            3.Sub -> [3 4], [7], [1 9], [6]
            4.Sub -> [3], [4], [7], [1], [9], [6]
            Merging her sub katmanı geriye dönük sıralama yapılarak birleştirilir.
                1.Merge -> [3,4], [7], [1 9], [6]
                2.Merge -> [3,4,7], [1 6 9]
                3.Merge -> [1 3 4 6 7 9]
        
         */


        public void MergeSort<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        public void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            T[] leftArray = new T[n1];
            T[] rightArray = new T[n2];

            Array.Copy(array, left, leftArray, 0, n1);
            Array.Copy(array, middle + 1, rightArray, 0, n2);

            int leftIndex = 0, rightIndex = 0;
            int k = left;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) <= 0)
                {
                    array[k] = leftArray[leftIndex];
                    leftIndex++;

                }
                else
                {
                    array[k] = rightArray[rightIndex];
                    rightIndex++;
                }
                k++;
            }

            while (leftIndex < n1)
            {
                array[k] = array[leftIndex];
                leftIndex++;
                k++;
            }

            while (rightIndex < n2)
            {
                array[k] = array[rightIndex];
                rightIndex++;
                k++;
            }
        }

    }
}
