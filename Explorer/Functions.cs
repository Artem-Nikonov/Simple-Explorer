using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Проводник;

namespace WinFormsApp1
{
    enum type { Файл, Папка }

    public partial class Functions : Form
    {
        DrivesHelper drivesHelper = new DrivesHelper();
        DirectoryReader dir = new DirectoryReader();
        DirCreator dirCreator = new DirCreator();
        FileCreator fileCreator = new FileCreator();
        FileInformator fileInformator= new FileInformator();

        private void errorfunct(string message) => MessageBox.Show(message);

        private List<string> GetDrivesName(DriveInfo[] drives)
        {
            List<string> DrivesName = new List<string>(drives.GetLength(0));
            foreach (var drive in drives)
            {
                DrivesName.Add(drive.Name);
            }
            return DrivesName;
        }

        //вывести диски
        private void ShowDrives()
        {
            DriveInfo[] drives = drivesHelper.GetAllDrives();
            List<string> DrivesName = GetDrivesName(drives!);
            listBox1.DataSource = DrivesName;
            listBox1.ClearSelected();
            PrintCurrentDir(CurrentDir);
        }

        //получает все файли и папки в директории
        private string?[] GetFilesOfDir(string? path, string type = "*.")
        {
            string[]? files = dir.GetAllFiles(path, errorfunct, type);
            return files;
        }

        //проверяет полученные файлы и папки
        private bool CheckDir(string[]? files)
        {
            if (files == null) return false;
            return true;
        }

        private bool StringIsNull(string? str)
        {
            if (string.IsNullOrEmpty(str)) return true;
            return false;
        }

        //выводит файлы и папки директории
        private void ShowDir(string[]? files, ListBox lb) => lb.DataSource = files;

        //выводит текущую директорию
        private void PrintCurrentDir(Label label, string path = "") => label.Text = path;

        // совмещает предыдущие методы
        private void GoToDir(string? path, string? type = "")
        {
            string?[] files = GetFilesOfDir(path, type);
            if (!CheckDir(files)) return;
            ShowDir(files!, listBox1);
            PrintCurrentDir(CurrentDir, path);
        }

        // обновляет директорию
        private void UpdateDir(string path, string type = "") => GoToDir(path, type);

        // переход в родительскую директорию
        private void GoToParentDirectory(string path, string type = "")
        {
            string? ParentDir = dir.GetParentDirectory(path, ShowDrives);
            if (String.IsNullOrEmpty(ParentDir)) return;
            GoToDir(ParentDir, type);
            PrintCurrentDir(CurrentDir, ParentDir);
        }

        private string GetCorrectPath(string? currentDir, string? objectName)
        {
            bool IsRoot = IsRootFolder(currentDir);
            string path = IsRoot ? $@"{currentDir}{objectName}" :
                                   $@"{currentDir}\{objectName}";
            return path;
        }

        private string GetFileType(string path) => fileInformator.GetFileType(path);

        private bool DirExist(string? path) => dir.IsDirectoryExists(path);

        private bool IsRootFolder(string? path) => !dir.IsParentDirectoryExist(path);

        private void CreateDir(string path) => dirCreator.CreateDirectory(path, errorfunct);

        private void DeleteDir(string path) => dirCreator.DeleteDirectory(path, errorfunct);

        private void CreateFile(string path) => fileCreator.CreateFile(path, errorfunct);

        private void DeleteFile(string path) => fileCreator.DeleteFile(path, errorfunct);

        private bool FileExist(string path) => fileInformator.FileExist(path);

        private void OpenConfirmForm(string path, Action<string> funct)
        {
            ConfirmForm confirmForm = new ConfirmForm(path);
            confirmForm.SubscribeToConfirmButtonEvent((sender, e) => funct(path));
            confirmForm.ShowDialog();
        }

        private void OpenTxtFile(string path)
        {
            TxtRedactor txtRedactor = new TxtRedactor(path);
            txtRedactor.ShowDialog();
        }

        private void OpenMp3File(string path)
        {
            Mp3Redactor mp3Player = new Mp3Redactor(path);
            mp3Player.ShowDialog();
        }

        private void ChangeColor(Color BackColor, Color ForeColor, params Control[] objects)
        {
            foreach (Control obj in objects)
            {
                obj.BackColor = BackColor;
                obj.ForeColor = ForeColor;
            }
        }

        private void ChangeFont(params Control[] objects)
        {
            fontDialog1.ShowDialog();
            foreach (Control obj in objects)
            {
                obj.Font = fontDialog1.Font;
            }
        }

    }

}
