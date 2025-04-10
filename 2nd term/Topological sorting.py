graph = {
    'A': ['D'],
    'B': ['D'],
    'C': ['A', 'B'],
    'D': ['G', 'H'],
    'E': ['F', 'D', 'A'],
    'F': ['K', 'J'],
    'G': ['I'],
    'H': ['J', 'I'],
    'I': ['L'],
    'J': ['M', 'L'],
    'K': ['J'],
    'L': [],
    'M': []
}

def topological_sort(graph):
    visited = set()
    result = []

    def dfs(node):
        if node in visited:
            return
        visited.add(node)
        for neighbor in graph[node]:
            dfs(neighbor)
        result.append(node)

    for node in graph:
        dfs(node)

    result.reverse()
    return result

# Run and print
sorted_order = topological_sort(graph)
print("Topological Sort:", sorted_order)
