using System;
using System.Collections.Generic;
public partial class Document
        {
    public class Printer
    {
        private Queue<Document> _printQueue = new Queue<Document>();

        public void AddDocumentToQueue(Document document)
        {
            _printQueue.Enqueue(document);
            Console.WriteLine($"{document.Name} added to print queue.");
        }

        public void PrintNextDocument()
        {
            if (_printQueue.Count == 0)
            {
                Console.WriteLine("Print queue is empty.");
                return;
            }

            var nextDocument = _printQueue.Dequeue();
            Console.WriteLine($"Printing document: {nextDocument.Name}");
        }

        public void PrintQueueStatus()
        {
            Console.WriteLine($"Documents in print queue: {_printQueue.Count}");
            if (_printQueue.Count > 0)
            {
                Console.WriteLine($"Next document to print: {_printQueue.Peek().Name}");
            }
        }
    }

}
  
