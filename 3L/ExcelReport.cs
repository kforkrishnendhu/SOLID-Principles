using System;
namespace SOLID.L
{
	public class ExcelReport:ReportGenerator
	{
		public ExcelReport()
		{
		}

        public override void GenerateReport()
        {
            Console.WriteLine("Excel report generated..");
        }
    }
}

