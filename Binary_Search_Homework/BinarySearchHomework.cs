using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Homework // don't edit this line!!!
{
    public class BinarySearchHomework // don't edit this line!!!
    {
        public static int TernarySearch(int[] arr, int key, int start, int end) // don't edit this line!!!
                                                                                // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                                // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                                // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: write code for the ternary search algorithm and return the index of the element
            if (end >= start)
            {
                int mid1 = start + (end - start) / 3;
                int mid2 = end - (end - start) / 3;

                if (arr[mid1] == key)
                {
                    return mid1;
                }
                if (arr[mid2] == key)
                {
                    return mid2;
                }

                if (key < arr[mid1])
                {
                    return TernarySearch(arr, key, start, mid1 - 1);
                }
                else if (key > arr[mid2])
                {
                    return TernarySearch(arr, key, mid2 + 1, end);
                }
                else
                {
                    return TernarySearch(arr, key, mid1 + 1, mid2 - 1);
                }
            }
                return -1;
        }

        public static int BinarySearchForCalculatingRepeated
            (int[] arr, int key, bool is_first, int start, int end) // don't edit this line!!!
                                                                    // يمكنك تجاهل برمترات البداية والنهاية إذا لا تريد استخدام الطريقة العودية 
                                                                    // لكن لاتقوم بحذفهم أو التعديل عليهم هنا تحت اي ظرف!!!
                                                                    // من الممكن تمرير قيمة 0 لتجاهلهم
        {
            //TODO: this methods is for getting the first accurence of the key and the last accurance
            int mid = (start + end) / 2;
        
            if (start <= end)
            {
                if (arr[mid] == key)
                {
                    if (mid != 0 && mid != arr.Length - 1)
                    {
                        if (arr[mid - 1] == key && is_first == true)
                        {
                            if (arr[mid - 2] == key)
                            {
                                if (arr[mid - 3] == key)
                                {
                                    return (mid - 3);
                                }
                                return (mid - 2);
                            }
                            return (mid - 1);
                        }
                        if (arr[mid + 1] == key && is_first == false)
                        {
                            if (arr[mid + 2] == key)
                            {
                                if (arr[mid + 3] == key )
                                {
                                    return (mid + 3);
                                }
                                return (mid + 2);
                            }
                            return (mid + 1);
                        }
                    }
                    return mid;
                }
                if (arr[mid] > key)
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, start, mid - 1);
                }
                if (arr[mid] < key)
                {
                    return BinarySearchForCalculatingRepeated(arr, key, is_first, mid + 1, end);
                }
            }
            return -1; 
        }

        public static int GetRepeatCount(int[] arr, int key) // don't edit this line!!!
        {
            //TODO: write code to calculate the repeat count of a spacific element
            // make sure to use the previous method in this method
            if (BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length-1) != -1)
            {
                int x = BinarySearchForCalculatingRepeated(arr, key, true, 0, arr.Length-1);
                int y= BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length-1);
                return (y - x)+1;
            }
            return 0;

        }
    }
}
