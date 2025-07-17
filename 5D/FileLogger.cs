using System;
namespace SOLID.D
{
	public class FileLogger:ILog
	{
		public void Log(string message)
		{
			Console.WriteLine("Inside Log method of FileLogger");
			LogToFile(message);
		}

		private void LogToFile(string message)
		{
			Console.WriteLine("Method: LogToFile, Text:{0}", message);
		}
	}
}

