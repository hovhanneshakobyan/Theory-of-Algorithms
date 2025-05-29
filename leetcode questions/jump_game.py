def jump_game(nums):
    n = len(nums)
    jump = 0
    current = 0
    max_reach = 0
    
    for i in range(n - 1):
        max_reach = max(max_reach, i + nums[i])
        
        if i == current:
            if current == max_reach:
                return -1
            jump += 1
            current = max_reach

    return jump

print(jump_game([2, 3, 1, 1, 4]))
print(jump_game([3, 2, 1, 0, 4]))
