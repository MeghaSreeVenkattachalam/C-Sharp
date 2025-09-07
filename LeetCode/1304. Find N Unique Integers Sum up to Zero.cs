Given an integer n, return any array containing n unique integers such that they add up to 0.

 

Example 1:

Input: n = 5
Output: [-7,-1,1,3,4]
Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
Example 2:

Input: n = 3
Output: [-1,0,1]
Example 3:

Input: n = 1
Output: [0]
 

Constraints:

1 <= n <= 1000
 


CODE:

public class Solution {
    public int[] SumZero(int n) {
        int[] s=new int[n];
        int r=-(n/2);
        for(int i=0;i<n;i++)
        {
            s[i]=r;
            r++;
            if(n%2==0&&r==0)
                r++;

        }
    return s;
    }
}

OUTPUT:

Runtime
0
ms
Beats
100.00%
