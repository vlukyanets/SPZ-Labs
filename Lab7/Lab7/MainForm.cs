using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Microsoft.Win32;

namespace LN_Lab2_Registry
{
    public partial class MainForm : Form
    {
        private String recentKey0 = "Recent0";
        private String recentKey1 = "Recent1";
        private String recentKey2 = "Recent2";

        private List<String> recentFiles = new List<String>();

        private void openFile(String _fileName)
        {
            try
            {
                FileStream fs = new FileStream(_fileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                textContainer.Text = sr.ReadToEnd();
                sr.Close();

                pushFileNameToRecent(_fileName);
            }
            catch (System.IO.FileNotFoundException)
            {
            } 
        }

        private void saveFile(String _fileName)
        {
            try
            {
                FileStream fs = new FileStream(_fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(textContainer.Text);
                sw.Close();

                pushFileNameToRecent(_fileName);
            }
            catch (System.IO.IOException)
            {
            }
        }

        private void saveRecentFileListToRegistry()
        {
            RegistryKey hk = Registry.CurrentUser;
            RegistryKey hkProgramKey = hk.OpenSubKey("TEXTEDITOR", true);
            if (hkProgramKey == null)
                hkProgramKey = hk.CreateSubKey("TEXTEDITOR");

            try
            {
                setRecentFileName(hkProgramKey, recentKey0, recentFiles[0]);
                setRecentFileName(hkProgramKey, recentKey1, recentFiles[1]);
                setRecentFileName(hkProgramKey, recentKey2, recentFiles[2]);
            }
            catch (ArgumentOutOfRangeException e)
            { }

            refillGuiRecentFileList();
        }

        private void pushFileNameToRecent(String _fileName)
        {
            recentFiles.Insert(0, _fileName);
            recentFiles = recentFiles.Take(3).ToList();

            saveRecentFileListToRegistry();
        }

        private String getRecentFileName(RegistryKey _rk, String _key)
        {
            return (String)_rk.GetValue(_key, null);
        }

        private void setRecentFileName(RegistryKey _rk, String _key, String _fileName)
        {
            _rk.SetValue(_key, _fileName);
        }

        private void recentFileItemClickHandler(object _sender, EventArgs _e)
        {
            String fileName = (String)((_sender as ToolStripItem).Text);
            openFile(fileName);
        }

        private void refillGuiRecentFileList()
        {
            openRecentToolStripMenuItem.DropDownItems.Clear();
            foreach (String recentFileName in recentFiles)
            {
                var recentFileItem = openRecentToolStripMenuItem.DropDownItems.Add(recentFileName);
                recentFileItem.Click += recentFileItemClickHandler;
            }
        }

        private void fillRecentFileList()
        {
            RegistryKey hk = Registry.CurrentUser;
            RegistryKey hkProgramKey = hk.OpenSubKey("TEXTEDITOR");
            if(hkProgramKey == null)
                hkProgramKey = hk.CreateSubKey("TEXTEDITOR");

            recentFiles.Clear();

            String recent0 = getRecentFileName(hkProgramKey, recentKey0);
            String recent1 = getRecentFileName(hkProgramKey, recentKey1);
            String recent2 = getRecentFileName(hkProgramKey, recentKey2);

            if (recent0 != null)
                recentFiles.Add(recent0);

            if (recent1 != null)
                recentFiles.Add(recent1);

            if (recent2 != null)
                recentFiles.Add(recent2);

            refillGuiRecentFileList();
        }

        public MainForm()
        {
            InitializeComponent();
            fillRecentFileList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.InitialDirectory.Length == 0)
                openFileDialog.InitialDirectory = @"C:\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                openFile(openFileDialog.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.InitialDirectory.Length == 0)
                saveFileDialog.InitialDirectory = @"C:\";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveFile(saveFileDialog.FileName);
        }
    }
}
