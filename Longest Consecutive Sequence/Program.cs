using System;
using System.Collections.Generic;

namespace Longest_Consecutive_Sequence
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      var nums = new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };
      var answer = s.LongestConsecutive(nums);
      Console.WriteLine(answer);
    }
  }

  public class Solution
  {
    public int LongestConsecutive(int[] nums)
    {
      int res = 0;
      var hash = new HashSet<int>(nums);
      foreach (var current in nums)
      {
        // check current - 1 element is present ?
        int oneLess = current - 1;
        // if not then current no is the smallest starting
        if (!hash.Contains(oneLess))
        {
          // check the next is present ?
          int next = current + 1;
          // set the current longest as 1 as we took cuurent as our starting
          int currentLongest = 1;
          // if the next is present ?
          while (hash.Contains(next))
          {
            // set next as +1
            next += 1;
            // increment the current longest count
            currentLongest += 1;
          }
          // update  global longest
          res = Math.Max(currentLongest, res);
        }
      }
      return res;
    }
  }
}
