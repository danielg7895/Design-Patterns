using System;

namespace TemplateMethodPattern
{
    class TemplateMethod
    {
        public void Main()
        {
            FileSaver jsonSaver = new JSONSaver("some data");
            FileSaver xmlSaver = new XMLSaver("some data");

            jsonSaver.Save();
            xmlSaver.Save();
        }
    }

    public abstract class FileSaver
    {
        string Data { get; set; }

        public FileSaver(string data)
        {
            Data = data;
        }
        public abstract void Save();
    }

    public class JSONSaver : FileSaver
    {

        public JSONSaver(string data) : base(data){ }
        public override void Save()
        {
            Console.WriteLine("The file was saved as a JSON object");
        }
    }

    public class XMLSaver : FileSaver
    {
        public XMLSaver(string data) : base(data) { }

        public override void Save()
        {
            Console.WriteLine("The file was saved as a XML object");
        }
    }
}
