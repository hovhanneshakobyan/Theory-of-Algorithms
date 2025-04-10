from collections import deque

Graph = {
    0: [11,7, 9],
    1: [],
    2: [],
    3: [2, 4],
    4: [],
    5: [],
    6: [5],
    7: [6, 3, 11],
    8: [12],
    9: [8, 10],
    10: [1],
    11: [7, 10],
    12: [2]
}
result = []
result.append(0)
queue = deque()
visited = [False] * len(Graph)
visited[0] = True
queue.append(0)
while queue:
    vertex = queue.popleft()

    for neighbour in Graph[vertex]:
        if not neighbour in result:
            result.append(neighbour)
        if neighbour not in visited:
            visited.append(neighbour)
            queue.append(neighbour)
print(result)