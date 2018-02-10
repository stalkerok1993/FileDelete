using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDelete {
    public partial class FormDeleteFiles : Form {
        public FormDeleteFiles() {
            InitializeComponent();
        }

        private void buttonBrouseDelete_Click(object sender, EventArgs e) {
            if (folderBrowserDialogDeleteRoot.ShowDialog() == DialogResult.OK) {
                textBoxDeleteRoot.Text = folderBrowserDialogDeleteRoot.SelectedPath;
            }
        }

        private void buttonBrouseCompare_Click(object sender, EventArgs e) {
            if (folderBrowserDialogCompareRoot.ShowDialog() == DialogResult.OK) {
                textBoxCompareRoot.Text = folderBrowserDialogCompareRoot.SelectedPath;
            }
        }

        private bool FoldersAreFilled() {
            return textBoxCompareRoot.Text.Length > 0 && textBoxDeleteRoot.Text.Length > 0;
        }

        private void MarkFiles() {
            if (!FoldersAreFilled()) {
                textBoxMarked.Clear();
                return;
            }

            string[] subfolderNames = textBoxSubFolders.Lines;
            if (subfolderNames.Length == 0) {
                subfolderNames = new[] {""};
            }

            DirectoryInfo[] deleteDirectorys = new DirectoryInfo[subfolderNames.Length];
            for (int i = 0; i < subfolderNames.Length; i++) {
                deleteDirectorys[i] = new DirectoryInfo(textBoxDeleteRoot.Text + "\\" + subfolderNames[i]);
            }
            IList<FileInfo> deleteDirectoryFiles = FindFilesRecursively(deleteDirectorys);

            DirectoryInfo[] compareDirectorys = new DirectoryInfo[subfolderNames.Length];
            for (int i = 0; i < subfolderNames.Length; i++) {
                compareDirectorys[i] = new DirectoryInfo(textBoxCompareRoot.Text + "\\" + subfolderNames[i]);
            }
            IList<FileInfo> compareDirectoryFiles = FindFilesRecursively(compareDirectorys);

            ISet<FileInfo> markedForDeletionFiles = new HashSet<FileInfo>(deleteDirectoryFiles);
            for (int i = 0; i < compareDirectoryFiles.Count; i++) {
                for (int j = 0; j < deleteDirectoryFiles.Count; j++) {
                    string compareSubpath = compareDirectoryFiles[i].FullName.Substring(textBoxCompareRoot.Text.Length);
                    string deleteSubpath = deleteDirectoryFiles[j].FullName.Substring(textBoxDeleteRoot.Text.Length);

                    if (compareSubpath.Equals(deleteSubpath)) {
                        markedForDeletionFiles.Remove(deleteDirectoryFiles[j]);
                    }
                }
            }
            
            string[] markedForDeletionFileNames = new string[markedForDeletionFiles.Count];
            int count = 0;
            foreach (FileInfo file in markedForDeletionFiles) {
                markedForDeletionFileNames[count++] = file.FullName;
            }

            textBoxMarked.Lines = markedForDeletionFileNames;
        }

        private IList<FileInfo> FindFilesRecursively(params DirectoryInfo[] directories) {
            List<FileInfo> files = new List<FileInfo>();

            foreach (DirectoryInfo directory in directories) {
                if (!directory.Exists) { continue; }

                files.AddRange(directory.EnumerateFiles());
                foreach (DirectoryInfo innerDirectory in directory.EnumerateDirectories()) {
                    files.AddRange(FindFilesRecursively(innerDirectory));
                }
            }

            return files;
        }

        private void buttonDeleteMarked_Click(object sender, EventArgs e) {
            string backupDirectory = textBoxBackup.Text;

            foreach (string markedFile in textBoxMarked.Lines) {
                FileInfo markedFileInfo = new FileInfo(markedFile);
                if (backupDirectory.Length > 0) {
                    string backupFileName = backupDirectory + ConvertPathToDirName(markedFileInfo.FullName);
                    try {
                        new DirectoryInfo(new FileInfo(backupFileName).DirectoryName).Create();
                        markedFileInfo.MoveTo(backupFileName);
                    }
                    catch (Exception ex) { }
                }
                else {
                    try {
                        markedFileInfo.Delete();
                    }
                    catch (Exception) { }
                }
            }

            MessageBox.Show("Complete!");
            textBoxMarked.Clear();
        }

        private string ConvertPathToDirName(string path) {
            string[] directoryParts = path.Split(new[] {'\\', ':'});
            StringBuilder newPath = new StringBuilder();

            for (int i = 0; i < directoryParts.Length; i++) {
                if (directoryParts[i].Length == 0) { continue; }

                newPath.Append("\\");
                newPath.Append(directoryParts[i]);
            }

            return newPath.ToString();
        }

        private void buttonBackup_Click(object sender, EventArgs e) {
            if (folderBrowserDialogBackup.ShowDialog() == DialogResult.OK) {
                textBoxBackup.Text = folderBrowserDialogBackup.SelectedPath;
            }
        }

        private void textBoxBackup_TextChanged(object sender, EventArgs e) {
            folderBrowserDialogBackup.SelectedPath = textBoxBackup.Text;
        }

        private void textBoxCompareRoot_TextChanged(object sender, EventArgs e) {
            folderBrowserDialogCompareRoot.SelectedPath = textBoxCompareRoot.Text;
            MarkFiles();
        }

        private void textBoxDeleteRoot_TextChanged(object sender, EventArgs e) {
            folderBrowserDialogDeleteRoot.SelectedPath = textBoxDeleteRoot.Text;
            MarkFiles();
        }

        private void textBoxSubFolders_TextChanged(object sender, EventArgs e) {
            MarkFiles();
        }
    }
}
