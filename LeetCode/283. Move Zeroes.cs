Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1

CODE:

public class Solution {
    public void MoveZeroes(int[] nums) {
        int k = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=0){
                int temp = nums[i];
                nums[i] = nums[k];
                nums[k] = temp;
                k++;
            }
        }
    }
}

OUTPUT:

Runtime
1
ms
Beats
95.84%
