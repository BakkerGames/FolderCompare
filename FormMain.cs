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

        private List<string> fromList = new List<string>();
        private List<string> toList = new List<string>();

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(textBoxFromPath.Text)) return;
            if (!Directory.Exists(textBoxToPath.Text)) return;
            Settings.Default.LastFromPath = textBoxFromPath.Text;
            Settings.Default.LastToPath = textBoxToPath.Text;
            Settings.Default.Save();
            fromList.Clear();
            toList.Clear();
            listBoxMain.Items.Clear();
            foreach (string s in Directory.EnumerateFiles(textBoxFromPath.Text))
            {
                if (ValidFilename(s))
                {
                    fromList.Add(s.Substring(s.LastIndexOf('\\') + 1));
                }
            }
            foreach (string s in Directory.EnumerateFiles(textBoxToPath.Text))
            {
                if (ValidFilename(s))
                {
                    toList.Add(s.Substring(s.LastIndexOf('\\') + 1));
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
        }

        private bool ValidFilename(string s)
        {
            if (s.EndsWith(".txt")) return true;
            return false;
        }
    }
}
