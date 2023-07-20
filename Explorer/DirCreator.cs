using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    public class DirCreator: IDirCreator
    {
        public void CreateDirectory(string path, Action<string> error)
        {
            if (!Directory.Exists(path) && !File.Exists(path))
            {
                Directory.CreateDirectory(path);
                return;
            }
            error("Директория или файл с таким названием уже существует");
        }

        public void DeleteDirectory(string path, Action<string> error)
        {
            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path, true);
                    return;
                }
                catch
                {
                    error("Ошибка удаления.");
                    return;
                }
            }
            error("Директория не существует");
        }
    }
}
