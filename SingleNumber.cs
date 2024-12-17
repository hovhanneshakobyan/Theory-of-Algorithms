public class Solution
{
    public int SingleNumber(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Contains(nums[i]))
            {
                set.Add(nums[i]);
            }
            else
            {
                set.Remove(nums[i]);
            }
        }
        return set.First();
    }
}