namespace BinarySearch
{
    public static class BinarySearchExtension
    {
        /// <summary>
        /// a = arrya
        /// x = what we're seaching for
        /// p = first index
        /// q = midpoint
        /// r = last index
        /// </summary>
        public static int BinarySearch(this int[] a, int x) {
            var p = 0; //beginning 
            var r = a.Length -1; //end
            while(p <= r)
            {
                var q = (p + r)/2; //middle
                if (x < a[q])
                    r = q - 1; //set the end as the middle index minus 1
                else if (x > a[q])
                    p = q + 1; //set the beginning as the middle index plus 1
                else return q; //return the middle index if x is not greater than or less than the beginning and the end
            }
            return -1;
        }
    }
}
