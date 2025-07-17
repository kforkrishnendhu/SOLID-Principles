using System;
namespace SOLID.L
{
	public class ReadOnlyFile : ILoad
	{
		public string FilePath { get; set; }

		public string FileText { get; set; }

		public string LoadText()
		{
			return "Read only file";
		}

		
	}
}

