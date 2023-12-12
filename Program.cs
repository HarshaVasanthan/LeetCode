namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = { 2, 5, 6 };
            //Solution sol = new Solution();
            //sol.Merge(nums1, 3, nums2, 3);

            //Console.WriteLine("Hello, World!");

            ListNode list = [1, 2, 4];


        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                ListNode node = null;
                //hello testing

                //this is change from test branch

                // change from master to test rebase
                if (list1 == null && list2 == null)
                {
                    return node;
                }
                else if (list1 == null)
                {
                    node = list2;
                }
                else if (list2 == null)
                {
                    node = list1;
                }
                else
                {
                    if (list1.val > list2.val)
                    {
                        node = list1;
                    }
                    else
                    {
                        node = list2;
                    }
                }
                return node;
            }
        }


                //public class Solution
                //{
                //    public void Merge(int[] nums1, int m, int[] nums2, int n)
                //    {

                //        int i = m - 1;
                //        int j = n - 1;
                //        int k = m + n - 1;

                //        while (j >= 0)
                //        {
                //            if (i >= 0 && nums1[i] > nums2[j])
                //            {
                //                nums1[k--] = nums1[i--];
                //            }
                //            else
                //            {
                //                nums1[k--] = nums2[j--];
                //            }
                //        }
                //    }
                //}

            }
}