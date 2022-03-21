using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderCrawling.Properties;

namespace FolderCrawling
{
    internal class GUIOutput
    {
        // INI contoh penggunaan displayTreeDirs buat nampilinn treenya ya gaiss
        // displayTreeDirs dipanggilnya setiapp nyampee leaff 
        public void printTreeDirs(DirectoryTree tree, Microsoft.Msagl.Drawing.Graph graph, string[] pathDirs)
        {
            int count = tree.Count;
            if (count > 0)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    printTreeDirs(tree[i], graph, pathDirs);
                }

            }
            else
            {
                bool isPath = false;
                int i = 0;
                while (!isPath && i < pathDirs.Length)
                {
                    if (tree.Data.Equals(pathDirs[i]))
                    {
                        isPath = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (isPath)
                {
                    displayTreeDirs(tree, graph, "blue");
                }
                else
                {
                    displayTreeDirs(tree, graph, "red");
                }
            }
        }

        public void displayTreeDirs(DirectoryTree tree, Microsoft.Msagl.Drawing.Graph graph, string color)
        {
            if (!tree.IsRoot)
            {
                string parent = Path.GetFileName(tree.Parent.Data);
                string child = Path.GetFileName(tree.Data);

                Microsoft.Msagl.Drawing.Node nodeChild = graph.FindNode(child);
                int inEdgeCount = 0;
                if (nodeChild != null)
                {
                    Microsoft.Msagl.Drawing.Edge[] inEdge = graph.FindNode(child).InEdges.ToArray();
                    inEdgeCount = graph.FindNode(child).InEdges.ToArray().Length;

                    if (color.Equals("blue"))
                    {
                        bool edgeFound = false;
                        int i = 0;
                        while (i < inEdgeCount && !edgeFound)
                        {
                            if (inEdge[i].Source.Equals(parent))
                            {
                                inEdge[i].Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                                edgeFound = true;
                            }
                            i++;
                        }
                    }
                }


                if (inEdgeCount == 0)
                {
                    if (color.Equals("blue"))
                    {
                        graph.AddEdge(parent, child).Attr.Color =
                        Microsoft.Msagl.Drawing.Color.Blue;
                    }
                    else if (color.Equals("red"))
                    {
                        graph.AddEdge(parent, child).Attr.Color =
                        Microsoft.Msagl.Drawing.Color.Red;
                    }
                    else
                    {
                        graph.AddEdge(parent, child).Attr.Color =
                        Microsoft.Msagl.Drawing.Color.Black;
                    }

                    
                }

                Microsoft.Msagl.Drawing.Node parentNode = graph.FindNode(parent);
                Microsoft.Msagl.Drawing.Node childNode = graph.FindNode(child);

                if (color.Equals("blue"))
                {
                    parentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                }
                else if (color.Equals("red"))
                {
                    Microsoft.Msagl.Drawing.Color colorr = parentNode.Attr.Color;
                    if (colorr != Microsoft.Msagl.Drawing.Color.Blue)
                    {
                        parentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }
                else
                {
                    //parentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    //childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                }
                displayTreeDirs(tree.Parent, graph, color);
            }
        }

        // INI buat testing doang
        public void printAllDirs(DirectoryTree tree, FlowLayoutPanel graphContainer)
        {
            int count = tree.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    TextBox text = new TextBox();
                    text.Text = Path.GetFileName(tree[i].Data);
                    graphContainer.Controls.Add(text);
                    printAllDirs(tree[i], graphContainer);
                }
            }

        }


        // Method untuk menampilkan rute folder yang ditelusuri
        public void printFolderRoute(string route, RichTextBox textFolderRoute)
        {
            textFolderRoute.Text += route + "-";
        }
    }
}
