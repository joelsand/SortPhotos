using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace SortPhotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSortNow_Click(object sender, EventArgs e)
        {
            string sourceDir = txtSourceDir.Text;
            string destDirPhotos = txtDestPhotos.Text;
            string destDirPhotosRaw = txtDestPhotosRaw.Text;
            string destDirVideos = txtDestinationVideos.Text;

            using (StreamWriter successLog = new StreamWriter(Path.Combine(destDirPhotos, "SortPhotos-Success.log")))
            using (StreamWriter errorLog = new StreamWriter(Path.Combine(destDirPhotos, "SortPhotos-Error.log")))
            {
                successLog.AutoFlush = true;
                errorLog.AutoFlush = true;

                SortDirectory(chkMakeCopies.Checked, sourceDir, destDirPhotos, destDirPhotosRaw, destDirVideos, successLog, errorLog);
            }
        }

        private void SortDirectory(bool makeCopies, string sourceDir, string destDirPhotos, string destDirPhotosRaw, string destDirVideos, StreamWriter successLog, StreamWriter errorLog)
        {
            string[] fileFind = Directory.GetFiles(sourceDir);

            foreach (string name in fileFind)
            {
                if (name == "." || name == "..")
                    continue;

                string path = name;
                string destPath = "";
                try
                {
                    string year, month, day;

                    // try to get exif data
                    try
                    {
                        Bitmap bitmap = new Bitmap(path);
                        PropertyItem prop = bitmap.GetPropertyItem(36867);

                        year = string.Format("{0}{1}{2}{3}", (char)prop.Value[0], (char)prop.Value[1], (char)prop.Value[2], (char)prop.Value[3]);
                        month = string.Format("{0}{1}", (char)prop.Value[5], (char)prop.Value[6]);
                        day = string.Format("{0}{1}", (char)prop.Value[8], (char)prop.Value[9]);
                    }
                    catch
                    {
                        // just use file created date
                        DateTime date = File.GetLastWriteTime(path);
                        year = date.Year.ToString("0000");
                        month = date.Month.ToString("00");
                        day = date.Day.ToString("00");
                    }

                    // copy/move to folder
                    string destDir;
                    switch (Path.GetExtension(name).ToLower())
                    {
                        case ".crw":
                        case ".raw":
                        case ".cr2":
                        case ".dng":
                            destDir = destDirPhotosRaw;
                            break;
                        case ".mov":
                        case ".avi":
                            destDir = destDirVideos;
                            break;

                        case ".jpg":
                        case ".jpeg":
                        case ".png":
                        case ".bmp":
                        default:
                            destDir = destDirPhotos;
                            break;
                    }
                    string destRelPath = string.Format("{0}\\{1}\\{2}-{3}-{4}", year, month, year, month, day);
                    string thisDestDir = Path.Combine(destDir, destRelPath);
                    destPath = Path.Combine(thisDestDir, Path.GetFileName(name));

                    if (!File.Exists(destPath))
                    {
                        if (!Directory.Exists(thisDestDir))
                            Directory.CreateDirectory(thisDestDir);

                        if (makeCopies)
                        {
                            File.Copy(path, destPath);
                            successLog.WriteLine("Copied '" + path + "' to '" + destPath + "'");
                        }
                        else
                        {
                            File.Move(path, destPath);
                            successLog.WriteLine("Move '" + path + "' to '" + destPath + "'");
                        }
                    }
                    else
                    {
                        successLog.WriteLine("File already exists '" + path + "' to '" + destPath + "'");
                    }

                }
                catch (Exception ex)
                {
                    successLog.WriteLine("Failing copying '" + path + "' to '" + destPath + "': " + ex.Message);
                }
            }

            // directories
            string[] dirs = Directory.GetDirectories(sourceDir);
            foreach (string name in dirs)
            {
                if (name == "." || name == "..")
                    continue;

                string path = name;
                SortDirectory(makeCopies, path, destDirPhotos, destDirPhotosRaw, destDirVideos, successLog, errorLog);

            }
        }
    }
}
