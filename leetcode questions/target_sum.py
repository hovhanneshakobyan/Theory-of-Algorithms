def target_sum(nums, target):
    memo = {}

    def dp(i, total_sum):
        if (i, total_sum) in memo:
            return memo[(i, total_sum)]
        if i == len(nums):
            return 1 if total_sum == target else 0

        plus = dp(i + 1, total_sum + nums[i])
        minus = dp(i + 1, total_sum - nums[i])
        memo[(i, total_sum)] = plus + minus
        return memo[(i, total_sum)]

    return dp(0, 0)

nums = [1, 1, 1, 1, 1]
target = 3
result = target_sum(nums, target)
print(result)
