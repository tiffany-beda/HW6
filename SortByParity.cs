public class Solution4 {
    public int[] SortArrayByParity(int[] nums)
    {
        List<int> evens = new List<int>();
        List<int> odds = new List<int>();

        foreach (int num in nums)
        {
            if (num % 2 == 0)
                evens.Add(num); // Store even numbers
            else
                odds.Add(num); // Store odd numbers
        }

        evens.AddRange(odds); // Append odd numbers after even numbers
        return evens.ToArray();
    }
}
