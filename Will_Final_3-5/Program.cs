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
        //An adjacency matrix and list for the digraph on question #3 of the final exam

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

        //Used for the dijkstra shortest path search for question #5 on the final exam
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
            shortestPath.Add(colorNodes[7]);
            BuildShortestPath(shortestPath, colorNodes[7]);
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
            Node start = colorNodes[0];

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

                // if we reached our target
                if (node == colorNodes[7])
                {
                    return;
                }
            } while (prioQueue.Any());
        }

        static public void InitializeEdges()
        {
            colorNodes[0].AddEdge(1, colorNodes[1]); //red to yellow
            colorNodes[0].AddEdge(5, colorNodes[4]); //red to grey
            colorNodes[1].AddEdge(8, colorNodes[2]); //blue to yellow
            colorNodes[1].AddEdge(1, colorNodes[3]); //blue to cyan
            colorNodes[3].AddEdge(1, colorNodes[1]); //cyan to blue
            colorNodes[4].AddEdge(0, colorNodes[3]); //grey to cyan
            colorNodes[3].AddEdge(0, colorNodes[4]); //cyan to grey
            colorNodes[4].AddEdge(1, colorNodes[6]); //grey to orange
            colorNodes[2].AddEdge(6, colorNodes[7]); //yellow to green
            colorNodes[5].AddEdge(1, colorNodes[2]); //purple to yellow
            colorNodes[6].AddEdge(1, colorNodes[5]); //orange to purple
        }

        static void Main(string[] args)
        {
            //DFS Search
            Console.Write("DFS: ");
            DFS(EColor.red);

            //Dijkstra Shortest Path
            Console.Write("\nDijkstra's: ");

            Node node;

            for (int i = 0; i < colorAGraph.Length; ++i)
            {
                node = new Node((EColor)i);
                colorNodes.Add(node);
            }

            InitializeEdges();

            List<Node> shortList = GetShortestPathDijkstra();

            foreach (Node cNode in shortList)
            {
                Console.Write(cNode.nState.ToString() + " ");
            }

            Console.WriteLine();
            
        }
    }
}
