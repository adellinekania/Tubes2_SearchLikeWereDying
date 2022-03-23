using System;
using System.IO;

namespace FolderCrawling
{
    public class DFS
    {

        private int countNode = -1;
        private GUIOutput output = new GUIOutput();
        public List<DirectoryTree> solution = new List<DirectoryTree>();
        private bool got_it = false;


        //DFS dengan All Occurence
        public void useDFSAllOccur(DirectoryTree tree,
            Microsoft.Msagl.Drawing.Graph graph,
            string searchDir,
            ComboBox comboBoxFile,
            RichTextBox textFolderRoute, string searchFileName)
        {
            string path = searchDir;
            string filename = searchFileName;
            dfsini(tree, path, filename, textFolderRoute,comboBoxFile);
            printTrees(
                tree,
                searchDir,
                graph,
                comboBoxFile,
                textFolderRoute
            );
        }

        //DFS dengan not All Occurence
        public void useDFS(DirectoryTree tree,
            Microsoft.Msagl.Drawing.Graph graph,
            string searchDir,
            ComboBox comboBoxFile,
            RichTextBox textFolderRoute, string searchFileName)
        {
            string path = searchDir;
            string filename = searchFileName;
            string result = dfsnotall2(tree, path, filename, textFolderRoute,comboBoxFile);
            printTreesNotAll(
                tree,
                searchDir,
                graph,
                comboBoxFile,
                textFolderRoute
            );
        }

        // Fungsi ini untuk mencari semua occurences nama file tersebut
        public void dfsini(DirectoryTree pohon,
        string path, 
        string filename,
        RichTextBox textFolderRoute,
        ComboBox comboBoxFile)
        {
            pohon.SetVisited(true);
            if ((pohon.Data).Equals(path) && pohon.Level != 0){
                solution.Add(pohon);
                output.printFolderRoute(pohon.Data, textFolderRoute);
                output.printFolderRoute("\n", textFolderRoute);
                comboBoxFile.Items.Add(pohon.Data); 
            }
            if (pohon.Count > 0)
            {
                string temp = pohon.Data +"\\"+ filename;
                for (int j = 0 ; j < pohon.Count ; j++)
                {
                    if (!pohon[j].Visited)
                        dfsini(pohon[j], temp, filename,textFolderRoute,comboBoxFile);
                }
            }
        }


        // mencari satu, masuk ke solution string, if dfsnotall returns true, then ada jawaban di solution.
        // if dfs returns false artinya ngga ada jawaban di solutionnya.
        public string dfsnotall2(DirectoryTree pohon, string path, string filename, RichTextBox textFolderRoute,ComboBox comboBoxFile){
        
            pohon.SetVisited(true);
            string temp = pohon.Data;

            if (pohon.Data == path && pohon.Level != 0){
                solution.Add(pohon);
                output.printFolderRoute(pohon.Data, textFolderRoute);
                comboBoxFile.Items.Add(pohon.Data);  
                return temp;
            }
            else{
                if (pohon.Count > 0) {
                    temp = pohon.Data +"\\"+ filename;
                }
                for (int i = 0; i < pohon.Count; i++)
                {
                    if (!pohon[i].Visited){
                        string found = dfsnotall2(pohon[i], temp, filename, textFolderRoute, comboBoxFile);  
                        if (!string.IsNullOrEmpty(found)){
                            return found;
                        }
                    }
                }
                return null;
            }
        }    

        // Untuk Mengeluarkan display tress setelah dfs semuanyaa
        public void printTrees(DirectoryTree pohon, string nameDir, Microsoft.Msagl.Drawing.Graph graph,
            ComboBox comboBoxFile, RichTextBox textFolderRoute)
        {
            int count = pohon.Count;
            countNode++;
            if (count > 0)
            {
                for (int i = 0; i < pohon.Count ; i++)
                {
                    count--;
                    printTrees(
                        pohon[i],
                        nameDir,
                        graph,
                        comboBoxFile,
                        textFolderRoute
                    );
                }

            }
            else{
                string namafile = Path.GetFileName(pohon.Data);
                bool found = false;
                if (solution.Count != 0){
                    foreach(var s in solution){
                        if (pohon.Data.Equals(s.Data) ){
                            found = true;
                        }
                    }
                }
                if (found)
                {
                    pohon.changeData(namafile + " (" + countNode + ")");
                    output.displayTreeDirs(pohon, graph, "blue");
                }
                else if (pohon.Visited)
                {
                    pohon.changeData(namafile + " (" + countNode + ")");
                    output.displayTreeDirs(pohon, graph, "red");
                }
                else {
                    output.displayTreeDirs(pohon, graph, "black");
                }
            }
        }

        // Untuk Mengeluarkan display tree setelah dfs semuanyaa
        public void printTreesNotAll(DirectoryTree pohon, string nameDir, Microsoft.Msagl.Drawing.Graph graph,
            ComboBox comboBoxFile, RichTextBox textFolderRoute)
        {
            if (solution.Count != 0){
                int count = pohon.Count;
                countNode++;
                if (count > 0 && (pohon != solution[0]) && !got_it)
                {
                    for (int i = 0; i < pohon.Count ; i++)
                    {
                        printTreesNotAll(
                            pohon[i],
                            nameDir,
                            graph,
                            comboBoxFile,
                            textFolderRoute
                        );
                    }
                }
                else{
                    bool found = false;
                    foreach(var s in solution){
                        if (pohon.Data.Equals(s.Data) ){
                            found = true;
                            got_it = true;
                        }

                    }
                    string namafile = Path.GetFileName(pohon.Data);
                    if (found)
                    {
                        pohon.changeData(namafile + " (" + countNode + ")");
                        output.displayTreeDirs(pohon, graph, "blue");
                    }
                    else if (pohon.Visited)
                    {
                        pohon.changeData(namafile + " (" + countNode + ")");
                        output.displayTreeDirs(pohon, graph, "red");
                    }
                    else {
                        output.displayTreeDirs(pohon, graph, "black");
                    }
                }
            }
            else printTrees(pohon, nameDir, graph, comboBoxFile, textFolderRoute);
        }
    }
}
