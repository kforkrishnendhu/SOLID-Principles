using System;
namespace SOLID.D
{
	public class ProductService
	{
        public readonly ILog _log;
        //public readonly FileLogger _fileLogger = new FileLogger();
        //public readonly DatabaseLogger _databaseLogger = new DatabaseLogger();

  //      public void LogToFile(string message)
		//{
		//	_fileLogger.Log(message);
		//}

  //      public void LogToDatabase(string message)
  //      {
  //          _databaseLogger.Log(message);
  //      }

		public ProductService(ILog log)
		{
			_log = log;
		}

		public void Log(string message)
		{
			_log.Log(message);
		}
		//Then from the main method of Program.cs we can create instance of that interface
		//either for database logger or for filelogger.. then call the log method.

    }
}

