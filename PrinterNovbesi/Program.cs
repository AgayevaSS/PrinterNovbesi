using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Document;

namespace PrinterNovbesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
                var printer = new Printer();

                printer.AddDocumentToQueue(new Document("Document 1", 5));
                printer.AddDocumentToQueue(new Document("Document 2", 2));
                printer.AddDocumentToQueue(new Document("Document 3", 7));

                printer.PrintQueueStatus(); 

                printer.PrintNextDocument(); 

                printer.PrintQueueStatus(); 

                printer.PrintNextDocument();

                printer.PrintQueueStatus(); 

                printer.PrintNextDocument(); 

                printer.PrintQueueStatus();

                printer.PrintNextDocument(); 
            }
        }

    }
    public partial class Document
        {
            public string Name { get; set; }
            public int PageCount { get; set; }

            public Document(string name, int pageCount)
            {
                Name = name;
                PageCount = pageCount;
            }

}
  
