public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary <int,int> FindComplement = new Dictionary <int,int>();

         for (int i = 0; i < nums.Length; i++)
         {
            int complement = target - nums[i];

            if (FindComplement.ContainsKey(complement))
            {
                return new int [] {FindComplement[complement], i} ;
            }
            FindComplement[nums[i]]= i;

         }return new int[] {};
        
    }
}