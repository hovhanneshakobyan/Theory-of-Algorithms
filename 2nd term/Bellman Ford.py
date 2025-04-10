def bellman_ford(edges, num_nodes, start):
    distance = [float('inf')] * num_nodes
    distance[start] = 0

    # Relax all edges num_nodes - 1 times
    for _ in range(num_nodes - 1):
        for u, v, w in edges:
            if distance[u] + w < distance[v]:
                distance[v] = distance[u] + w

    # Check for negative cycles
    for u, v, w in edges:
        if distance[u] + w < distance[v]:
            print("Negative cycle detected")
            return None

    return distance
