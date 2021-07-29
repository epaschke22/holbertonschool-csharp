using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Returns biggest number in a list</summary>
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0) {
                return 0;
            }
            int biggest = nums[0];
            for (int i = 0; i < nums.Count; i++) {
                if (nums[i] > biggest) {
                    biggest = nums[i];
                }
            }
            return biggest;
        }
    }
}
