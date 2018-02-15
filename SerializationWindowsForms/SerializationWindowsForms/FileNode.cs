using System;
using System.IO;

namespace SerializationWindowsForms
{
    [Serializable]
    public class FileNode : Node
    {
        public FileInfo File { get; set; }
        
        /// <summary>
        /// property Content contents content of file
        /// </summary>
        public byte[] Content { get; set; }

        public FileNode(FileInfo file, int index)
        {
            this.Index = index;
            this.File = file;
            this.Content = System.IO.File.ReadAllBytes(File.FullName);
        }

        public override void Create(string pathForDesarialization)
        {
            FileInfo newFileInfo = new FileInfo(this.GetNewPath(pathForDesarialization, this.File.FullName));
            using (var fs = newFileInfo.Create())
            {
                fs.Write(this.Content, 0, this.Content.Length);
            }
        }
    }
}
