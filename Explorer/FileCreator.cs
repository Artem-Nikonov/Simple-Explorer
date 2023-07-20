using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    internal class FileCreator: IFileCreator
    {
        public void CreateFile(string path, Action<string> error)
        {
            if (!File.Exists(path) && !Directory.Exists(path))
            {
                using (File.Create(path))
                return;
            }
            error("Директория или файл с таким названием уже существует");
        }

        public void DeleteFile(string path, Action<string> error)
        {
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
 
                    return;
                }
                catch
                {
                    error("Ошибка удаления.");
                    return;

                }
            }
            error("Файл не существует");

        }

    }
}
