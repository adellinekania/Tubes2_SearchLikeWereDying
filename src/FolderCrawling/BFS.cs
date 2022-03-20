using System;
using System.IO;


class BFS
{
    public static void Main()
    {
        //terima input dulu nanti disesuaiin sama GUI
        string input_dict = @"d:\";
        bool flag = true;
        string file_name = "answer.txt";
        DirectoryInfo dict = new DirectoryInfo(input_dict);
        DirectoryInfo [] directories_list = dict.GetDirectories();
        //var filePaths = dict.EnumerateFiles(input_dict, new EnumerationOptions{
        //        IgnoreInaccessible = true,
        //        RecurseSubdirectories = true
        //});
        //foreach (var files in filePaths){
        //    Console.WriteLine(files.Name);
        //}


        if(!searchDepth2(dict, file_name)){
            Console.WriteLine("Ini apa");
            while (directories_list.Length != 0 && flag){
                if(searchDirectory(directories_list, file_name)){
                    flag = false;
                }else{
                    directories_list = listDirectory(directories_list);
                }
            }
        }else{
            flag = false;
        }
        if(!flag){
            Console.WriteLine("ketemu");
        }else{
            Console.WriteLine("ngga ketemu");
        }

    } 

    
    //Mencari seluruh directory yang mungkin
    public static DirectoryInfo [] listDirectory(DirectoryInfo [] dict){
        int sum = 0;
        foreach (DirectoryInfo name in dict){
            string directory = Path.GetDirectoryName(name.FullName);
            DirectoryInfo new_dict = new DirectoryInfo(directory);
            DirectoryInfo [] directories_list = new_dict.GetDirectories();
            sum += directories_list.Length;

        }

        DirectoryInfo [] final_list = new DirectoryInfo[sum];
        int current_idx = 0;
        foreach (DirectoryInfo name_list in dict){
            string directory2 = Path.GetDirectoryName(name_list.FullName);
            DirectoryInfo new_dict2 = new DirectoryInfo(directory2);
            DirectoryInfo [] directories_list2 = new_dict2.GetDirectories();
            directories_list2.CopyTo(final_list, current_idx);
            current_idx += directories_list2.Length;
        }

        return final_list;
    }



    //mencari kebenaran apakah file tersebut ada atau tidak pada masing-masing directory
    public static bool searchDirectory(DirectoryInfo [] dict, string filename){
        bool result = false;
        foreach (DirectoryInfo name in dict){
            string directory3 = Path.GetDirectoryName(name.FullName);
            DirectoryInfo new_dict = new DirectoryInfo(directory3);
            if(searchDepth(new_dict, filename)){
                result = true;
                return result;
            }
        }
        return false;
    }

    
    //untuk mencari nama file di directory
    public static bool searchDepth(DirectoryInfo dict2, string name){
        string directory3 = Path.GetDirectoryName(dict2.FullName);
        if(directory3  != null){
            var filePaths = dict2.EnumerateFiles(directory3, new EnumerationOptions{
                IgnoreInaccessible = true,
                RecurseSubdirectories = true
            });
            foreach (var files in filePaths){
                Console.WriteLine(files.Name);
                if(files.Name == name){
                    return true;
                }
            }
            return false;
        }
        return false;
    }

    //Khusus untuk kasus pertama karena SearchDepth gak bisa ngehandle root folder
    public static bool searchDepth2(DirectoryInfo dict2, string name){
        FileInfo [] file = dict2.GetFiles();
        foreach (FileInfo f1 in file){
            Console.WriteLine(f1.Name);
            if(f1.Name == name){
                return true;
            }
        }
        return false;
    }
} 
