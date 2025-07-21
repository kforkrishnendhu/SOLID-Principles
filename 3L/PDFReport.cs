using System;
namespace SOLID.L
{
	public class PDFReport:ReportGenerator
	{
		public PDFReport()
		{

		}
		public override void GenerateReport()
        {
			Console.WriteLine("PDF report generated..");
        }
    }
}

