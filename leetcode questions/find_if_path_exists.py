A = [
  [0, 1, 1, 0, 0, 0],
  [1, 0, 0, 0, 0, 0],
  [1, 0, 0, 0, 0, 0],
  [0, 0, 0, 0, 1, 1],
  [0, 0, 0, 1, 0, 1],
  [0, 0, 0, 1, 1, 0],
]

n = len(A)
visited = [False] * n

source = 0
destination = 2

def DFS(A, source, destination):
    if source == destination:
        return True

    stack = [source]
    visited[source] = True

    while stack:
        current = stack.pop()
        print(current, end=' ')

        if current == destination:
            return True

        for neighbor in range(len(A[current])):
            if A[current][neighbor] == 1 and not visited[neighbor]:
                visited[neighbor] = True
                stack.append(neighbor)

    return False

if DFS(A, source, destination):
    print("Destination is reachable")
else:
    print("Destination is not reachable")
