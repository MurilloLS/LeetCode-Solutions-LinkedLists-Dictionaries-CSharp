//1. Two Sum

namespace DaySeven
{
  public static class Dictionary
  {
    public static int[] TwoSum(int[] nums, int target)
    {
      Dictionary<int, int> result = new();
      int num = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        num = nums[i];
        if (result.ContainsKey(target - num))
        {
          return [i, result[target - num]];
        }

        if (!result.ContainsKey(num))
        {
          result.Add(num, i);
        }
      }
      return [];
    }
  }
}
