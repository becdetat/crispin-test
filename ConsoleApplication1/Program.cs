using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASP;
using crispin;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new _test_cshtml();
            var xrpt = test.TransformText();

            // Convert to byte[] for streaming etc:
            //var converter = new PdfReportConverter();
            //var buffer = converter.ConvertToBuffer(xrpt, "Test report");
            //Console.Write(buffer);

            var reportingService = new ReportingService();
            reportingService.OpenAsPdf(xrpt, "Test report");

            Console.Read();
        }
    }
}
