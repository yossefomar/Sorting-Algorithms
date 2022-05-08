using System;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {9,8,7,6,5,4,3,2,1};
            int s = 0;
            int e = (arr.Length-1);
            MS(arr, s, e);
        }







        public static void MS(int[] A, int s, int e)
        {
            
            if (s== e)
            {
                return;
            }
            int mid = (s + e) / 2;
            MS(A, s, mid);
            MS(A, mid+1, e);
            M(A, s, mid, e);


        }
        public static void M(int[] A, int s, int mid, int e)
        {
            int[] left = new int[(mid+1) - s];
            int j = 0;
            for (int i = s; i <= mid; i++)
            {
                left[j] = A[i];
                j++;
            }

            //merging
            int pointer1 = mid+1;
            int pointer2 = 0;
            for (int i = s; i <=e; i++)
            {
                if (pointer1 > e)
                {
                    A[i] = left[pointer2];
                    pointer2++;
                }
                else if (pointer2 == left.Length)
                {
                    A[i] = A[pointer1];
                    pointer1++;
                }
                else if (A[pointer1] <= left[pointer2])
                {
                    A[i] = A[pointer1];
                    pointer1++;
                }
                else if (A[pointer1] > left[pointer2])
                {
                    A[i] = left[pointer2];
                    pointer2++;
                }
            }

            //return sorted array
        }
    }
}
