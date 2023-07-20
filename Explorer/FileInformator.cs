using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    internal class FileInformator : IFileInfo
    {
        public string GetFileType(string path)
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists) return "";
            return file.Extension;
        }

        public bool FileExist(string path) => File.Exists(path);
    }
}
