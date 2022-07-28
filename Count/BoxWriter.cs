using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class BoxWriter : IDisposable
    {
        char upperLeft = '┌';
        char lineHorizontal = '─';
        char upperRight = '┐';
        char lineVertical = '│';
        char downLeft = '└';
        char downRight = '┘';

        Int32 lineLength;
        StringBuilder buffer;
        TextWriter outWriter;
        public BoxWriter(Int32 lineLength, TextWriter outWriter)
        {
            this.lineLength = lineLength;
            this.buffer = new StringBuilder();
            this.PrintTopLine();
            this.outWriter = outWriter;
        }

        private void PrintBottomLine()
        {
            buffer.Append(Environment.NewLine);
            buffer.Append(downLeft);
            for (int i = 0; i < lineLength; i++)
            {
                buffer.Append(lineHorizontal);
            }
            buffer.Append(downRight);
        }

        private void PrintTopLine()
        {
            buffer.Append(upperLeft);
            for (int i = 0; i < lineLength; i++)
            {
                buffer.Append(lineHorizontal);
            }

            buffer.Append(upperRight);
        }

        public void Dispose()
        {
            this.PrintBottomLine();
            this.outWriter.WriteLine(this.buffer.ToString());
        }

        public void PrintLine(String msg)
        {
            this.buffer.Append(Environment.NewLine);
            this.buffer.Append(lineVertical);
            int pad = lineLength - msg.Length;
            this.buffer.Append(msg);
            for (int i = 0; i < pad; i++)
            {
                this.buffer.Append(' ');
            }

            this.buffer.Append(lineVertical);
        }
    }
}
