using System;
using System.Text;

namespace SOLID.L
{
	public class SqlFileManager
	{
		public List<ILoad> allFiles { get; set; }

        public List<IWrite> writeFiles { get; set; }

        public string GetTextFromFiles()
		{
			StringBuilder objStrBuilder = new StringBuilder();
			foreach(var objFile in allFiles)
			{
				objStrBuilder.Append(objFile.LoadText());
			}
			return objStrBuilder.ToString();
		}

		public void SaveTextIntoFile()
		{
            //foreach(var objFile in allFiles)
            //{
            //	if(!(objFile is ReadOnlyFile))      //violates liskov substitution principle
            //	{                                   //because only based on some condition the child class methods are calling
            //		objFile.SaveText();             // not all are properly implemented
            //	}
            //}

            foreach (var objFile in writeFiles)
            {
                objFile.SaveText();
            }
        }
	}
}

