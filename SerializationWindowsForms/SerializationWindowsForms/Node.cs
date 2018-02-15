using System;

namespace SerializationWindowsForms
{
    /// <summary>
    /// Abstract class Node for presentation folder or file 
    /// </summary>
    [Serializable]
    public abstract class Node
    {
        protected int Index { get; set; }
        public abstract void Create(string pathForDesarialization);
        protected string GetNewPath(string pathForDesarialization, string oldPath)
        {
            string oldEndOfInputFolder = oldPath.Substring(Index);
            return pathForDesarialization + oldEndOfInputFolder;

        }
    }
}