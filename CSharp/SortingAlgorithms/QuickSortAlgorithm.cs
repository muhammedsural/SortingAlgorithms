using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class QuickSortAlgorithm
    {




        /*
             Quik Sort
            Pivotu doğru seçme algoritmanın verimliliğini arttırıyor.
            Time Complexity
            Best Case -> O(n*logn) 2 tabanlı logtur burada
            Avg Case -> O(n*logn)
            Worst Case -> O(n^2)

            Space Complexity -> O(1)

            Pivot     : Bir arrayde sıraladığımızda da aynı lokasyonda olacak değerler sıralı değerlerdir. Bunlara pivot denir. Bu değere göre sağına büyükler soluna küçükler atılabilir.
            Partition : Seçilen pivotun yerini bulmak ve buna göre sağında büyük solunda küçükleri düzenlemek.
            Pivotu seçerken sol ve sağdaki veriler eşit olursa iyi olur.
            Sol ve sağdaki arraylere gene partition uygulamak.

            Partition için
                1- Hoare yöntemi
                    Bir arrayde yapılan hem soldan hem sağdan tarama yapılarak sıralamayı hedefler. İlk olarak bir pivot belirlenir sonrasında bu pivotun yerinin tespiti için soldan ondan küçük olanlarla sağdan ondan büyük olanlarla karşılaştırma yaparak ilerlenir ve bu soldan ve sağdan başlanarak yapılan ilerleme birbirini geçiyorsa pivotunyeri bulunur geçmiyorsa ilgili noktalardaki değerler yer değiştirilip tekrardan aynı işlem yapılarak pivotun yeri bulunur. Sonrasında düzenlenmiş arrayde pivot ve solundaki değerler için yeni bir pivot alınır ve tekrardan anlatılan algoritma yapılarak taki sıralanacak eleman kalmayana kadar sol taraftaki değerler sıralanır. Bu tekrarlama sağ taraf içinde yapılarak array sıralanmış olur.
    
                2- Lomuto yöntemi
                    Pivot dizinin en sonundaki eleman seçiliyor iki taramada baştan başlar. bunlara i ve j dersek i en son değişiklik yapılan yeri j de elemanlar içerisende dönmeyi temsil ediyor. j nin olduğu elemanı pivottan küçük eşitse yer değiştirilecek. Yer değiştirme işleminde i ve j deki değerler yer değiştirilir. j pivota geldiğinde i+1 ile pivot yer değiştirilir. i başlangıç değeri -1 j başlangıç değeri 0
         */

        public void QuickSortLomuto<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int partitionIndex = PartitionLomuto(array, low, high);
                QuickSortHoare(array, low, partitionIndex - 1);
                QuickSortHoare(array, partitionIndex + 1, high);
            }
        }

        public int PartitionLomuto<T>(T[] array, int low, int high) where T : IComparable
        {
            var pivot = array[high]; //pivota bir değer atanıyor burada high olarak verilen değer alınmış
            int i = low - 1; // i değişkeni için başlangıcın 1 eksiği indexi atanıyor.
            for (global::System.Int32 j = low; j < high; j++) //verilen lowdan high sınırına kadar j değişkeni döndürülüyor.
            {
                if (array[j].CompareTo(pivot) < 0)   //her j indexindeki değer için pivot olarak belirlediğimiz değerden küçükse
                {
                    i++;              //-1 den başladığımız için pivot yerini tutan i arttırılıyor
                    Swap(array, i, j); //i indexindeki değer ile j deki değer yer değiştiriliyor.
                }
            }

            Swap(array, i + 1, high); //Pivot yeri bulunduğu için i+1 değeri pivotun yeridir orası için swap yapılıyor.

            return i + 1; //Pivotun yerinin indexi gönderiliyor.
        }

        public void QuickSortHoare<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int partitionIndex = PartitionHoare(array, low, high);
                QuickSortHoare(array, low, partitionIndex);
                QuickSortHoare(array, partitionIndex + 1, high);
            }
        }


        public int PartitionHoare<T>(T[] array, int low, int high) where T : IComparable
        {
            var pivot = array[low]; //pivota bir değer atanıyor
            int i = low - 1;        //Soldan tarama için index
            int j = high + 1;       //Sağdan tarama için index
            while (true)
            {
                do
                {
                    i++;
                } while (array[i].CompareTo(pivot) < 0);

                do
                {
                    j--;
                } while (array[j].CompareTo(pivot) > 0);

                if (i >= j)
                {
                    return j;
                }

                Swap(array, i, j);
            }
        }

        public void Swap<T>(T[] array, int i, int j) { (array[i], array[j]) = (array[j], array[i]); }

    }
}
