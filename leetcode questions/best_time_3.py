def best_time(prices):
    if len(prices) < 2:
        return 0
    max_profit = 0
    for i in range(1, len(prices)):
        first_profit = 0
        # First transaction profit
        for j in range(1, i + 1):
            if prices[j] > prices[j - 1]:
                first_profit += prices[j] - prices[j - 1]
        second_profit = 0
        for j in range(i + 1, len(prices)):
            if prices[j] > prices[j - 1]:
                second_profit += prices[j] - prices[j - 1]

        total_profit = first_profit + second_profit
        max_profit = max(max_profit, total_profit)
        
    return max_profit

prices = [3, 3, 5, 0, 0, 3, 1, 4]
print(best_time(prices))
