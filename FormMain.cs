using FolderCompare.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FolderCompare
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxFromPath.Text = Settings.Default.LastFromPath;
            textBoxToPath.Text = Settings.Default.LastToPath;
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxFromPath.Text)) return;
            if (!Directory.Exists(textBoxToPath.Text)) return;
            Settings.Default.LastFromPath = textBoxFromPath.Text;
            Settings.Default.LastToPath = textBoxToPath.Text;
            Settings.Default.Save();
            listBoxMain.Items.Clear();
            DoCompare(textBoxFromPath.Text, textBoxToPath.Text);
        }

        private void DoCompare(string fromPath, string toPath)
        {
            List<string> fromList = new List<string>();
            List<string> toList = new List<string>();
            fromList.Clear();
            toList.Clear();
            if (Directory.Exists(fromPath))
            {
                foreach (string s in Directory.EnumerateFiles(fromPath))
                {
                    if (ValidFilename(s))
                    {
                        fromList.Add(s.Substring(textBoxFromPath.Text.Length + 1));
                    }
                }
            }
            if (Directory.Exists(toPath))
            {
                foreach (string s in Directory.EnumerateFiles(toPath))
                {
                    if (ValidFilename(s))
                    {
                        toList.Add(s.Substring(textBoxToPath.Text.Length + 1));
                    }
                }
            }
            foreach (string s in fromList)
            {
                if (!toList.Contains(s))
                {
                    listBoxMain.Items.Add($"<-- {s}");
                }
                else
                {
                    FileInfo fileFrom = new FileInfo($"{textBoxFromPath.Text}\\{s}");
                    FileInfo fileTo = new FileInfo($"{textBoxToPath.Text}\\{s}");
                    if (fileFrom.Length != fileTo.Length)
                    {
                        listBoxMain.Items.Add($"<-> {s}");
                    }
                }
            }
            foreach (string s in toList)
            {
                if (!fromList.Contains(s))
                {
                    listBoxMain.Items.Add($"--> {s}");
                }
            }
            foreach (string subDir in Directory.EnumerateDirectories(fromPath))
            {
                string subDirBase = Path.GetFileName(subDir);
                if (ValidDirectory(subDirBase))
                {
                    DoCompare(Path.Combine(fromPath, subDirBase), Path.Combine(toPath, subDirBase));
                }
            }
        }

        private bool ValidDirectory(string s)
        {
            if (s.StartsWith(".")) return false;
            return true;
        }

        private bool ValidFilename(string s)
        {
            if (s.EndsWith(".txt")) return true;
            if (s.EndsWith(".html")) return true;
            if (s.EndsWith(".css")) return true;
            return false;
        }
    }
}
