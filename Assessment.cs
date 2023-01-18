using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_Code_Assessment
{
    public class Assessment
    {
        static void Main(string[] args)
        {
        }

        /**********************************************************************
         * Function: aboveBelow
         * 
         * Parameters: 
         *      list: an array of integers, unsorted 
         *      target: an integer
         *              
         * Returns:
         *      Dictionary containing two keys ("Above" and "Below") containing
         *      a count of values in the list which are greater than and less 
         *      than the given target, respectively
         * *******************************************************************/
        public static Dictionary<string, int> aboveBelow(int[] list, int target)
        {
            Dictionary<string, int> result = new Dictionary<string, int>()
            {
                { "Above", 0 },
                { "Below", 0 }
            };
            
            // Return if the list is null for whatever reason
            if (list == null) return result;

            // We're missing some contextual information that we need to craft a 
            // well-informed solution. Since we're getting an unsorted array, we
            // would need to sort it in order to take advantage of something like 
            // binary search. Generally speaking, Array.Sort in C# should approach 
            // loglinear time dependent upon the size of the dataset. This means that
            // we would, on average, take on an additional n log(n) time in overhead.
            // We could then implement a modified binary search to find the next lowest
            // value in the list and continue processing from there. But already, we've hit
            // a minimum of n log(n) + log(n) in terms of time complexity for this solution.

            // However, we could accomplish the same thing with a simple loop in linear time.
            // The question then is whether we will be repeating queries. For a single query 
            // or any number of queries less than log(n) where n = dataset size, the linear 
            // approach will still be more efficient. We also don't have any reason to assume
            // that we'll be presented with repeated queries and, on top of that, we're being 
            // passed a collection. Not a pointer to a collection. This assessment is language
            // agnostic, but not every language passes by reference. Given this information, 
            // it's probably safe to assume that we cannot guarantee that any modification we
            // make to the unsorted array will be preserved. Not without doing it in a 
            // heavy-handed fashion anyway. Besides, if we were going to do that, it would be 
            // significantly more performant to run the sort before making any queries rather than
            // during processing. 

            // Acting on the assumption that we will not see repeated queries, we will go
            // with the linear approach. 

            // Loop through the list of integers 
            foreach (int num in list)
            {
                // If the current value is below the target, increment "Below" count
                if (num < target)
                    result["Below"]++;
                // If the current value is above the target, increment "Above" count
                else if (num > target)
                    result["Above"]++;
            }

            return result;
        }

        /**********************************************************************
         * Function: stringRotation
         * 
         * Parameters: 
         *      original: a string to shift 
         *      rotationAmount: the shift amount 
         *              
         * Returns:
         *      A string representing the original string shifted to the right 
         *      by rotationAmount
         * *******************************************************************/
        public static string stringRotation(string original, int rotationAmount)
        {
            // Return if the string is empty or null, or if the rotation amount is not positive
            // (the instructions state this is an assumption, but we'll still account for this
            // case here).
            if (original == "" || original == null || rotationAmount < 0) return "";

            // Looping here is unnecessary. We know the rotation amount, but are bound
            // by the actual length of the string. It doesn't matter how big or small 
            // the rotation amount is - all that matters is which characters will be 
            // shifted to the front of the string. 

            // To figure out how many characters to shift to the front, just take the 
            // remainder of dividing the original string's length + the rotation amount
            // by the rotation amount. 

            // This will tell us how many characters are going to end up at the start.
            int wrappedChars = (original.Length + rotationAmount) % original.Length;

            // Split the original string into chunks, concatenate, and return.
            return (original.Substring(original.Length - wrappedChars) + original.Substring(0, original.Length - wrappedChars));
        }
    }
}
