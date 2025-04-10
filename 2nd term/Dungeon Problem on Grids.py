from collections import deque

Graph = [['S', '.', '.', '#', '.', '.', '.'],
         ['.', '#', '.', '.', '.', '#', '.'],
         ['.', '#', '.', '.', '.', '.', '.'],
         ['.', '.', '#', '#', '.', '.', '.'],
         ['#', '.', '#', 'E', '.', '#', '.']]

rows = len(Graph)
cols = len(Graph[0])
directions = [(-1, 0), (1, 0), (0, -1), (0, 1)]
for i in range(rows):
    for j in range(cols):
        if Graph[i][j] == 'S':
            start = (i, j)
        if Graph[i][j] == 'E':
            end = (i, j)

# BFS setup
queue = deque()
queue.append((start[0], start[1]))
visited = [[False] * cols for _ in range(rows)]
parent = [[None] * cols for _ in range(rows)]
visited[start[0]][start[1]] = True

# BFS loop
found = False
while queue:
    x, y = queue.popleft()

    if (x, y) == end:
        found = True
        break

    for dx, dy in directions:
        nx, ny = x + dx, y + dy
        if 0 <= nx < rows and 0 <= ny < cols:
            if not visited[nx][ny] and Graph[nx][ny] != '#':
                visited[nx][ny] = True
                parent[nx][ny] = (x, y)
                queue.append((nx, ny))

# Reconstruct path
if found:
    path = []
    curr = end
    while curr != start:
        path.append(curr)
        curr = parent[curr[0]][curr[1]]
    path.append(start)
    path.reverse()

    print("Shortest path length to 'E':", len(path) - 1)
    print("Path coordinates:")
    for coord in path:
        print(coord)
else:
    print("No path found to 'E'")
