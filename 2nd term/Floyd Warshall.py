def floyd_warshall(num_nodes, edges):
    # Create distance matrix
    dist = [[float('inf')] * num_nodes for _ in range(num_nodes)]

    for i in range(num_nodes):
        dist[i][i] = 0

    for u, v, w in edges:
        dist[u][v] = w

    # Update paths using each node as intermediate
    for k in range(num_nodes):
        for i in range(num_nodes):
            for j in range(num_nodes):
                if dist[i][k] + dist[k][j] < dist[i][j]:
                    dist[i][j] = dist[i][k] + dist[k][j]

    return dist
