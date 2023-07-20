using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проводник
{
    public class DrivesHelper: IDrivesHelper
    {
        delegate void ShowDrives();
        public DriveInfo[]? GetAllDrives()
        {
            DriveInfo[]? drives = DriveInfo.GetDrives();
            return drives;
        }

    }
}
