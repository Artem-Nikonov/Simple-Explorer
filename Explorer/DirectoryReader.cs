using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Проводник
{
 
    internal class DirectoryReader: IDirReader, ICheckDirectory
    {
        public bool IsDirectoryExists(string path) => Directory.Exists(path);

        public string[]? GetAllFiles(string path, Action<string> error, string type = "")
        {
            string[]? files = null;
            if (!Directory.Exists(path))
            {
                error("Директория не существует.");
                return files;
            }
            try
            {
                files = Directory.GetFileSystemEntries($@"{path}", type);
            }
            catch
            {
                error("Директория недоступна.");
            }
            
            return files;
        }

        public string? GetParentDirectory(string? path, Action error)
        {
            DirectoryInfo? ParentDir;
            if (String.IsNullOrEmpty(path)) return null;
            ParentDir = Directory.GetParent(path);
            if (ParentDir == null)
            {
                error();
                return null;
            }
            return ParentDir.FullName;
        }

        public bool IsParentDirectoryExist(string? path)
        {
            DirectoryInfo? ParentDir;
            if (String.IsNullOrEmpty(path)) return false;
            ParentDir = Directory.GetParent(path);
            if(ParentDir == null) return false;
            return true;
        }

    }
}
