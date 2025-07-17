using System;
namespace SOLID.L
{
	public class ReadWriteFile:ILoad,IWrite
	{
        public string FilePath { get; set; }

        public string FileText { get; set; }

        public string LoadText()
        {
            return "Read only file";
        }

        public void SaveText()
        {
            //Code to save text
        }
    }
}

