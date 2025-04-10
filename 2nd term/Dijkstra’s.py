import heapq

def dijkstra(graph, start):
    # Set all distances to infinity
    distance = {node: float('inf') for node in graph}
    distance[start] = 0

    # Min-heap to get the shortest distance node
    heap = [(0, start)]

    while heap:
        dist_u, u = heapq.heappop(heap)

        for v, weight in graph[u]:
            new_dist = dist_u + weight
            if new_dist < distance[v]:
                distance[v] = new_dist
                heapq.heappush(heap, (new_dist, v))

    return distance
