/*Calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

Complete the function aVeryBigSum which takes 2 arguments, an integer n and a long integer array ar and returns a long integer denoting the sum of all array elements.
Raw Input Format

The first line of the input consists of an integer n. 
The next line contains n space-separated integers contained in the array.

Sample Input 0

5
1000000001 1000000002 1000000003 1000000004 1000000005
Sample Output 0

5000000015
Note:

The range of the 32-bit integer is -2^31 to 2&31 - 1
When we add several integer values, the resulting sum might exceed the above range. You might need to use long long int in C/C++ or long data type in Java to store such sums.
*/

//FINISHED IT IN 4 MIN


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    class Program
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            long ans = 0;
            for(int i = 0; i<ar.Length; i++)
            {
                ans += ar[i];
            }
            return ans;
        }

        static void Main(string[] args)
        {
            
            int n = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(n, ar);

            Console.WriteLine(result);
        }
    }
}
