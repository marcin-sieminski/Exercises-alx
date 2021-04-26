using System.Collections.Generic;
using System.IO;

namespace FolderSynchronizationLibrary
{
    public class FolderSynchronization
    {
        public string FirstFolderPath { get; set; }
        public string SecondFolderPath { get; set; }
        public string DestinationFolderPath { get; set; }
        public string[] FileNameExtensions { get; set; }
        public List<FileSynch> FilesSynch { get; set; } = new List<FileSynch>();
        public List<FileSynch> FilesFirstFolder { get; set; } = new List<FileSynch>();
        public List<FileSynch> FilesSecondFolder { get; set; } = new List<FileSynch>();

        public void SynchronizeFolders()
        {
            Directory.CreateDirectory(DestinationFolderPath);
            ReadFilesToList(DestinationFolderPath, FilesFirstFolder);
            ReadFilesToList(FirstFolderPath, FilesSynch);
            ReadFilesToList(SecondFolderPath, FilesSecondFolder);

            SynchSourceFolder(FirstFolderPath, FilesFirstFolder);
            SynchSourceFolder(SecondFolderPath, FilesSecondFolder);
        }

        private void SynchSourceFolder(string folderPath, List<FileSynch> filesList)
        {
            string[] filesInFolder = Directory.GetFiles(folderPath);
            foreach (var fileInFolder in filesInFolder)
            {
                var fileName = fileInFolder.Substring(fileInFolder.LastIndexOf('\\') + 1);
                var fileInFolderLastWriteTime = File.GetLastWriteTime(fileInFolder);
                var fileExists = false;

                foreach (var fileNameExtension in FileNameExtensions)
                {
                    if (fileInFolder.EndsWith(fileNameExtension))
                    {
                        foreach (var fileSynch in FilesSynch)
                        {
                            if (fileSynch.FileName == fileName)
                            {
                                fileExists = true;

                                if (fileSynch.LastWriteTime < fileInFolderLastWriteTime)
                                {
                                    fileSynch.FileContent += File.ReadAllText(fileInFolder);
                                    fileSynch.LastWriteTime = fileInFolderLastWriteTime;
                                }
                                else if (fileSynch.LastWriteTime > fileInFolderLastWriteTime)
                                {
                                    var newerContent = fileSynch.FileContent;
                                    fileSynch.FileContent = File.ReadAllText(fileInFolder) + newerContent;
                                }
                            }
                        }

                        if (!fileExists)
                        {
                            var file = new FileSynch
                            {
                                FileName = fileName,
                                LastWriteTime = fileInFolderLastWriteTime,
                                FileContent = File.ReadAllText(fileInFolder)
                            };
                            FilesSynch.Add(file);
                        }
                    }
                }
            }

            foreach (var fileSynch in FilesSynch)
            {
                File.WriteAllText(Path.Combine(DestinationFolderPath, fileSynch.FileName), fileSynch.FileContent);
                File.SetLastWriteTime(Path.Combine(DestinationFolderPath, fileSynch.FileName), fileSynch.LastWriteTime);
            }
        }

        private void ReadFilesToList(string path, List<FileSynch> listOfFiles)
        {
            string[] filesSynchFiles = Directory.GetFiles(path);

            foreach (var fileInSynchFolder in filesSynchFiles)
            {
                foreach (var fileNameExtension in FileNameExtensions)
                {
                    if (fileInSynchFolder.EndsWith(fileNameExtension))
                    {
                        var file = new FileSynch
                        {
                            FileName = fileInSynchFolder.Substring(fileInSynchFolder.LastIndexOf('\\') + 1),
                            LastWriteTime = File.GetLastWriteTime(fileInSynchFolder),
                            FileContent = File.ReadAllText(fileInSynchFolder)
                        };
                        listOfFiles.Add(file);
                    }
                }
            }
        }
    }
}
