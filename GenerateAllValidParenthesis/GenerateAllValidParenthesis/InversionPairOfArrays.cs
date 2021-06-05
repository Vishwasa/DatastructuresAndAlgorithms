using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAllValidParenthesis
{
    public static class InversionPairOfArrays
    {
        //public static int InversionPairCount = 0;
        public static int solve(List<int> A)
        {
            int right = A.Count();
			int[] temp = new int[right];
			return _mergeSort(A.ToArray(), temp, 0, right - 1);
        }

		static int _mergeSort(int[] arr, int[] temp, int left, int right)
		{
			int mid, inv_count = 0;
			if (right > left)
			{
				mid = (right + left) / 2;
				inv_count += _mergeSort(arr, temp, left, mid);
				inv_count
					+= _mergeSort(arr, temp, mid + 1, right);
				inv_count
					+= merge(arr, temp, left, mid + 1, right);
			}
			return inv_count;
		}

		static int merge(int[] arr, int[] temp, int left, int mid, int right)
		{
			int i, j, k;
			int inv_count = 0;

			i = left; 
			j = mid; 
			k = left;
			while ((i <= mid - 1) && (j <= right))
			{
				if (arr[i] <= arr[j])
				{
					temp[k++] = arr[i++];
				}
				else
				{
					temp[k++] = arr[j++];
					inv_count = inv_count + (mid - i);
				}
			}
			while (i <= mid - 1)
				temp[k++] = arr[i++];

			while (j <= right)
				temp[k++] = arr[j++];

			for (i = left; i <= right; i++)
				arr[i] = temp[i];

			return inv_count;
		}

	}
}
