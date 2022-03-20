using System;
using System.IO;


class BFS
{
    public static void Main()
    {
        //terima input dulu nanti disesuaiin sama GUI
        string input_dict = @"d:\";
        bool flag = true;
        string file_name = "tucilstima.py";
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
            int string_length = (name.FullName).Length;
            string nama_file = (name.FullName).Substring(2, string_length-2);
            DirectoryInfo new_dict = new DirectoryInfo(nama_file);
            DirectoryInfo [] directories_list = new_dict.GetDirectories();
            sum += directories_list.Length;

        }

        DirectoryInfo [] final_list = new DirectoryInfo[sum];
        int current_idx = 0;
        foreach (DirectoryInfo name_list in dict){
            DirectoryInfo new_dict2 = new DirectoryInfo(name_list.FullName);
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
            int string_length = (name.FullName).Length;
            string nama = name.FullName;
            string nama_file = nama.Substring(2, string_length-2);
            DirectoryInfo new_dict = new DirectoryInfo(nama_file);
            if(searchDepth(new_dict, filename)){
                result = true;
                return result;
            }
        }
        return false;
    }

    
    //untuk mencari nama file di directory
    public static bool searchDepth(DirectoryInfo dict2, string name){
        int string_length = (dict2.FullName).Length;
        string nama = dict2.FullName;
        string nama_file = nama.Substring(2, string_length-2);
        var filePaths = dict2.EnumerateFiles();
        foreach (var files in filePaths){
            if(files.Name == name){
                return true;
            }
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
