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

            // INI contoh method buatt liatt treenya, buatt gambar tree nya bisa panggil method
            // displayTreeDirs: nampilin graphnyaaa, dipanggil di dalam printTreeDirs
            // INI digantii sama DFS atauu BFSnyaa, nantii difungsii DFS/BFS manggil method printTreeDirs
            // Cara manggilnya, mulai dari root yaa.., jadii setiapp root manggil printTreeDirs
            string[] pathDirs = { @"C:\Users\Asus\Pictures\New folder\tes\tes444\huhuuu.txt" };
            output.printTreeDirs(directoryTree, graph, pathDirs);

            graphViewer.Graph = graph;
            graphContainer.Controls.Add(graphViewer);
        }

    }
}