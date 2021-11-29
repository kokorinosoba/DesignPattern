using System;
using System.Text;

namespace Builder
{
    public class TextBuilder : Builder
    {
        private StringBuilder _buffer { get; } = new StringBuilder();

        public TextBuilder()
        {
        }

        public override void MakeTitle(string title)
        {
            _buffer.Append("========================================\n");
            _buffer.Append($"『{title}』\n");
            _buffer.Append("\n");
        }

        public override void MakeString(string str)
        {
            _buffer.Append($"■{str}\n");
            _buffer.Append("\n");
        }

        public override void MakeItems(string[] items)
        {
            foreach (string item in items)
            {
                _buffer.Append($"　・{item}\n");
            }
            _buffer.Append("\n");
        }

        public override void Close()
        {
            _buffer.Append("========================================\n");
        }

        public string GetResult()
        {
            return _buffer.ToString();
        }
    }
}
