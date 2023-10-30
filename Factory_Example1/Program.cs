namespace Factory_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentCreator reportCreator = new ReportCreator("12345");
            Document report = reportCreator.CreateDocument();
            report.CreateDocument();
        }
    }
    public abstract class Document
    {
        public abstract void CreateDocument();
    }
    public class Report : Document
    {
        private string reportId;
        public Report(string reportId)
        {
            this.reportId = reportId;
        }

        public override void CreateDocument()
        {
            Console.WriteLine("Created Report Document");
        }
    }
    public class Resume : Document
    {
        public override void CreateDocument()
        {
            Console.WriteLine("Creating resume document");
        }
    }
    public abstract class DocumentCreator
    {
        public abstract Document CreateDocument();
    }
    public class ReportCreator : DocumentCreator
    {
        private string reportId;
        public ReportCreator(string reportId)
        {
            this.reportId = reportId;
        }

        public override Document CreateDocument()
        {
            return new Report(reportId);
        }
    }
    public class ResumeCreator : DocumentCreator
    {
        public override Document CreateDocument()
        {
            return new Resume();
        }
    }
}