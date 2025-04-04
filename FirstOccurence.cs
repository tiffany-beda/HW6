public class Solution {
    public int StrStr(string haystack, string needle) 
    {
        // If needle is empty, return 0 (as per problem definition)
        if (needle.Length == 0) return 0;

        // Iterate through 'haystack' up to the last possible starting position
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            // Extract substring of the same length as 'needle' and compare
            if (haystack.Substring(i, needle.Length) == needle)
                return i; // Found first occurrence, return index
        }

        // If not found, return -1
        return -1;
    }
    }
