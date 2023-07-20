using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IDrivesHelper
    {
        DriveInfo[]? GetAllDrives();
    }

    interface IDirReader
    {
        string[]? GetAllFiles(string path, Action<string> error, string type);
        string? GetParentDirectory(string path, Action error);
    }

    interface ICheckDirectory
    {
        bool IsDirectoryExists(string path);
        bool IsParentDirectoryExist(string? path);
    }

    interface IDirCreator
    {
        void CreateDirectory(string path, Action<string> error);
        void DeleteDirectory(string path, Action<string> error);
    }

    interface IFileCreator
    {
        void CreateFile(string path, Action<string> error);
        void DeleteFile(string path, Action<string> error);
    }

    interface IFileInfo
    {
        string GetFileType(string path);
        bool FileExist(string path);
    }

    interface ITxtFileWorker
    {
        string ReadTxtFIle(string path);
        void WriteTxtFile(string path, string text);
    }

    interface IMp3PlayerWorker
    {
        void ChangeStateOfSong();
        void PlaySong();
        void StopSong();
    }

    interface IMp3PlayerInfo
    {
        bool IsPlaying();
        string GetStringTime();
        double GetDoubleTime();
        string GetStringCurrentTime();
        double GetDoubleCurrentTime();
    }

    interface IMp3PlayerSettings
    {
        void SetVolume(int volume);
        void SetTime(int time);
        void SetSpeed(double speed);
    }


}
