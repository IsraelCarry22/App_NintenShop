using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_NintenShop.Clases
{
    class System_Info
    {
        public string GetCPUName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString();
            }
            return "N/A";
        }

        public string GetCPUSpeed()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["MaxClockSpeed"].ToString() + " MHz";
            }
            return "N/A";
        }

        public string GetGPUName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString();
            }
            return "N/A";
        }

        public string GetTotalRAM()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ulong totalRam = 0;
            foreach (ManagementObject obj in searcher.Get())
            {
                totalRam += Convert.ToUInt64(obj["Capacity"]);
            }
            return (totalRam / (1024 * 1024 * 1024)).ToString() + " GB";
        }

        public string GetDiskDrive()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Model"].ToString();
            }
            return "N/A";
        }

        public string GetFreeDiskSpace()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID = 'C:'");
            foreach (ManagementObject obj in searcher.Get())
            {
                ulong freeSpace = Convert.ToUInt64(obj["FreeSpace"]);
                return (freeSpace / (1024 * 1024 * 1024)).ToString() + " GB";
            }
            return "N/A";
        }

        public string GetTotalDiskSpace()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk WHERE DeviceID = 'C:'");
            foreach (ManagementObject obj in searcher.Get())
            {
                ulong totalSpace = Convert.ToUInt64(obj["Size"]);
                return (totalSpace / (1024 * 1024 * 1024)).ToString() + " GB";
            }

            return "N/A";
        }


        public string GetOSName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Caption"].ToString();
            }
            return "N/A";
        }

        public string GetScreenResolution()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            return $"{screenWidth}x{screenHeight}";
        }
        public bool CheckEmulatorRequirements(string emulatorName)
        {
            switch (emulatorName)
            {
                case "NES":
                    return CheckRequirements(1, 128, 1);

                case "SNES":
                    return CheckRequirements(1, 256, 1);

                case "GB":
                    return CheckRequirements(0.5, 128, 1);

                case "GBA":
                    return CheckRequirements(1, 512, 1);

                case "N64":
                    return CheckRequirements(2, 1024, 2);

                default:
                    return false;
            }
        }

        private bool CheckRequirements(double cpuGHz, int ramMB, int graphicsVersion)
        {
            ManagementObjectSearcher cpuSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in cpuSearcher.Get())
            {
                double cpuSpeed = Convert.ToDouble(obj["MaxClockSpeed"]) / 1000;
                if (cpuSpeed >= cpuGHz)
                {
                    ManagementObjectSearcher ramSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                    ulong totalRam = 0;
                    foreach (ManagementObject ramObj in ramSearcher.Get())
                    {
                        totalRam += Convert.ToUInt64(ramObj["Capacity"]);
                    }
                    int ramGB = (int)(totalRam / (1024 * 1024 * 1024));
                    if (ramGB >= ramMB)
                    {
                        ManagementObjectSearcher graphicsSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                        foreach (ManagementObject graphicsObj in graphicsSearcher.Get())
                        {
                            string graphicsName = graphicsObj["Name"].ToString();
                            if (graphicsName.Contains("DirectX " + graphicsVersion))
                            {
                                string os = Environment.OSVersion.VersionString;
                                if (os.Contains("Windows") || os.Contains("Linux") || os.Contains("Mac"))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}