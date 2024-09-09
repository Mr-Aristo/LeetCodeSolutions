using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    /*Given an array of intervals where intervals[i] = [starti, endi],
     * merge all overlapping intervals, and return an array of the non-overlapping 
     * intervals that cover all the intervals in the input.
    Example 1:
        Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
        Output: [[1,6],[8,10],[15,18]]
        Explanation: Since intervals [1,3] and [2,6] overlap, merge them into [1,6].

     */
    public static class MergeIntervals //56. leetcode
    {

        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
            {
                return new int[0][];
            }

            // 1. Intervallerı başlangıç noktasına göre sıral
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

            // 2. Birleştirilmiş aralıkları tutacak bir liste oluştur
            List<int[]> mergedIntervals = new List<int[]>();

            // 3. İlk aralığı ele al
            int[] currentInterval = intervals[0];
            mergedIntervals.Add(currentInterval);

            // 4. Aralıkları dolaş
            foreach (int[] interval in intervals)
            {
                int currentEnd = currentInterval[1];
                int nextStart = interval[0];
                int nextEnd = interval[1];

                // 5. Aralıklar örtüşüyor mu kontrol et
                if (currentEnd >= nextStart)
                {
                    currentInterval[1] = Math.Max(currentEnd, nextEnd);
                }
                else
                {
                    // Örtüşmüyorsa, currentInterval'ı güncelle
                    currentInterval = interval;
                    mergedIntervals.Add(currentInterval);
                }
            }

            return mergedIntervals.ToArray();
        }
    }

    /*
     * Zaman aralıklarının nasıl örtüştüğünü anlamak için verilen aralıkların başlangıç (start) ve bitiş (end) noktalarını incelememiz gerekir. 
     * İki zaman aralığı birbirine şu şekilde örtüşebilir:
        Örtüşme Durumu
        İki aralık [start1, end1] ve [start2, end2] verilmiş olsun. Bu iki aralık şu durumlarda örtüşür:

            Aralığın Başlangıcı, Diğer Aralığın İçinde Yer Alıyorsa:
                [start1, end1] aralığının başlangıç noktası (start1), diğer aralığın ([start2, end2]) herhangi bir yerinde yer alıyorsa (start2 <= start1 <= end2).
                Ya da, [start2, end2] aralığının başlangıç noktası (start2), birinci aralığın ([start1, end1]) herhangi bir yerinde yer alıyorsa (start1 <= start2 <= end1).

            Aralığın Sonu, Diğer Aralığın İçinde Yer Alıyorsa:
                Birinci aralığın son noktası (end1), ikinci aralığın başlangıç noktasından daha sonra veya aynı zamanda bitiyorsa (start2 <= end1 <= end2).
                Ya da, ikinci aralığın son noktası (end2), birinci aralığın başlangıç noktasından daha sonra veya aynı zamanda bitiyorsa (start1 <= end2 <= end1).

        Örtüşme Örnekleri
            Örnek 1: Kısmi Örtüşme

                Aralıklar: [1, 5] ve [4, 8]
                Durum: 4 değeri, [1, 5] aralığında yer aldığı için bu iki aralık örtüşür.
                Birleşmiş Aralık: [1, 8]
                    Çünkü, en erken başlama noktası 1, en geç bitiş noktası ise 8.*/
}
