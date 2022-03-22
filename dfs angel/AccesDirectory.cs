using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baba
{
    internal class AccesDirectory
    {
        public void getAllDirs(DirectoryTree tree)
        {
            if (Directory.Exists(tree.Data))
            {
                string[] subdirs = Directory.GetFileSystemEntries(tree.Data, "*", SearchOption.TopDirectoryOnly);
                if (subdirs.Length > 0)
                {
                    for (int i = 0; i < subdirs.Length; i++)
                    {
                        tree.AddChild(subdirs[i]);
                        getAllDirs(tree[i]);
                    }
                }
            }
        }
    }
}
