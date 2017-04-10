using System;
using System.Collections.Generic;
using System.Text;
using EntryControl.Classes;

namespace EntryPoint
{
    public class PermitSelectedEventArgs : EventArgs
    {
        public Permit Permit { get; private set; }

        public PermitSelectedEventArgs(Permit permit)
            : base()
        {
            Permit = permit;
        }
    }

}
