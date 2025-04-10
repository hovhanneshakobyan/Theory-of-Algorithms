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

# Step 1: Count in-degrees
in_degree = {}
for node in graph:
    in_degree[node] = 0

for node in graph:
    for neighbor in graph[node]:
        in_degree[neighbor] += 1

# Step 2: Collect nodes with in-degree 0
queue = []
for node in in_degree:
    if in_degree[node] == 0:
        queue.append(node)

# Step 3: Process the queue
topo_order = []
while queue:
    current = queue.pop(0)
    topo_order.append(current)
    for neighbor in graph[current]:
        in_degree[neighbor] -= 1
        if in_degree[neighbor] == 0:
            queue.append(neighbor)

# Step 4: Check if topological sort is possible
if len(topo_order) == len(graph):
    print("Topological Sort:", topo_order)
else:
    print("Graph has a cycle. No topological sort.")
