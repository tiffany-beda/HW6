public class Solution3 {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
       
        int i = m - 1; // Last valid number in nums1
        int j = n - 1; // Last valid number in nums2
        int k = m + n - 1; // Last position in nums1

        // Merge using a for loop
        for (; j >= 0; k--) // Loop until nums2 is fully merged
        {
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i]; // Move larger value to the end
                i--; // Move left in nums1
            }
            else
            {
                nums1[k] = nums2[j]; // Move nums2 value to the end
                j--; // Move left in nums2
            }
        }
    }
}