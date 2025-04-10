from collections import deque

def longest_path_dag(graph, num_nodes, start):
    # Topological sort using Kahn's algorithm
    in_degree = [0] * num_nodes
    for u in graph:
        for v, _ in graph[u]:
            in_degree[v] += 1

    queue = deque([i for i in range(num_nodes) if in_degree[i] == 0])
    topo_order = []

    while queue:
        node = queue.popleft()
        topo_order.append(node)
        for neighbor, _ in graph.get(node, []):
            in_degree[neighbor] -= 1
            if in_degree[neighbor] == 0:
                queue.append(neighbor)

    # Initialize distances
    distance = [-float('inf')] * num_nodes
    distance[start] = 0

    for u in topo_order:
        for v, w in graph.get(u, []):
            if distance[u] + w > distance[v]:
                distance[v] = distance[u] + w

    return distance
