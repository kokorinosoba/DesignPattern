using System;
using System.IO;

namespace Builder
{
    public class HTMLBuilder : Builder
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private string _filename { get; set; }
        private StreamWriter _writer { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public override void MakeTitle(string title)
        {
            _filename = title + ".html";
            using StreamWriter _writer = File.CreateText(_filename);
            _writer.WriteLine($"<html><head><title>{title}</title></head></body>");
            _writer.WriteLine($"<h1>{title}</h1>");
        }

        public override void MakeString(string str)
        {
            using StreamWriter _writer = File.CreateText(_filename);
            _writer.WriteLine($"<p>{str}</p>");
        }

        public override void MakeItems(string[] items)
        {
            using StreamWriter _writer = File.CreateText(_filename);
            _writer.WriteLine("<ul>");
            foreach (string item in items)
            {
                _writer.WriteLine($"<li>{item}</li>");
            }
            _writer.WriteLine("</ul");
        }

        public override void Close()
        {
            using StreamWriter _writer = File.CreateText(_filename);
            _writer.WriteLine("</body></html>");
            _writer.Close();
        }

        public string GetResult()
        {
            return _filename;
        }
    }
}
