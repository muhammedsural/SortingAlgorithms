using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class HeapSortAlgorithm
    {

        /*
             Heap Sort

            1- Build max heap or min heap
            2- Heapify
            3- Extraction-Delete

            heap : Complete Binary Tree not full binary tree (2^n-1 eleman sayısı ise full tree)
            max heap -> parent > child
            min heap -> parent < child

            2-8-5-3-1

            insert = insert + heapify
            parent ile child karşılaştırılır child büyükse yer değiştirilir. Burada 2 8 den küçük olduğu için yer değiştirilerek yazılır
            insertion
                ağaç yüksekliği yani katman -> 3 katman

                            8
                    3             5                
                2       1           

            max_heap -> 8,3,5,2,1

            i-> index (index +1 aslında 0 danbaşlıyor çünkü indexler)
            parent index -> (i/2)+1 
            leftChild index -> 2*i + 1
            rightChild index -> 2*i + 1 + 1

            extraction;
                max heap te delete işlemi root node dan yapılır burası için 8, sonrasında ağacın en sonundaki elemanı yeni root olarak belirle burada 1 ve tekrardan heapify yap.

            1-3-5-2| 8

            max heap bozuldu heapfy yapılacak
            1-3-5-2| 8   --  5-3-1-2| 8  --       3-1-2| 5-8        --        3-2-1| 5-8       --       1-2| 3-5-8                   2-1| 3-5-8                 1|2-3-5-8        1-2-3-5-8          
                    1        heapfy       5       extraction            2       heapfy          3       extraction             1                        2                           1
                3       5    ====>      3    1   ==========>        3       1   ===>        2       1   ==========>        2       |3| heapfy       1      |3| extraction       2       3
            2      |8|                 2  8                    |5|     |8|              |5|     |8|                   |5|     |8|      ====>    |5|   |8|      ==========>  5       8
 
             Yukarıda algoritma gösterilmiştir..
 
             Algoritma Adımları
            1- max heap oluştur verilen arrayden bunun için heapfy uygula ve parent childları sırlansı
                heap : Complete Binary Tree not full binary tree
                        max heap -> parent > child
                a- ilk eleman root eleman olarak al
                b- sonra insert yap ve sonrasında heapify yap
            2- extraction yap ve root terimi ile array sonundaki terimi değiştir
            3- tekrardan heapify uygula
            4- tekrardan extraction yap
            5- elemanlar bitene kadar tekrarla
          */



        public void HeapSort<T>(T[] array) where T : IComparable
        {
            int length = array.Length;

            //Build Heap
            for (int i = length / 2 - 1; i > -1; i--)
                Heapify(array, length, i);

            // One by one extract an element from heap
            for (int i = length - 1; i > 0; i--)
            {
                (array[i], array[0]) = (array[0], array[i]);

                //Heapify root element
                Heapify(array, i, 0);
            }
        }

        public void Heapify<T>(T[] array, int length, int i) where T : IComparable
        {
            int largest = i;
            int leftChildIndex = 2 * i + 1;
            int rightChildIndex = 2 * i + 2;

            if (leftChildIndex < length && array[largest].CompareTo(array[leftChildIndex]) < 0 )  
            {
                largest = leftChildIndex;
            }

            if (rightChildIndex < length && array[largest].CompareTo(array[rightChildIndex]) < 0 )  
            {
                largest = rightChildIndex;
            }

            if (largest != i)
            {
                (array[i], array[largest]) = (array[largest], array[i]);
                Heapify(array,length,largest);
            }
        }
    }
}
