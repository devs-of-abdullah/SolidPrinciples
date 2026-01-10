public class DIPReports
{

    public interface IReportGenerator
{
    public void Generate();

}


public class PdfReportGenerator : IReportGenerator
{
    public void Generate()
    {
        Console.WriteLine("PDF report generated :-).");
    }
}


public class ExcelReportGenerator : IReportGenerator
{
    public void Generate()
    {
        Console.WriteLine("Excel report generated :-).");
    }
}




    public class WordReportGenerator : IReportGenerator
    {
        public void Generate()
        {
            Console.WriteLine("Word report generated :-).");
        }
    }


    


    public class ReportGenerator
    {
        private IReportGenerator _ReportGenerator;

        public ReportGenerator(IReportGenerator reportGenerator)
        {
            _ReportGenerator = reportGenerator;

        }

        public void GenerateReport()
        {
            _ReportGenerator.Generate();
        }

    }


    public static void ExecuteClass()
    {
        ReportGenerator reportGenerator = new ReportGenerator(new PdfReportGenerator());
        reportGenerator.GenerateReport();


        reportGenerator = new ReportGenerator(new ExcelReportGenerator());
        reportGenerator.GenerateReport();

        reportGenerator = new ReportGenerator(new WordReportGenerator());
        reportGenerator.GenerateReport();



        Console.ReadKey();

    }
    
}