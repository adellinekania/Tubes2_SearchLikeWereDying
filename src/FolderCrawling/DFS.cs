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
            printTrees(tree,graph);
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
            printTreesNotAll(tree,graph);
        }

        // Fungsi ini untuk mencari semua occurences nama file tersebut
        public void dfsini(DirectoryTree pohon,
        string path, 
        string filename,
        RichTextBox textFolderRoute,
        ComboBox comboBoxFile)
        {
            string namefile = Path.GetFileName(pohon.Data);
            output.printFolderRoute(namefile, textFolderRoute);
            output.printFolderRoute("\n", textFolderRoute);
            if (pohon.Visited) return;
            pohon.SetVisited(true);
            if ((pohon.Data).Equals(path) && pohon.Level != 0){
                solution.Add(pohon);
                comboBoxFile.Items.Add(pohon.Data); 
            }
            if (pohon.Count > 0)
            {
                string temp = pohon.Data +"\\"+ filename;
                for (int j = pohon.Count-1; j >= 0; j--)
                {
                    if (!pohon[j].Visited)
                        dfsini(pohon[j], temp, filename,textFolderRoute,comboBoxFile);
                }
            }

        }


        // mencari satu solusi, masuk ke solution string, if dfsnotall returns true dalam bentuk string maka ada jawaban di solution.
        // jika dfs returns false artinya ngga ada jawaban di solutionnya.
        public string dfsnotall2(DirectoryTree pohon, string path, string filename, RichTextBox textFolderRoute,ComboBox comboBoxFile){
        
            pohon.SetVisited(true);
            string temp = pohon.Data;
            string namefile = Path.GetFileName(pohon.Data);
            output.printFolderRoute(namefile, textFolderRoute);
            output.printFolderRoute("\n", textFolderRoute);
            if (pohon.Data == path && pohon.Level != 0){
                solution.Add(pohon);
                comboBoxFile.Items.Add(pohon.Data);  
                return temp;
            }
            else{
                if (pohon.Count > 0) {
                    temp = pohon.Data +"\\"+ filename;
                }
                for (int i = pohon.Count-1; i >= 0; i--)
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

        // Mengeluarkan display tree setelah semua simpul dikunjungi
        public void printTrees(DirectoryTree pohon, Microsoft.Msagl.Drawing.Graph graph)
        {
            int count = pohon.Count;
            countNode++;
            if (count > 0)
            {
                printingTrees(pohon,graph);
                for (int i = pohon.Count-1; i >= 0; i--)
                {
                    printTrees(pohon[i], graph);
                }
            }
            else{
                printingTrees(pohon,graph);
            }
        }

        // Mengeluarkan display tree untuk kasus pencarian berhenti setelah mendapat 1 solusi
        public void printTreesNotAll(DirectoryTree pohon, Microsoft.Msagl.Drawing.Graph graph)
        {
            if (solution.Count != 0){
                int count = pohon.Count;
                countNode++;
                
                if (count > 0 && !got_it)
                {
                    printingTrees(pohon, graph);
                    for (int i = pohon.Count-1; i >= 0; i--)
                    {
                        printTreesNotAll(pohon[i],graph);
                    }
                }
                else if (!got_it ){
                    printingTrees(pohon, graph);
                }
            }
            else {
                printTrees(pohon,graph);
            }
        }

        // Mendisplay grafik node ujung
        public void printingTrees (DirectoryTree pohon, Microsoft.Msagl.Drawing.Graph graph){
            bool found = false;
            foreach(var s in solution)
            {
                if (pohon.Data.Equals(s.Data) )
                {
                    found = true;
                    got_it = true;
                }
            }
            string namafile = Path.GetFileName(pohon.Data);
            if (countNode != 0) 
            {
                pohon.changeData(namafile + " (" + countNode + ")");
            }
            if (found)
            {
                output.displayTreeDirs(pohon, graph, "blue");
            }
            else if (pohon.Visited)
            {
                output.displayTreeDirs(pohon, graph, "red");
            }
            else {
                output.displayTreeDirs(pohon, graph, "black");
            }
        }
    }
}
