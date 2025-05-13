using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InterfaceVSAbstract
{// -- interfaces vs abstract classes
 // 1. Interface IWorker, abstract class WorkerBase, class RemoteWorker → implement both.
    interface IWorker
    {
        void RunWorker();
    }
    public abstract class WorkerBase
    {
        public abstract void CallWorker();
    }
    public class RemoteWorker : WorkerBase, IWorker
    {
        public void RunWorker()
        {
            Console.WriteLine("This is RunWorker running after inheritance.");
        }
        public override void CallWorker()
        {
            Console.WriteLine("This is CallWorker running after implementation");
        }
    }
 // 2. Create two interfaces with same method name. Resolve with explicit implementation.
    interface I1
    {
        void print();
    }
    interface I2
    {
        void print();
    }
    public class Printer:I1, I2
    {
        void I1.print()
        {
            Console.WriteLine("I1, Print");
        }
        void I2.print()
        {
            Console.WriteLine("I2, Print");
        }
    }
 // 3. Create IReport → implemented by PDFReport, CSVReport. Run via interface.
    public interface IReport
    {
        void print();
    }
    public class PDFReport:IReport
    {
        public void print()
        {
            Console.WriteLine("PDF");
        }
    }
    public class CSVReport: IReport
    {
        public void print()
        {
            Console.WriteLine("CSV");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IReport report = new PDFReport();
            report.print();
            report=new CSVReport();
            report.print();

            Console.Read();
            
        }
    }
}
