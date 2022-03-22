using System;
using System.IO;

namespace FolderCrawling
{
    public class BFS
    {

        private bool isFound = false;
        private int countNode = 1;
        private GUIOutput output = new GUIOutput();
        private List<DirectoryTree> list_of_path = new List<DirectoryTree>();


        //BFS dengan All Occurence
        public void useBFSAllOccur(DirectoryTree tree,
            Microsoft.Msagl.Drawing.Graph graph,
            string searchDir,
            ComboBox comboBoxFile,
            RichTextBox textFolderRoute)
        {
            List<DirectoryTree> tree_list = new List<DirectoryTree>();
            //ini buat disamain sama algo BFS nya ya
            for(int i = 0; i < tree.Count; i++)
            {
                tree_list.Add(tree[i]);
            }

            while(tree_list.Count != 0)
            {
                searchTreeListModified(tree_list, searchDir, graph, comboBoxFile, textFolderRoute);
                tree_list = arrayDir(tree_list);
            }

        }

        //BFS dengan kasus non- All Occurences
        public void useBFS(DirectoryTree tree,
            Microsoft.Msagl.Drawing.Graph graph,
            string searchDir,
            ComboBox comboBoxFile,
            RichTextBox textFolderRoute)
        {
            List<DirectoryTree> tree_list = new List<DirectoryTree>();
            //ini buat disamain sama algo BFS nya ya
            for (int i = 0; i < tree.Count; i++)
            {
                tree_list.Add(tree[i]);
            }

            while (tree_list.Count != 0 && !isFound)
            {
                if (searchTreeList(tree_list, searchDir, graph, comboBoxFile, textFolderRoute))
                {
                    isFound = true;
                }
                else
                {
                    tree_list = arrayDir(tree_list);
                }
            }

        }

        //Mencari daftar seluruh directory dan file yang ada pada Parent Tree
        public List<DirectoryTree> arrayDir (List<DirectoryTree> treeArray)
        {
            int total_length = 0;
            int idx = 0;
            for(int i = 0; i < treeArray.Count; i++)
            {
                total_length += treeArray[i].Count;
            }
            List<DirectoryTree> array = new List<DirectoryTree>();
            for(int i = 0; i < treeArray.Count; i++)
            {
                DirectoryTree childTree = treeArray[i];
                for(int j = 0; j < treeArray[i].Count; j++)
                {
                    array.Add(childTree[j]);
                    idx++;
                }
            }

            return array;
        }

        //Mencari apakah file ada di Children Tree
        public bool searchTreeList(List<DirectoryTree> treeArray, string nameDir, Microsoft.Msagl.Drawing.Graph graph,
            ComboBox comboBoxFile, RichTextBox textFolderRoute)
        {
            bool found = false;
            int idx = 0;
            for(int i = 0; i < treeArray.Count; i++)
            {
                string namefile = Path.GetFileName(treeArray[i].Data);
                string save_tree_data = treeArray[i].Data;
                treeArray[i].changeData(namefile + " " + "(" + countNode + ")");
                countNode++;
                if (namefile == nameDir)
                {
                    comboBoxFile.Items.Add(save_tree_data);
                    output.displayTreeDirs(treeArray[i], graph, "blue");
                    isFound = true;
                    found = true;
                    idx = i;
                    output.printFolderRoute(save_tree_data, textFolderRoute);
                }
                else
                {
                    output.displayTreeDirs(treeArray[i], graph, "red");
                }

            }
          
            return found;
        }

        //Mencari apakah file ada di Children Tree untuk kasus All Occurence
        public void searchTreeListModified(List<DirectoryTree> treeArray, string nameDir, Microsoft.Msagl.Drawing.Graph graph,
            ComboBox comboBoxFile, RichTextBox textFolderRoute)
        {
            int idx = 0;
            bool found = false;
            for (int i = 0; i < treeArray.Count; i++)
            {
                string namefile = Path.GetFileName(treeArray[i].Data);
                string save_tree_data = treeArray[i].Data;
                treeArray[i].changeData(namefile + " " + "(" + countNode + ")");
                countNode++;
                if (!found)
                {
                    if (namefile == nameDir)
                    {
                        comboBoxFile.Items.Add(save_tree_data);
                        idx = i;
                        output.displayTreeDirs(treeArray[i], graph, "blue");
                        found = true;
                    }
                    else
                    {
                        output.displayTreeDirs(treeArray[i], graph, "red");
                    }
                }
                else
                {
                    output.displayTreeDirs(treeArray[i], graph, "red");
                }
                output.printFolderRoute(save_tree_data, textFolderRoute);

            }
        }
    }
}
