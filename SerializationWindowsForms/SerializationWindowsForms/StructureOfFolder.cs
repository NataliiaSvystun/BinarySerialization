using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationWindowsForms
{
    /// <summary>
    /// class StructureOfFolder creates List<Node> for serialization
    /// and deserialization materials(folder and file)
    /// </summary>
    public class StructureOfFolder
    {
        private List<Node> _listNodes;

        public StructureOfFolder()
        {
            _listNodes = new List<Node>();
        }

        public void Serialization(string serializationFolder)
        {
            int index = serializationFolder.LastIndexOf('\\');
            try
            {
                this.CreateStructureOfFolder(new DirectoryInfo(serializationFolder), index);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Failed to create Structure. Reason: " + e.Message);
                throw;
            }
            FileStream stream = File.Create("Data.dat");
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(stream, _listNodes);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                stream.Close();
            }
        }

        public void Deserialization(string deserializationFolder)
        {
            List<Node> addresses = null;
            FileStream fs = new FileStream("Data.dat", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                addresses = (List<Node>)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            foreach (Node node in addresses)
            {
                node.Create(deserializationFolder);
            }

        }

        public void CreateStructureOfFolder(DirectoryInfo serializationFolder, int index)
        {
            Node node = new DirectoryNode(serializationFolder, index);
            _listNodes.Add(node);

            if (serializationFolder.GetFiles().Length != 0)
            {
                FileInfo[] arrayFiles = serializationFolder.GetFiles();
                foreach (var item in arrayFiles)
                {
                    Node fileNode = new FileNode(item, index);
                    _listNodes.Add(fileNode);
                }

            }
            if (serializationFolder.GetDirectories().Length != 0)
            {
                DirectoryInfo[] arrayDirectoryInfo = serializationFolder.GetDirectories();
                foreach (var item in arrayDirectoryInfo)
                {
                    this.CreateStructureOfFolder(item, index);
                }
            }
        }
    }
}
