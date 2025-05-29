def find_center_of_the_star(A):
    n = len(A)
    for i in range(n):
        if sum(A[i]) == n - 1:
            return [i]

A = [
    [0, 1, 1, 1, 1],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0]
]

result = find_center_of_the_star(A)
print(result)
