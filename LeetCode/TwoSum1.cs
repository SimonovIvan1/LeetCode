public class TwoSum1
{
    //first method
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            for (int j = i + 1; j <= nums.Length - 1; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    return new int[2] { i, j };
                }
            }
        }
        return new int[2];
    }
    //second method with dictionary
    public int[] TwoSumWithDictionary(int[] nums, int target)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement))
            {
                return new int[2] { i, dic[complement] };
            }
            if (!dic.ContainsKey(nums[i]))
            {
                //every distinct value only needs to exist once(one time)
                dic.Add(nums[i], i);
            }

        }
        return new int[] { };
    }
}