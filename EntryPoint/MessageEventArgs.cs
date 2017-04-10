using System;
using System.Collections.Generic;
using System.Text;

namespace EntryPoint
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MessageEventArgs(string message)
            : base()
        {
            Message = message;
        }

        public MessageEventArgs() : this(string.Empty) { }
    }
}
