using System;
using System.IO;

namespace FolderCrawling
{
    public class BFS
    {

        private bool isFound = false;
        private int countNode = 1;
        private GUIOutput output = new GUIOutput();


        public void useBFS(DirectoryTree tree,
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

            while(tree_list.Count != 0 && !isFound)
            {
                if(searchTreeList(tree_list, searchDir, graph, comboBoxFile, textFolderRoute))
                {
                    isFound = true;
                }
                else
                {
                    tree_list = arrayDir(tree_list);
                }
            }

        }

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

        public bool searchTreeList(List<DirectoryTree> treeArray, string nameDir, Microsoft.Msagl.Drawing.Graph graph,
            ComboBox comboBoxFile, RichTextBox textFolderRoute)
        {
            bool found = false;
            int idx = 0;
            for(int i = 0; i < treeArray.Count; i++)
            {
                string namefile = Path.GetFileName(treeArray[i].Data);
                treeArray[i].changeData(namefile + " " + "(" + countNode + ")");
                countNode++;
                if (namefile == nameDir)
                {
                    output.displayTreeDirs(treeArray[i], graph, "blue");
                    comboBoxFile.Items.Add(treeArray[i].Data);
                    isFound = true;
                    found = true;
                    idx = i;
                    break;
                }
                else
                {
                    output.displayTreeDirs(treeArray[i], graph, "red");
                }
                output.printFolderRoute(treeArray[i].Data, textFolderRoute);

            }
          
            return found;
        }
    }
}
