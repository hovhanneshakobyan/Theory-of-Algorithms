def DFS(graph, node, visited, order):
    visited[node] = True
    for neighbor in graph[node]:
        if not visited[neighbor]:
            DFS(graph, neighbor, visited, order)
    order.append(node)

Graph = {
    0: [1, 9],
    1: [8, 0],
    2: [3],
    3: [2, 4, 5, 7],
    4: [3],
    5: [3, 6],
    6: [5, 7],
    7: [6, 3, 11, 10, 8],
    8: [1, 9, 7],
    9: [8, 0],
    10: [7, 11],
    11: [7, 10]
}
visited = [False] * len(Graph)
order = []
start_node = int(input("Start DFS from node (0-11): "))
DFS(Graph, start_node, visited, order)
print("DFS Post-order traversal (reversed):", order[::-1])