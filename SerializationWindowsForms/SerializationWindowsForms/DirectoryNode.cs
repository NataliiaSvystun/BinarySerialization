using System;
using System.IO;

namespace SerializationWindowsForms
{
    [Serializable]
    public class DirectoryNode : Node
    {
        public DirectoryInfo Folder { get; set; }

        public DirectoryNode(DirectoryInfo folder, int index)
        {
            this.Index = index;
            this.Folder = folder;
        }

        public override void Create(string pathForDesarialization)
        {
            DirectoryInfo newDirectoryInfo = new DirectoryInfo(this.GetNewPath(pathForDesarialization, this.Folder.FullName));
            newDirectoryInfo.Create();
        }

    }
}
