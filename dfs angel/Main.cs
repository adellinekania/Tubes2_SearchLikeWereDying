namespace baba{
    internal class Program{
        
        static void Main(string[] args){
            // pilih starting pathnya
            string startingPath = "..//..//rpl";
            // masukkan nama file atau folder but not "directory" yang ingin dicari
            string findTheFile = "materi uts\\5-IF2250 Perancangan Terstruktur.pdf";
            // process menggunakan struktur data yang dibuat adel
            DirectoryTree directoryTree = new DirectoryTree(startingPath);
            AccesDirectory dir = new AccesDirectory();
            dir.getAllDirs(directoryTree);
            // buat object sendiri :v
            Program me = new Program();
            List<string> _solutions = new List<string>();
            // Ini merupakan contoh implementasi yang search bukan semua (stop halfway)
            // Idenya pembuatan graf dilakukan setelah memproses dfsnotall2 dulu karena terdapat pohon blm divisit
            // string gotcha = me.dfsnotall2(directoryTree, startingPath, findTheFile);
            // if (!String.IsNullOrEmpty(gotcha)){
            //     Console.WriteLine(gotcha);
            // }
            // else{
            //     Console.WriteLine("sad");
            // }
            // Ini merupakan contoh implementasi yang search untuk semua. 
            // Idenya pembuatan graf sekaligus dilakukan dalam dfsini juga
            me.dfsini(directoryTree, startingPath, findTheFile);

        }

        public void dfsini(DirectoryTree pohon,string path, string filename){

            // Fungsi ini untuk mencari semua occurences nama file tersebut
            pohon.SetVisited(true);
            if ((pohon.Data).Equals(path) && pohon.Level != 0){
                Console.WriteLine("Ketemu di" + pohon.Data);
            }
            
            Console.WriteLine("Angel: " + path);
            Console.WriteLine(pohon.Data);
            if (pohon.Count > 0)
            {
                string temp = pohon.Data +"\\"+ filename;
                for (int j = 0 ; j < pohon.Count ; j++)
                {
                    if (!pohon[j].Visited)
                        dfsini(pohon[j], temp, filename);
                }
            }   
        }


        public string dfsnotall2(DirectoryTree pohon, string path, string filename){
        // mencari satu, masuk ke solution string, if dfsnotall returns true, then ada jawaban di solution.
        // if dfs returns false artinya ngga ada jawaban di solutionnya.
            pohon.SetVisited(true);
            Console.WriteLine("lala di: " + pohon.Data);
            string temp = pohon.Data;

            if (pohon.Data == path && pohon.Level != 0){
                //Console.WriteLine("Ketemu di: " + pohon.Data);
                return temp;
            }
            else{
                if (pohon.Count > 0) {
                    temp = pohon.Data +"\\"+ filename;
                }
                for (int i = 0; i < pohon.Count; i++)
                {
                    Console.WriteLine("temp di: " + temp);
                    if (!pohon[i].Visited){
                        string found = dfsnotall2(pohon[i], temp, filename);  
                        if (!string.IsNullOrEmpty(found)){
                            return found;
                        }
                    }
                    //Console.WriteLine("sempatmasukkah ke sini?");
                }
                return null;
            }    
        }
    }
}
