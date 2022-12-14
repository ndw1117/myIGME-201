using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Will_Final_3_5.Program.Node;

namespace Will_Final_3_5
{
    internal class Program
    {
        public static List<Node> colorNodes = new List<Node>();

        //An enum to represent the color of the nodes
        public enum EColor
        {
            red,
            blue,
            yellow,
            cyan,
            gray,
            purple,
            orange,
            green
        }
        static int[,] colorMGraph = new[,]
        {
                /*red*/ {-1, 1, -1, -1, 5, -1, -1, -1 },
                /*blue*/ {-1,-1,8,1,-1,-1,-1,-1},
                /*yellow*/ {-1,-1,-1,-1,-1,-1,-1,6},
                /*cyan*/ {-1,-1,1,-1,0,-1,-1,-1},
                /*gray*/ {-1,-1,-1,0,-1,-1,1,-1},
                /*purple*/ {-1,-1,1,-1,-1,-1,-1,-1},
                /*orange*/ {-1,-1,-1,-1,-1,1,-1,-1},
                /*green*/ {-1,-1,-1,-1,-1,-1,-1,-1 }
            };
        //The adjacencies
        static int[][] colorAGraph = new int[][]
        {
                /*red*/ new int[]{(int)EColor.blue, (int)EColor.gray},
                /*blue*/ new int[]{2, 3},
                /*yellow*/ new int[]{7},
                /*cyan*/ new int[]{1,4},
                /*gray*/ new int[]{3,6},
                /*purple*/ new int[]{2},
                /*orange*/ new int[]{5},
                /*green*/ null
        };
        //The Weights
        static int[][] colorWGraph = new int[][]
        {
                /*red*/ new int[]{1, 5},
                /*blue*/ new int[]{8, 1},
                /*yellow*/ new int[]{6},
                /*cyan*/ new int[]{1,0},
                /*gray*/ new int[]{0,1},
                /*purple*/ new int[]{1},
                /*orange*/ new int[]{1},
                /*green*/ null
        };

        //The depth-first search for question #4 on the final exam
        static void DFS(EColor eState)
        {
            bool[] visited = new bool[colorAGraph.Length];
            DFSUtil(eState, visited);
        }

        static void DFSUtil(EColor v, bool[] visited)
        {
            visited[(int)v] = true;

            Console.Write(v.ToString() + " ");

            int[] thisStateList = colorAGraph[(int)v];
            if (thisStateList != null)
            {
                foreach (int n in thisStateList)
                {
                    if (!visited[n])
                    {
                        DFSUtil((EColor)n, visited);
                    }
                }
            }
        }

        //Used for the dijkstra shortest path search for question #5 oon the final exam
        public class Node : IComparable<Node>
        {
            public EColor nState;

            public List<Edge> edges = new List<Edge>();

            public int minCostToStart;
            public Node nearestToStart;
            public bool visited;

            public Node(EColor nState)
            {
                this.nState = nState;
                this.minCostToStart = int.MaxValue;
            }

            public void AddEdge(int cost, Node connection)
            {
                Edge e = new Edge(cost, connection);
                edges.Add(e);
            }

            public int CompareTo(Node n)
            {
                return this.minCostToStart.CompareTo(n.minCostToStart);
            }

            public class Edge : IComparable<Edge>
            {
                public int cost;
                public Node connectedNode;

                public Edge(int cost, Node connectedNode)
                {
                    this.cost = cost;
                    this.connectedNode = connectedNode;
                }

                public int CompareTo(Edge e)
                {
                    return this.cost.CompareTo(e.cost);
                }
            }
        }

        static public List<Node> GetShortestPathDijkstra()
        {
            DijkstraSearch();
            List<Node> shortestPath = new List<Node>();
            shortestPath.Add(colorNodes[5]);
            BuildShortestPath(shortestPath, colorNodes[5]);
            shortestPath.Reverse();
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }


        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = colorNodes[2];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            //Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                prioQueue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 6 lines are equivalent from descriptive to abbreviated:
                prioQueue = prioQueue.OrderBy(nodeOrderBy).ToList();
                prioQueue = prioQueue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => n.minCostToStart).ToList();
                prioQueue = prioQueue.OrderBy(n => n.minCostToStart).ToList();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in //node.edges)
                         node.edges.OrderBy(delegate (Edge n) { return n.cost; }))
                {
                    Node childNode = cnn.connectedNode;
                    if (childNode.visited)
                    {
                        continue;
                    }

                    if (childNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < childNode.minCostToStart)
                    {
                        childNode.minCostToStart = node.minCostToStart + cnn.cost;
                        childNode.nearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }

                node.visited = true;

                // if we reeached our target
                if (node == colorNodes[5])
                {
                    return;
                }
            } while (prioQueue.Any());
        }

        static void Main(string[] args)
        {
            //DFS Search
            DFS(EColor.red);

            //Dijkstra Shortest Path
            Node node;

            for (int i = 0; i < colorAGraph.Length; ++i)
            {
                node = new Node((EColor)i);
                colorNodes.Add(node);
            }
           
            List<Node> shortList = GetShortestPathDijkstra();

            foreach (Node cNode in shortList)
            {
                Console.Write(cNode.nState.ToString() + " ");
            }
            

            
        }
    }
}
