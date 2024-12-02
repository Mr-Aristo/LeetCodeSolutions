namespace LeetCodeSolutions.Search;

public class BinarySearch
{

    public int Search<T>(IList<T> collection, T target) where T : IComparable<T>
    {
        int left = 0; // first index of collection 
        int right = collection.Count - 1;//last index of collection

        while (right >= left)
        {
            int middle = (right - left) / 2;

            int comperison = target.CompareTo(collection[middle]);

            if (comperison == 0)
                return middle;
            else if (comperison < 0)
                right = middle - 1; //target is left side
            else
                left = middle + 1; //taget is right side 

        }

        return -1; //target not founds
    }

}
/*
   Açıklamalar
   Generic Yapı: IList<T> kullanılarak hem List<T> hem de T[] desteklenir.
   Karşılaştırma: IComparable<T> kullanılarak elemanlar karşılaştırılır, bu sayede integer, string gibi farklı veri türleriyle kullanılabilir.
   Dizinin Sıralı Olması Gerekir: Binary search çalışabilmesi için giriş dizisinin önceden sıralanmış olması gerekir.
   Örnek Kullanım
   Dizi: BinarySearch(new int[] { 1, 2, 3 }, 2);
   Liste: BinarySearch(new List<int> { 1, 2, 3 }, 2);
    
    Ornek kullanim:

     static void Main(string[] args)
      {
          
          int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
          int target = 7;
      
          int index = BinarySearch(sortedArray, target);
          Console.WriteLine(index); // 3
      }

*/