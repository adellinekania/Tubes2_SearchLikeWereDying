using System.Diagnostics;

namespace FolderCrawling
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void buttonChooseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.ShowDialog();

            string startingPath = openFolderDialog.SelectedPath;
            textFileDirectory.Text = startingPath;
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // INPUT dari user
            string startingPath = textFileDirectory.Text;
            string fileName = textInputFile.Text;
            bool isAllOccurence = checkBoxFindAll.Checked;
            bool isBFS = buttonBFS.Checked;


            // TESSS input dari usernyaaa
            string tes = "String Path : " + startingPath + "\nFile Name : " + fileName;

            if (isAllOccurence)
            {
                tes += "\nSemuaaaaa";
            }
            else
            {
                tes += "\nGa semuaaa :(";
            }

            if (isBFS)
            {
                tes += "\nMetode : BFS";
            }
            else
            {
                tes += "\nMetode : DFS";
            }

            richTextTes.Text = tes;

            // Aksess semua directory dan tarohh ke struktur data tree, GraphTreeNode
            DirectoryTree directoryTree = new DirectoryTree(startingPath);
            DirectoryAccess dir = new DirectoryAccess();

            dir.getAllDirs(directoryTree);
     
            // Menginisiasi graphViewer
            Microsoft.Msagl.GraphViewerGdi.GViewer graphViewer =
                 new Microsoft.Msagl.GraphViewerGdi.GViewer();
            graphViewer.Size = new System.Drawing.Size(graphContainer.Width, graphContainer.Height);

            // Membuat graph yang akan ditampilkan
            Microsoft.Msagl.Drawing.Graph graph =
                 new Microsoft.Msagl.Drawing.Graph("Folder Crawling Graph");

            GUIOutput output = new GUIOutput();
            
            
                
            if (isBFS)
            {
                BFS bfs = new BFS();
                List<DirectoryTree> treeList = new List<DirectoryTree>();
                treeList.Add(directoryTree);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                if (isAllOccurence)
                {
                    bfs.useBFSAllOccur(directoryTree, graph, fileName, comboBoxFile, textFolderRoute);
                }
                else
                {
                    bfs.useBFS(directoryTree, graph, fileName, comboBoxFile, textFolderRoute) ;
                }
                watch.Stop();
                var miliSecond = watch.ElapsedMilliseconds;
                richTextTes.Text += "\nTime Taken: " + miliSecond.ToString() + " ms";
            }

            // DFSSSS
            else
            {
                DFS dfs = new DFS();
                var watch = System.Diagnostics.Stopwatch.StartNew();
                if (isAllOccurence)
                {
                    dfs.useDFSAllOccur(directoryTree, graph, fileName, comboBoxFile, textFolderRoute, fileName);
                }
                else
                {
                    dfs.useDFS(directoryTree, graph, fileName, comboBoxFile, textFolderRoute, fileName) ;
                }
                watch.Stop();
                var miliSecond = watch.ElapsedMilliseconds;
                richTextTes.Text += "\nTime Taken: " + miliSecond.ToString() + " ms";
            }

            graphViewer.Graph = graph;
            graphContainer.Controls.Add(graphViewer);
        }

        private void buttonGoToFile_Click(object sender, EventArgs e)
        {
            FileInfo parent = new FileInfo(comboBoxFile.SelectedItem.ToString());
            string link = parent.DirectoryName.ToString();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = link,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }
    }
}
