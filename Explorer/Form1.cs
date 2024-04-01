using Explorer.Handlers;
using Explorer.Models;
using System.Diagnostics;

namespace Explorer
{
    public partial class Form1 : Form
    {
        List<string> _filesList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = "";
            if (String.IsNullOrEmpty(textBoxPath.Text))
            {
                using (FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = "Select path to directory" })
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        path = dialog.SelectedPath;
                        textBoxPath.Text = path;
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                path = textBoxPath.Text;
            }
            _filesList.Clear();
            listView.Items.Clear();
            var elements = ReceiveFiles(path);
            foreach (var item in elements.Directories)
            {
                var icon = DefaultFolderIcon.Folder32;
                imageList.Images.Add(icon);
                var fi = new DirectoryInfo(item.Path);
                _filesList.Add(fi.FullName);
                listView.Items.Add(fi.Name, imageList.Images.Count - 1);
            }
            foreach (var item in elements.Files)
            {
                imageList.Images.Add(Icon.ExtractAssociatedIcon(item.Path)!);
                var fi = new FileInfo(item.Path);
                _filesList.Add(fi.FullName);
                listView.Items.Add(fi.Name, imageList.Images.Count - 1);
            }
        }

        public DirectoriesAndFilesModel ReceiveFiles(string path)
        {
            var listOfDirectories = System.IO.Directory.GetDirectories(path);
            var directories = new List<Models.Directory>();
            foreach(var directory in listOfDirectories)
            {
                directories.Add(new Models.Directory() { Path = directory, Type = "directory" });
            }
            
            var listOfFiles = System.IO.Directory.GetFiles(path);
            var files = new List<Models.File>();
            foreach (var file in listOfFiles)
            {
                files.Add(new Models.File() { Path = file, Type = "file" });
            }
            //var elements = directories.Concat(files).ToArray();
            return new DirectoriesAndFilesModel() { Directories = directories, Files = files };
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem != null)
            {
                using (var process = new Process())
                {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = _filesList[listView.FocusedItem.Index];
                    process.Start();
                }
            }
        }
    }
}