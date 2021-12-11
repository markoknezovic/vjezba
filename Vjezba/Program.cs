using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    class Search
    {
        public int BinarySearch(int[] arr, int k)
        {
            int i = 0, a = arr.Length - 1;
            while (i <= a)
            {
                int n = i + (a - i) / 2;
                if (arr[n] == k)
                    return n;
                if (arr[n] < k)
                    i = n + 1;
                else
                    a = n - 1;
            }
            return -1;
        }
    }
    class KlasaC
    
    {
        public int Zbroj(int[] Brojevi)
        {
           return Brojevi.Sum();
        }
        public double Prosjek(int[] Brojevi)
        {
           return Brojevi.Average();
        }
    }
    class KlasaB
    {
        public string BezPrvogIZadnjeg(string Recenica)
        {
           return Recenica.Substring(1, Recenica.Length - 2);
        }
    }
    class Sort
    {
        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        public void QuickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
    }
    



}
