using System;
namespace SOLID.L
{
	public class ReportPrinter
	{
		public void PrintReport(ReportGenerator generator)
		{
			generator.GenerateReport();
		}
	}
}

